﻿// Copyright (c) 2017 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Engine;
using SiliconStudio.Xenko.Engine.Design;
using SiliconStudio.Xenko.Games;
using SiliconStudio.Xenko.Physics;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Core.Reflection;
using SiliconStudio.Xenko.Navigation.Processors;

namespace SiliconStudio.Xenko.Navigation
{
    /// <summary>
    /// System that handles building of navigation meshes at runtime
    /// </summary>
    public class DynamicNavigationMeshSystem : GameSystem
    {
        /// <summary>
        /// If <c>true</c>, this will automatically rebuild on addition/removal of static collider components
        /// </summary>
        [DataMember(5)]
        public bool AutomaticRebuild { get; set; } = true;

        /// <summary>
        /// Collision filter that indicates which colliders are used in navmesh generation
        /// </summary>
        [DataMember(10)]
        public CollisionFilterGroupFlags IncludedCollisionGroups { get; set; }

        /// <summary>
        /// Build settings used by Recast
        /// </summary>
        [DataMember(20)]
        public NavigationMeshBuildSettings BuildSettings { get; set; }
        
        /// <summary>
        /// Settings for agents used with the dynamic navigation mesh
        /// </summary>
        [DataMember(30)]
        public List<NavigationMeshGroup> Groups { get; private set; } = new List<NavigationMeshGroup>();

        private bool pendingRebuild = true;

        private SceneInstance currentSceneInstance;

        private NavigationMeshBuilder builder = new NavigationMeshBuilder();

        private CancellationTokenSource buildTaskCancellationTokenSource;

        private StaticColliderProcessor processor;

        public DynamicNavigationMeshSystem(IServiceRegistry registry) : base(registry)
        {
            Enabled = true;
            EnabledChanged += OnEnabledChanged;
        }

        /// <summary>
        /// Raised when the navigation mesh for the current scene is updated
        /// </summary>
        public event EventHandler NavigationUpdated;

        /// <summary>
        /// The most recently built navigation mesh
        /// </summary>
        public NavigationMesh CurrentNavigationMesh { get; private set; }

        /// <inheritdoc />
        public override void Initialize()
        {
            base.Initialize();

            if (Game.Settings != null)
            {
                InitializeSettingsFromGameSettings(Game.Settings);
            }
            else
            {
                // Initial build settings
                BuildSettings = ObjectFactoryRegistry.NewInstance<NavigationMeshBuildSettings>();
                IncludedCollisionGroups = CollisionFilterGroupFlags.AllFilter;
                Groups = new List<NavigationMeshGroup>
                {
                    ObjectFactoryRegistry.NewInstance<NavigationMeshGroup>()
                };
            }
        }

        /// <summary>
        /// Copies the default settings from the <see cref="GameSettings"/> for building navigation
        /// </summary>
        public void InitializeSettingsFromGameSettings(GameSettings gameSettings)
        {
            if (gameSettings == null)
                throw new ArgumentNullException(nameof(gameSettings));

            // Initialize build settings from game settings
            var navigationSettings = gameSettings.Configurations.Get<NavigationSettings>();

            BuildSettings = navigationSettings.BuildSettings;
            IncludedCollisionGroups = navigationSettings.IncludedCollisionGroups;
            Groups = navigationSettings.Groups;
            Enabled = navigationSettings.EnableDynamicNavigationMesh;

            
            pendingRebuild = true;
        }

        /// <inheritdoc />
        public override void Update(GameTime gameTime)
        {
            // This system should before becomming functional
            if (!Enabled)
                return;
            
            if (currentSceneInstance != Game.SceneSystem?.SceneInstance)
            {
                // ReSharper disable once PossibleNullReferenceException
                UpdateScene(Game.SceneSystem.SceneInstance);
            }

            if (pendingRebuild && currentSceneInstance != null)
            {
                Game.Script.AddTask(async () =>
                {
                    // TODO EntityProcessors
                    // Currently have to wait a frame for transformations to update
                    // for example when calling Rebuild from the event that a component was added to the scene, this component will not be in the correct location yet
                    // since the TransformProcessor runs the next frame
                    await Game.Script.NextFrame();
                    await Rebuild();
                });
                pendingRebuild = false;
            }
        }

        /// <summary>
        /// Starts an asynchronous rebuild of the navigation mesh
        /// </summary>
        public async Task<NavigationMeshBuildResult> Rebuild()
        {
            if (currentSceneInstance == null)
                return new NavigationMeshBuildResult();

            // Cancel running build, TODO check if the running build can actual satisfy the current rebuild request and don't cancel in that case
            buildTaskCancellationTokenSource?.Cancel();
            buildTaskCancellationTokenSource = new CancellationTokenSource();

            // Collect bounding boxes
            var boundingBoxProcessor = currentSceneInstance.GetProcessor<BoundingBoxProcessor>();
            if (boundingBoxProcessor == null)
                return new NavigationMeshBuildResult();

            List<BoundingBox> boundingBoxes = new List<BoundingBox>();
            foreach (var boundingBox in boundingBoxProcessor.BoundingBoxes)
            {
                Vector3 scale;
                Quaternion rotation;
                Vector3 translation;
                boundingBox.Entity.Transform.WorldMatrix.Decompose(out scale, out rotation, out translation);
                boundingBoxes.Add(new BoundingBox(translation - scale, translation + scale));
            }

            var result = Task.Run(() =>
            {
                // Only have one active build at a time
                lock (builder)
                {
                    return builder.Build(BuildSettings, Groups, IncludedCollisionGroups,  boundingBoxes, buildTaskCancellationTokenSource.Token);
                }
            });
            await result;

            FinilizeRebuild(result);

            return result.Result;
        }

        private void FinilizeRebuild(Task<NavigationMeshBuildResult> resultTask)
        {
            var result = resultTask.Result;
            if (result.Success)
            {
                CurrentNavigationMesh = result.NavigationMesh;
                NavigationUpdated?.Invoke(this, null);
            }
        }

        private void UpdateScene(SceneInstance newSceneInstance)
        {
            if (currentSceneInstance != null)
            {
                if (processor != null)
                {
                    currentSceneInstance.Processors.Remove(processor);
                    processor.ColliderAdded -= ProcessorOnColliderAdded;
                    processor.ColliderRemoved -= ProcessorOnColliderRemoved;
                }

                // Clear builder
                builder = new NavigationMeshBuilder();
            }

            // Set the currect scene
            currentSceneInstance = newSceneInstance;

            if (currentSceneInstance != null)
            {
                // Scan for components
                processor = new StaticColliderProcessor();
                processor.ColliderAdded += ProcessorOnColliderAdded;
                processor.ColliderRemoved += ProcessorOnColliderRemoved;
                currentSceneInstance.Processors.Add(processor);

                pendingRebuild = true;
            }
        }

        private void ProcessorOnColliderAdded(StaticColliderComponent component, StaticColliderData data)
        {
            builder.Add(data);
            if (AutomaticRebuild)
            {
                pendingRebuild = true;
            }
        }

        private void ProcessorOnColliderRemoved(StaticColliderComponent component, StaticColliderData data)
        {
            builder.Remove(data);
            if (AutomaticRebuild)
            {
                pendingRebuild = true;
            }
        }

        private void Cleanup()
        {
            UpdateScene(null);
            
            CurrentNavigationMesh = null;
            NavigationUpdated?.Invoke(this, null);
        }

        private void OnEnabledChanged(object sender, EventArgs eventArgs)
        {
            if (!Enabled)
            {
                Cleanup();
            }
            else
            {
                pendingRebuild = true;
            }
        }
    }
}