﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Rendering;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Xenko.Graphics.Buffer;

namespace SiliconStudio.Xenko.Rendering.Images
{
    internal static partial class BrightFilterShaderKeys
    {
        public static readonly ValueParameterKey<Color3> ColorModulator = ParameterKeys.NewValue<Color3>();
        public static readonly ValueParameterKey<float> BrightPassSteepness = ParameterKeys.NewValue<float>(2.0f);
        public static readonly ValueParameterKey<float> ThresholdOffset = ParameterKeys.NewValue<float>(0.2f);
    }
}
