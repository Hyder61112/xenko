﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_VULKAN
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [SpriteBatch]
//
//     Command Line: C:\work\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\Bin\Windows\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-Vulkan --platform=Windows --output-path=C:\work\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=C:\work\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    public partial class SpriteBatch
    {
        private static readonly byte[] binaryBytecode = new byte[] {
5, 192, 254, 239, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 1, 5, 0, 0, 0, 255, 255, 
255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 7, 
80, 101, 114, 68, 114, 97, 119, 10, 0, 0, 0, 26, 0, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 0, 7, 80, 101, 114, 68, 114, 97, 119, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 64, 0, 0, 
0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 26, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 46, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 
0, 20, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 8, 80, 79, 83, 73, 84, 73, 79, 78, 0, 0, 0, 0, 0, 5, 67, 
79, 76, 79, 82, 0, 0, 0, 0, 0, 13, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 0, 0, 0, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 0, 0, 5, 67, 79, 76, 79, 82, 1, 0, 0, 0, 0, 6, 0, 0, 0, 17, 83, 112, 114, 105, 116, 101, 
66, 97, 116, 99, 104, 83, 104, 97, 100, 101, 114, 1, 87, 155, 60, 200, 236, 20, 84, 200, 152, 231, 83, 66, 92, 179, 206, 238, 10, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 1, 164, 17, 184, 245, 17, 45, 155, 200, 33, 38, 142, 140, 129, 225, 169, 76, 10, 83, 104, 97, 100, 101, 114, 66, 
97, 115, 101, 1, 19, 254, 2, 71, 132, 171, 122, 228, 200, 79, 246, 26, 216, 77, 88, 75, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 152, 255, 232, 84, 18, 0, 123, 93, 132, 190, 129, 88, 230, 39, 237, 88, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 
1, 169, 217, 238, 31, 185, 166, 138, 247, 206, 107, 18, 41, 22, 134, 250, 234, 12, 67, 111, 108, 111, 114, 85, 116, 105, 108, 105, 116, 121, 1, 13, 55, 119, 11, 74, 248, 67, 231, 218, 255, 136, 40, 165, 3, 100, 169, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 211, 216, 201, 224, 217, 200, 
189, 50, 196, 80, 134, 134, 198, 234, 39, 129, 0, 58, 16, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 8, 80, 79, 83, 73, 84, 73, 79, 78, 1, 0, 0, 0, 0, 5, 67, 79, 76, 79, 82, 2, 0, 0, 0, 0, 13, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 
3, 0, 0, 0, 0, 9, 84, 69, 88, 67, 79, 79, 82, 68, 48, 4, 0, 0, 0, 0, 6, 67, 79, 76, 79, 82, 49, 0, 1, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 4, 0, 0, 0, 0, 216, 15, 0, 0, 3, 2, 35, 7, 0, 0, 1, 0, 1, 0, 8, 0, 126, 0, 0, 
0, 0, 0, 0, 0, 17, 0, 2, 0, 1, 0, 0, 0, 17, 0, 2, 0, 32, 0, 0, 0, 17, 0, 2, 0, 33, 0, 0, 0, 11, 0, 6, 0, 1, 0, 0, 0, 71, 76, 83, 76, 46, 115, 116, 100, 46, 52, 53, 48, 0, 0, 0, 0, 14, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 
0, 15, 0, 15, 0, 0, 0, 0, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 35, 0, 0, 0, 40, 0, 0, 0, 46, 0, 0, 0, 51, 0, 0, 0, 54, 0, 0, 0, 100, 0, 0, 0, 105, 0, 0, 0, 109, 0, 0, 0, 113, 0, 0, 0, 116, 0, 0, 0, 3, 0, 3, 
0, 2, 0, 0, 0, 194, 1, 0, 0, 5, 0, 4, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 5, 0, 5, 0, 9, 0, 0, 0, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 0, 0, 0, 0, 80, 111, 115, 105, 116, 105, 111, 
110, 95, 105, 100, 55, 49, 0, 0, 0, 6, 0, 6, 0, 9, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 2, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 0, 0, 0, 0, 6, 0, 7, 
0, 9, 0, 0, 0, 3, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 4, 0, 0, 0, 67, 111, 108, 111, 114, 65, 100, 100, 95, 105, 100, 55, 53, 0, 0, 0, 6, 0, 8, 0, 9, 0, 0, 0, 5, 0, 0, 
0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 5, 0, 16, 0, 13, 0, 0, 0, 86, 83, 77, 97, 105, 110, 95, 105, 100, 50, 40, 115, 116, 114, 117, 99, 116, 45, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 45, 118, 102, 52, 45, 118, 102, 
52, 45, 102, 49, 45, 118, 102, 50, 45, 118, 102, 52, 45, 118, 102, 52, 49, 59, 0, 0, 0, 5, 0, 4, 0, 12, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 4, 0, 22, 0, 0, 0, 80, 101, 114, 68, 114, 97, 119, 0, 6, 0, 9, 0, 22, 0, 0, 0, 0, 0, 0, 
0, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 0, 0, 0, 0, 5, 0, 3, 0, 24, 0, 0, 0, 0, 0, 0, 0, 5, 0, 5, 0, 30, 0, 0, 0, 86, 83, 95, 73, 78, 80, 85, 84, 0, 0, 0, 0, 6, 0, 7, 0, 30, 0, 0, 
0, 0, 0, 0, 0, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 0, 0, 0, 6, 0, 6, 0, 30, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 30, 0, 0, 0, 2, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 
95, 105, 100, 55, 54, 0, 0, 0, 0, 6, 0, 7, 0, 30, 0, 0, 0, 3, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 30, 0, 0, 0, 4, 0, 0, 0, 67, 111, 108, 111, 114, 65, 100, 100, 95, 105, 100, 55, 53, 0, 0, 
0, 5, 0, 5, 0, 32, 0, 0, 0, 95, 48, 105, 110, 112, 117, 116, 95, 48, 0, 0, 0, 5, 0, 5, 0, 35, 0, 0, 0, 97, 95, 67, 79, 76, 79, 82, 49, 0, 0, 0, 0, 5, 0, 5, 0, 40, 0, 0, 0, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 7, 
0, 46, 0, 0, 0, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 5, 0, 5, 0, 51, 0, 0, 0, 97, 95, 67, 79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 5, 0, 54, 0, 0, 0, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 
0, 5, 0, 4, 0, 57, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 4, 0, 73, 0, 0, 0, 112, 97, 114, 97, 109, 0, 0, 0, 5, 0, 5, 0, 77, 0, 0, 0, 86, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 8, 0, 77, 0, 0, 0, 0, 0, 0, 
0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 6, 0, 6, 0, 77, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 77, 0, 0, 0, 2, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 
95, 105, 100, 55, 54, 0, 0, 0, 0, 6, 0, 7, 0, 77, 0, 0, 0, 3, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 77, 0, 0, 0, 4, 0, 0, 0, 67, 111, 108, 111, 114, 65, 100, 100, 95, 105, 100, 55, 53, 0, 0, 
0, 5, 0, 5, 0, 79, 0, 0, 0, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 0, 0, 5, 0, 6, 0, 98, 0, 0, 0, 103, 108, 95, 80, 101, 114, 86, 101, 114, 116, 101, 120, 0, 0, 0, 0, 6, 0, 6, 0, 98, 0, 0, 0, 0, 0, 0, 0, 103, 108, 95, 80, 111, 115, 105, 
116, 105, 111, 110, 0, 6, 0, 7, 0, 98, 0, 0, 0, 1, 0, 0, 0, 103, 108, 95, 80, 111, 105, 110, 116, 83, 105, 122, 101, 0, 0, 0, 0, 6, 0, 7, 0, 98, 0, 0, 0, 2, 0, 0, 0, 103, 108, 95, 67, 108, 105, 112, 68, 105, 115, 116, 97, 110, 99, 101, 0, 6, 0, 7, 
0, 98, 0, 0, 0, 3, 0, 0, 0, 103, 108, 95, 67, 117, 108, 108, 68, 105, 115, 116, 97, 110, 99, 101, 0, 5, 0, 3, 0, 100, 0, 0, 0, 0, 0, 0, 0, 5, 0, 5, 0, 105, 0, 0, 0, 118, 95, 67, 79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 7, 0, 109, 0, 0, 
0, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 5, 0, 5, 0, 113, 0, 0, 0, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 5, 0, 116, 0, 0, 0, 118, 95, 67, 79, 76, 79, 82, 49, 0, 0, 0, 0, 5, 0, 5, 
0, 125, 0, 0, 0, 78, 111, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 72, 0, 4, 0, 22, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 72, 0, 5, 0, 22, 0, 0, 0, 0, 0, 0, 0, 35, 0, 0, 0, 0, 0, 0, 0, 72, 0, 5, 0, 22, 0, 0, 0, 0, 0, 0, 
0, 7, 0, 0, 0, 16, 0, 0, 0, 71, 0, 3, 0, 22, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 24, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 24, 0, 0, 0, 33, 0, 0, 0, 4, 0, 0, 0, 71, 0, 4, 0, 35, 0, 0, 0, 30, 0, 0, 
0, 4, 0, 0, 0, 71, 0, 4, 0, 40, 0, 0, 0, 30, 0, 0, 0, 3, 0, 0, 0, 71, 0, 4, 0, 46, 0, 0, 0, 30, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 51, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 54, 0, 0, 0, 30, 0, 0, 
0, 0, 0, 0, 0, 72, 0, 5, 0, 98, 0, 0, 0, 0, 0, 0, 0, 11, 0, 0, 0, 0, 0, 0, 0, 72, 0, 5, 0, 98, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 1, 0, 0, 0, 72, 0, 5, 0, 98, 0, 0, 0, 2, 0, 0, 0, 11, 0, 0, 0, 3, 0, 0, 
0, 72, 0, 5, 0, 98, 0, 0, 0, 3, 0, 0, 0, 11, 0, 0, 0, 4, 0, 0, 0, 71, 0, 3, 0, 98, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 105, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 109, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 
0, 71, 0, 4, 0, 113, 0, 0, 0, 30, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 116, 0, 0, 0, 30, 0, 0, 0, 3, 0, 0, 0, 71, 0, 4, 0, 125, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 19, 0, 2, 0, 2, 0, 0, 0, 33, 0, 3, 0, 3, 0, 0, 
0, 2, 0, 0, 0, 22, 0, 3, 0, 6, 0, 0, 0, 32, 0, 0, 0, 23, 0, 4, 0, 7, 0, 0, 0, 6, 0, 0, 0, 4, 0, 0, 0, 23, 0, 4, 0, 8, 0, 0, 0, 6, 0, 0, 0, 2, 0, 0, 0, 30, 0, 8, 0, 9, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 
0, 6, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 10, 0, 0, 0, 7, 0, 0, 0, 9, 0, 0, 0, 33, 0, 4, 0, 11, 0, 0, 0, 2, 0, 0, 0, 10, 0, 0, 0, 21, 0, 4, 0, 15, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 
0, 43, 0, 4, 0, 15, 0, 0, 0, 16, 0, 0, 0, 5, 0, 0, 0, 43, 0, 4, 0, 15, 0, 0, 0, 17, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 18, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 24, 0, 4, 0, 21, 0, 0, 0, 7, 0, 0, 0, 4, 0, 0, 
0, 30, 0, 3, 0, 22, 0, 0, 0, 21, 0, 0, 0, 32, 0, 4, 0, 23, 0, 0, 0, 2, 0, 0, 0, 22, 0, 0, 0, 59, 0, 4, 0, 23, 0, 0, 0, 24, 0, 0, 0, 2, 0, 0, 0, 32, 0, 4, 0, 25, 0, 0, 0, 2, 0, 0, 0, 21, 0, 0, 0, 30, 0, 7, 
0, 30, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 31, 0, 0, 0, 7, 0, 0, 0, 30, 0, 0, 0, 43, 0, 4, 0, 15, 0, 0, 0, 33, 0, 0, 0, 4, 0, 0, 0, 32, 0, 4, 0, 34, 0, 0, 
0, 1, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 34, 0, 0, 0, 35, 0, 0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 15, 0, 0, 0, 38, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 39, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 39, 0, 0, 
0, 40, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 42, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 43, 0, 4, 0, 15, 0, 0, 0, 44, 0, 0, 0, 2, 0, 0, 0, 32, 0, 4, 0, 45, 0, 0, 0, 1, 0, 0, 0, 6, 0, 0, 0, 59, 0, 4, 0, 45, 0, 0, 
0, 46, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 48, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 43, 0, 4, 0, 15, 0, 0, 0, 50, 0, 0, 0, 1, 0, 0, 0, 59, 0, 4, 0, 34, 0, 0, 0, 51, 0, 0, 0, 1, 0, 0, 0, 59, 0, 4, 0, 34, 0, 0, 
0, 54, 0, 0, 0, 1, 0, 0, 0, 30, 0, 7, 0, 77, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 78, 0, 0, 0, 7, 0, 0, 0, 77, 0, 0, 0, 21, 0, 4, 0, 95, 0, 0, 0, 32, 0, 0, 
0, 0, 0, 0, 0, 43, 0, 4, 0, 95, 0, 0, 0, 96, 0, 0, 0, 1, 0, 0, 0, 28, 0, 4, 0, 97, 0, 0, 0, 6, 0, 0, 0, 96, 0, 0, 0, 30, 0, 6, 0, 98, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 97, 0, 0, 0, 97, 0, 0, 0, 32, 0, 4, 
0, 99, 0, 0, 0, 3, 0, 0, 0, 98, 0, 0, 0, 59, 0, 4, 0, 99, 0, 0, 0, 100, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 103, 0, 0, 0, 3, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 103, 0, 0, 0, 105, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 
0, 108, 0, 0, 0, 3, 0, 0, 0, 6, 0, 0, 0, 59, 0, 4, 0, 108, 0, 0, 0, 109, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 112, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 112, 0, 0, 0, 113, 0, 0, 0, 3, 0, 0, 0, 59, 0, 4, 
0, 103, 0, 0, 0, 116, 0, 0, 0, 3, 0, 0, 0, 26, 0, 2, 0, 123, 0, 0, 0, 32, 0, 4, 0, 124, 0, 0, 0, 0, 0, 0, 0, 123, 0, 0, 0, 59, 0, 4, 0, 124, 0, 0, 0, 125, 0, 0, 0, 0, 0, 0, 0, 54, 0, 5, 0, 2, 0, 0, 0, 4, 0, 0, 
0, 0, 0, 0, 0, 3, 0, 0, 0, 248, 0, 2, 0, 5, 0, 0, 0, 59, 0, 4, 0, 31, 0, 0, 0, 32, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 57, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 73, 0, 0, 0, 7, 0, 0, 
0, 59, 0, 4, 0, 78, 0, 0, 0, 79, 0, 0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 36, 0, 0, 0, 35, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 37, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 62, 0, 3, 0, 37, 0, 0, 0, 36, 0, 0, 
0, 61, 0, 4, 0, 8, 0, 0, 0, 41, 0, 0, 0, 40, 0, 0, 0, 65, 0, 5, 0, 42, 0, 0, 0, 43, 0, 0, 0, 32, 0, 0, 0, 38, 0, 0, 0, 62, 0, 3, 0, 43, 0, 0, 0, 41, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 47, 0, 0, 0, 46, 0, 0, 
0, 65, 0, 5, 0, 48, 0, 0, 0, 49, 0, 0, 0, 32, 0, 0, 0, 44, 0, 0, 0, 62, 0, 3, 0, 49, 0, 0, 0, 47, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 52, 0, 0, 0, 51, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 53, 0, 0, 0, 32, 0, 0, 
0, 50, 0, 0, 0, 62, 0, 3, 0, 53, 0, 0, 0, 52, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 55, 0, 0, 0, 54, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 56, 0, 0, 0, 32, 0, 0, 0, 17, 0, 0, 0, 62, 0, 3, 0, 56, 0, 0, 0, 55, 0, 0, 
0, 65, 0, 5, 0, 18, 0, 0, 0, 58, 0, 0, 0, 32, 0, 0, 0, 17, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 59, 0, 0, 0, 58, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 60, 0, 0, 0, 57, 0, 0, 0, 17, 0, 0, 0, 62, 0, 3, 0, 60, 0, 0, 
0, 59, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 61, 0, 0, 0, 32, 0, 0, 0, 50, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 62, 0, 0, 0, 61, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 63, 0, 0, 0, 57, 0, 0, 0, 50, 0, 0, 0, 62, 0, 3, 
0, 63, 0, 0, 0, 62, 0, 0, 0, 65, 0, 5, 0, 48, 0, 0, 0, 64, 0, 0, 0, 32, 0, 0, 0, 44, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 65, 0, 0, 0, 64, 0, 0, 0, 65, 0, 5, 0, 48, 0, 0, 0, 66, 0, 0, 0, 57, 0, 0, 0, 44, 0, 0, 
0, 62, 0, 3, 0, 66, 0, 0, 0, 65, 0, 0, 0, 65, 0, 5, 0, 42, 0, 0, 0, 67, 0, 0, 0, 32, 0, 0, 0, 38, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 68, 0, 0, 0, 67, 0, 0, 0, 65, 0, 5, 0, 42, 0, 0, 0, 69, 0, 0, 0, 57, 0, 0, 
0, 38, 0, 0, 0, 62, 0, 3, 0, 69, 0, 0, 0, 68, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 70, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 71, 0, 0, 0, 70, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 72, 0, 0, 
0, 57, 0, 0, 0, 33, 0, 0, 0, 62, 0, 3, 0, 72, 0, 0, 0, 71, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 74, 0, 0, 0, 57, 0, 0, 0, 62, 0, 3, 0, 73, 0, 0, 0, 74, 0, 0, 0, 57, 0, 5, 0, 2, 0, 0, 0, 75, 0, 0, 0, 13, 0, 0, 
0, 73, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 76, 0, 0, 0, 73, 0, 0, 0, 62, 0, 3, 0, 57, 0, 0, 0, 76, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 80, 0, 0, 0, 57, 0, 0, 0, 16, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 81, 0, 0, 
0, 80, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 82, 0, 0, 0, 79, 0, 0, 0, 17, 0, 0, 0, 62, 0, 3, 0, 82, 0, 0, 0, 81, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 83, 0, 0, 0, 57, 0, 0, 0, 50, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 
0, 84, 0, 0, 0, 83, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 85, 0, 0, 0, 79, 0, 0, 0, 50, 0, 0, 0, 62, 0, 3, 0, 85, 0, 0, 0, 84, 0, 0, 0, 65, 0, 5, 0, 48, 0, 0, 0, 86, 0, 0, 0, 57, 0, 0, 0, 44, 0, 0, 0, 61, 0, 4, 
0, 6, 0, 0, 0, 87, 0, 0, 0, 86, 0, 0, 0, 65, 0, 5, 0, 48, 0, 0, 0, 88, 0, 0, 0, 79, 0, 0, 0, 44, 0, 0, 0, 62, 0, 3, 0, 88, 0, 0, 0, 87, 0, 0, 0, 65, 0, 5, 0, 42, 0, 0, 0, 89, 0, 0, 0, 57, 0, 0, 0, 38, 0, 0, 
0, 61, 0, 4, 0, 8, 0, 0, 0, 90, 0, 0, 0, 89, 0, 0, 0, 65, 0, 5, 0, 42, 0, 0, 0, 91, 0, 0, 0, 79, 0, 0, 0, 38, 0, 0, 0, 62, 0, 3, 0, 91, 0, 0, 0, 90, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 92, 0, 0, 0, 57, 0, 0, 
0, 33, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 93, 0, 0, 0, 92, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 94, 0, 0, 0, 79, 0, 0, 0, 33, 0, 0, 0, 62, 0, 3, 0, 94, 0, 0, 0, 93, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 101, 0, 0, 
0, 79, 0, 0, 0, 17, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 102, 0, 0, 0, 101, 0, 0, 0, 65, 0, 5, 0, 103, 0, 0, 0, 104, 0, 0, 0, 100, 0, 0, 0, 17, 0, 0, 0, 62, 0, 3, 0, 104, 0, 0, 0, 102, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 
0, 106, 0, 0, 0, 79, 0, 0, 0, 50, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 107, 0, 0, 0, 106, 0, 0, 0, 62, 0, 3, 0, 105, 0, 0, 0, 107, 0, 0, 0, 65, 0, 5, 0, 48, 0, 0, 0, 110, 0, 0, 0, 79, 0, 0, 0, 44, 0, 0, 0, 61, 0, 4, 
0, 6, 0, 0, 0, 111, 0, 0, 0, 110, 0, 0, 0, 62, 0, 3, 0, 109, 0, 0, 0, 111, 0, 0, 0, 65, 0, 5, 0, 42, 0, 0, 0, 114, 0, 0, 0, 79, 0, 0, 0, 38, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 115, 0, 0, 0, 114, 0, 0, 0, 62, 0, 3, 
0, 113, 0, 0, 0, 115, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 117, 0, 0, 0, 79, 0, 0, 0, 33, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 118, 0, 0, 0, 117, 0, 0, 0, 62, 0, 3, 0, 116, 0, 0, 0, 118, 0, 0, 0, 65, 0, 6, 0, 108, 0, 0, 
0, 119, 0, 0, 0, 100, 0, 0, 0, 17, 0, 0, 0, 96, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 120, 0, 0, 0, 119, 0, 0, 0, 127, 0, 4, 0, 6, 0, 0, 0, 121, 0, 0, 0, 120, 0, 0, 0, 65, 0, 6, 0, 108, 0, 0, 0, 122, 0, 0, 0, 100, 0, 0, 
0, 17, 0, 0, 0, 96, 0, 0, 0, 62, 0, 3, 0, 122, 0, 0, 0, 121, 0, 0, 0, 253, 0, 1, 0, 56, 0, 1, 0, 54, 0, 5, 0, 2, 0, 0, 0, 13, 0, 0, 0, 0, 0, 0, 0, 11, 0, 0, 0, 55, 0, 3, 0, 10, 0, 0, 0, 12, 0, 0, 0, 248, 0, 2, 
0, 14, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 19, 0, 0, 0, 12, 0, 0, 0, 17, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 20, 0, 0, 0, 19, 0, 0, 0, 65, 0, 5, 0, 25, 0, 0, 0, 26, 0, 0, 0, 24, 0, 0, 0, 17, 0, 0, 0, 61, 0, 4, 
0, 21, 0, 0, 0, 27, 0, 0, 0, 26, 0, 0, 0, 144, 0, 5, 0, 7, 0, 0, 0, 28, 0, 0, 0, 20, 0, 0, 0, 27, 0, 0, 0, 65, 0, 5, 0, 18, 0, 0, 0, 29, 0, 0, 0, 12, 0, 0, 0, 16, 0, 0, 0, 62, 0, 3, 0, 29, 0, 0, 0, 28, 0, 0, 
0, 253, 0, 1, 0, 56, 0, 1, 0, 0, 5, 0, 0, 0, 1, 152, 77, 39, 92, 118, 129, 171, 140, 34, 18, 133, 143, 2, 142, 232, 214, 0, 208, 18, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 
48, 2, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 3, 0, 0, 0, 0, 148, 18, 0, 0, 3, 2, 35, 7, 0, 0, 1, 0, 1, 0, 8, 0, 180, 0, 0, 0, 0, 0, 0, 0, 17, 0, 2, 0, 1, 0, 0, 0, 11, 0, 6, 0, 
1, 0, 0, 0, 71, 76, 83, 76, 46, 115, 116, 100, 46, 52, 53, 48, 0, 0, 0, 0, 14, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 15, 0, 11, 0, 4, 0, 0, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 134, 0, 0, 0, 138, 0, 0, 0, 142, 0, 0, 0, 
145, 0, 0, 0, 148, 0, 0, 0, 176, 0, 0, 0, 16, 0, 3, 0, 4, 0, 0, 0, 7, 0, 0, 0, 3, 0, 3, 0, 2, 0, 0, 0, 194, 1, 0, 0, 5, 0, 4, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 5, 0, 5, 0, 9, 0, 0, 0, 80, 83, 95, 83, 
84, 82, 69, 65, 77, 83, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 0, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 0, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 1, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 
6, 0, 6, 0, 9, 0, 0, 0, 2, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 3, 0, 0, 0, 67, 111, 108, 111, 114, 65, 100, 100, 95, 105, 100, 55, 53, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 4, 0, 0, 0, 
67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 0, 5, 0, 15, 0, 13, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 51, 40, 115, 116, 114, 117, 99, 116, 45, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 45, 102, 49, 45, 118, 102, 50, 45, 118, 102, 52, 
45, 118, 102, 52, 45, 118, 102, 52, 49, 59, 0, 0, 5, 0, 4, 0, 12, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 15, 0, 16, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 52, 40, 115, 116, 114, 117, 99, 116, 45, 80, 83, 95, 83, 84, 82, 69, 65, 77, 
83, 45, 102, 49, 45, 118, 102, 50, 45, 118, 102, 52, 45, 118, 102, 52, 45, 118, 102, 52, 49, 59, 0, 0, 5, 0, 4, 0, 15, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 6, 0, 20, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 0, 0, 0, 
5, 0, 6, 0, 24, 0, 0, 0, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 0, 0, 0, 0, 5, 0, 6, 0, 37, 0, 0, 0, 115, 119, 105, 122, 122, 108, 101, 67, 111, 108, 111, 114, 0, 0, 0, 0, 5, 0, 4, 0, 51, 0, 0, 0, 112, 97, 114, 97, 109, 0, 0, 0, 
5, 0, 4, 0, 57, 0, 0, 0, 112, 97, 114, 97, 109, 0, 0, 0, 5, 0, 3, 0, 70, 0, 0, 0, 110, 88, 0, 0, 5, 0, 3, 0, 77, 0, 0, 0, 110, 89, 0, 0, 5, 0, 3, 0, 85, 0, 0, 0, 110, 90, 0, 0, 5, 0, 5, 0, 116, 0, 0, 0, 102, 105, 110, 97, 
108, 67, 111, 108, 111, 114, 0, 0, 5, 0, 5, 0, 129, 0, 0, 0, 86, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 8, 0, 129, 0, 0, 0, 0, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 6, 0, 6, 0, 
129, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 52, 0, 0, 6, 0, 7, 0, 129, 0, 0, 0, 2, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 0, 0, 0, 0, 6, 0, 7, 0, 129, 0, 0, 0, 3, 0, 0, 0, 84, 101, 120, 67, 
111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 129, 0, 0, 0, 4, 0, 0, 0, 67, 111, 108, 111, 114, 65, 100, 100, 95, 105, 100, 55, 53, 0, 0, 0, 5, 0, 5, 0, 131, 0, 0, 0, 95, 48, 105, 110, 112, 117, 116, 95, 48, 0, 0, 0, 5, 0, 5, 0, 
134, 0, 0, 0, 118, 95, 67, 79, 76, 79, 82, 49, 0, 0, 0, 0, 5, 0, 5, 0, 138, 0, 0, 0, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 7, 0, 142, 0, 0, 0, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 
5, 0, 5, 0, 145, 0, 0, 0, 118, 95, 67, 79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 6, 0, 148, 0, 0, 0, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 0, 0, 0, 0, 5, 0, 4, 0, 151, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 4, 0, 
164, 0, 0, 0, 112, 97, 114, 97, 109, 0, 0, 0, 5, 0, 5, 0, 169, 0, 0, 0, 80, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 7, 0, 169, 0, 0, 0, 0, 0, 0, 0, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 0, 5, 0, 5, 0, 
171, 0, 0, 0, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 0, 0, 5, 0, 10, 0, 176, 0, 0, 0, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 0, 5, 0, 5, 0, 179, 0, 0, 0, 
78, 111, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 71, 0, 4, 0, 20, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 20, 0, 0, 0, 33, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 24, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 
24, 0, 0, 0, 33, 0, 0, 0, 3, 0, 0, 0, 71, 0, 4, 0, 134, 0, 0, 0, 30, 0, 0, 0, 3, 0, 0, 0, 71, 0, 4, 0, 138, 0, 0, 0, 30, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 142, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 
145, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 148, 0, 0, 0, 11, 0, 0, 0, 15, 0, 0, 0, 71, 0, 4, 0, 176, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 179, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 19, 0, 2, 0, 
2, 0, 0, 0, 33, 0, 3, 0, 3, 0, 0, 0, 2, 0, 0, 0, 22, 0, 3, 0, 6, 0, 0, 0, 32, 0, 0, 0, 23, 0, 4, 0, 7, 0, 0, 0, 6, 0, 0, 0, 2, 0, 0, 0, 23, 0, 4, 0, 8, 0, 0, 0, 6, 0, 0, 0, 4, 0, 0, 0, 30, 0, 7, 0, 
9, 0, 0, 0, 6, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 8, 0, 0, 0, 8, 0, 0, 0, 32, 0, 4, 0, 10, 0, 0, 0, 7, 0, 0, 0, 9, 0, 0, 0, 33, 0, 4, 0, 11, 0, 0, 0, 8, 0, 0, 0, 10, 0, 0, 0, 25, 0, 9, 0, 18, 0, 0, 0, 
6, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 19, 0, 0, 0, 0, 0, 0, 0, 18, 0, 0, 0, 59, 0, 4, 0, 19, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0, 26, 0, 2, 0, 
22, 0, 0, 0, 32, 0, 4, 0, 23, 0, 0, 0, 0, 0, 0, 0, 22, 0, 0, 0, 59, 0, 4, 0, 23, 0, 0, 0, 24, 0, 0, 0, 0, 0, 0, 0, 27, 0, 3, 0, 26, 0, 0, 0, 18, 0, 0, 0, 21, 0, 4, 0, 28, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 
43, 0, 4, 0, 28, 0, 0, 0, 29, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 30, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 36, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 43, 0, 4, 0, 28, 0, 0, 0, 39, 0, 0, 0, 0, 0, 0, 0, 
32, 0, 4, 0, 40, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 43, 0, 4, 0, 6, 0, 0, 0, 43, 0, 0, 0, 0, 0, 128, 63, 43, 0, 4, 0, 6, 0, 0, 0, 46, 0, 0, 0, 205, 204, 204, 61, 20, 0, 2, 0, 47, 0, 0, 0, 43, 0, 4, 0, 6, 0, 0, 0, 
64, 0, 0, 0, 0, 0, 0, 64, 21, 0, 4, 0, 71, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 43, 0, 4, 0, 71, 0, 0, 0, 72, 0, 0, 0, 0, 0, 0, 0, 43, 0, 4, 0, 71, 0, 0, 0, 78, 0, 0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 71, 0, 0, 0, 
83, 0, 0, 0, 3, 0, 0, 0, 43, 0, 4, 0, 6, 0, 0, 0, 93, 0, 0, 0, 0, 0, 0, 0, 43, 0, 4, 0, 6, 0, 0, 0, 98, 0, 0, 0, 0, 0, 0, 63, 43, 0, 4, 0, 71, 0, 0, 0, 101, 0, 0, 0, 2, 0, 0, 0, 43, 0, 4, 0, 6, 0, 0, 0, 
105, 0, 0, 0, 0, 0, 64, 64, 43, 0, 4, 0, 28, 0, 0, 0, 118, 0, 0, 0, 2, 0, 0, 0, 43, 0, 4, 0, 28, 0, 0, 0, 122, 0, 0, 0, 3, 0, 0, 0, 30, 0, 7, 0, 129, 0, 0, 0, 8, 0, 0, 0, 8, 0, 0, 0, 6, 0, 0, 0, 7, 0, 0, 0, 
8, 0, 0, 0, 32, 0, 4, 0, 130, 0, 0, 0, 7, 0, 0, 0, 129, 0, 0, 0, 43, 0, 4, 0, 28, 0, 0, 0, 132, 0, 0, 0, 4, 0, 0, 0, 32, 0, 4, 0, 133, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 133, 0, 0, 0, 134, 0, 0, 0, 
1, 0, 0, 0, 32, 0, 4, 0, 137, 0, 0, 0, 1, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 137, 0, 0, 0, 138, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 141, 0, 0, 0, 1, 0, 0, 0, 6, 0, 0, 0, 59, 0, 4, 0, 141, 0, 0, 0, 142, 0, 0, 0, 
1, 0, 0, 0, 59, 0, 4, 0, 133, 0, 0, 0, 145, 0, 0, 0, 1, 0, 0, 0, 59, 0, 4, 0, 133, 0, 0, 0, 148, 0, 0, 0, 1, 0, 0, 0, 30, 0, 3, 0, 169, 0, 0, 0, 8, 0, 0, 0, 32, 0, 4, 0, 170, 0, 0, 0, 7, 0, 0, 0, 169, 0, 0, 0, 
32, 0, 4, 0, 175, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 175, 0, 0, 0, 176, 0, 0, 0, 3, 0, 0, 0, 59, 0, 4, 0, 23, 0, 0, 0, 179, 0, 0, 0, 0, 0, 0, 0, 54, 0, 5, 0, 2, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 
3, 0, 0, 0, 248, 0, 2, 0, 5, 0, 0, 0, 59, 0, 4, 0, 130, 0, 0, 0, 131, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 151, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 164, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 
170, 0, 0, 0, 171, 0, 0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 135, 0, 0, 0, 134, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 136, 0, 0, 0, 131, 0, 0, 0, 132, 0, 0, 0, 62, 0, 3, 0, 136, 0, 0, 0, 135, 0, 0, 0, 61, 0, 4, 0, 
7, 0, 0, 0, 139, 0, 0, 0, 138, 0, 0, 0, 65, 0, 5, 0, 30, 0, 0, 0, 140, 0, 0, 0, 131, 0, 0, 0, 122, 0, 0, 0, 62, 0, 3, 0, 140, 0, 0, 0, 139, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 143, 0, 0, 0, 142, 0, 0, 0, 65, 0, 5, 0, 
40, 0, 0, 0, 144, 0, 0, 0, 131, 0, 0, 0, 118, 0, 0, 0, 62, 0, 3, 0, 144, 0, 0, 0, 143, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 146, 0, 0, 0, 145, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 147, 0, 0, 0, 131, 0, 0, 0, 29, 0, 0, 0, 
62, 0, 3, 0, 147, 0, 0, 0, 146, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 149, 0, 0, 0, 148, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 150, 0, 0, 0, 131, 0, 0, 0, 39, 0, 0, 0, 62, 0, 3, 0, 150, 0, 0, 0, 149, 0, 0, 0, 65, 0, 5, 0, 
36, 0, 0, 0, 152, 0, 0, 0, 131, 0, 0, 0, 29, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 153, 0, 0, 0, 152, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 154, 0, 0, 0, 151, 0, 0, 0, 118, 0, 0, 0, 62, 0, 3, 0, 154, 0, 0, 0, 153, 0, 0, 0, 
65, 0, 5, 0, 40, 0, 0, 0, 155, 0, 0, 0, 131, 0, 0, 0, 118, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 156, 0, 0, 0, 155, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 157, 0, 0, 0, 151, 0, 0, 0, 39, 0, 0, 0, 62, 0, 3, 0, 157, 0, 0, 0, 
156, 0, 0, 0, 65, 0, 5, 0, 30, 0, 0, 0, 158, 0, 0, 0, 131, 0, 0, 0, 122, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 159, 0, 0, 0, 158, 0, 0, 0, 65, 0, 5, 0, 30, 0, 0, 0, 160, 0, 0, 0, 151, 0, 0, 0, 29, 0, 0, 0, 62, 0, 3, 0, 
160, 0, 0, 0, 159, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 161, 0, 0, 0, 131, 0, 0, 0, 132, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 162, 0, 0, 0, 161, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 163, 0, 0, 0, 151, 0, 0, 0, 122, 0, 0, 0, 
62, 0, 3, 0, 163, 0, 0, 0, 162, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 165, 0, 0, 0, 151, 0, 0, 0, 62, 0, 3, 0, 164, 0, 0, 0, 165, 0, 0, 0, 57, 0, 5, 0, 8, 0, 0, 0, 166, 0, 0, 0, 16, 0, 0, 0, 164, 0, 0, 0, 61, 0, 4, 0, 
9, 0, 0, 0, 167, 0, 0, 0, 164, 0, 0, 0, 62, 0, 3, 0, 151, 0, 0, 0, 167, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 168, 0, 0, 0, 151, 0, 0, 0, 132, 0, 0, 0, 62, 0, 3, 0, 168, 0, 0, 0, 166, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 
172, 0, 0, 0, 151, 0, 0, 0, 132, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 173, 0, 0, 0, 172, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 174, 0, 0, 0, 171, 0, 0, 0, 39, 0, 0, 0, 62, 0, 3, 0, 174, 0, 0, 0, 173, 0, 0, 0, 65, 0, 5, 0, 
36, 0, 0, 0, 177, 0, 0, 0, 171, 0, 0, 0, 39, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 178, 0, 0, 0, 177, 0, 0, 0, 62, 0, 3, 0, 176, 0, 0, 0, 178, 0, 0, 0, 253, 0, 1, 0, 56, 0, 1, 0, 54, 0, 5, 0, 8, 0, 0, 0, 13, 0, 0, 0, 
0, 0, 0, 0, 11, 0, 0, 0, 55, 0, 3, 0, 10, 0, 0, 0, 12, 0, 0, 0, 248, 0, 2, 0, 14, 0, 0, 0, 61, 0, 4, 0, 18, 0, 0, 0, 21, 0, 0, 0, 20, 0, 0, 0, 61, 0, 4, 0, 22, 0, 0, 0, 25, 0, 0, 0, 24, 0, 0, 0, 86, 0, 5, 0, 
26, 0, 0, 0, 27, 0, 0, 0, 21, 0, 0, 0, 25, 0, 0, 0, 65, 0, 5, 0, 30, 0, 0, 0, 31, 0, 0, 0, 12, 0, 0, 0, 29, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 32, 0, 0, 0, 31, 0, 0, 0, 87, 0, 5, 0, 8, 0, 0, 0, 33, 0, 0, 0, 
27, 0, 0, 0, 32, 0, 0, 0, 254, 0, 2, 0, 33, 0, 0, 0, 56, 0, 1, 0, 54, 0, 5, 0, 8, 0, 0, 0, 16, 0, 0, 0, 0, 0, 0, 0, 11, 0, 0, 0, 55, 0, 3, 0, 10, 0, 0, 0, 15, 0, 0, 0, 248, 0, 2, 0, 17, 0, 0, 0, 59, 0, 4, 0, 
36, 0, 0, 0, 37, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 36, 0, 0, 0, 38, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 51, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 57, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 
40, 0, 0, 0, 70, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 40, 0, 0, 0, 77, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 40, 0, 0, 0, 85, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 36, 0, 0, 0, 116, 0, 0, 0, 7, 0, 0, 0, 65, 0, 5, 0, 
40, 0, 0, 0, 41, 0, 0, 0, 15, 0, 0, 0, 39, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 42, 0, 0, 0, 41, 0, 0, 0, 131, 0, 5, 0, 6, 0, 0, 0, 44, 0, 0, 0, 42, 0, 0, 0, 43, 0, 0, 0, 12, 0, 6, 0, 6, 0, 0, 0, 45, 0, 0, 0, 
1, 0, 0, 0, 4, 0, 0, 0, 44, 0, 0, 0, 188, 0, 5, 0, 47, 0, 0, 0, 48, 0, 0, 0, 45, 0, 0, 0, 46, 0, 0, 0, 247, 0, 3, 0, 50, 0, 0, 0, 0, 0, 0, 0, 250, 0, 4, 0, 48, 0, 0, 0, 49, 0, 0, 0, 56, 0, 0, 0, 248, 0, 2, 0, 
49, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 52, 0, 0, 0, 15, 0, 0, 0, 62, 0, 3, 0, 51, 0, 0, 0, 52, 0, 0, 0, 57, 0, 5, 0, 8, 0, 0, 0, 53, 0, 0, 0, 13, 0, 0, 0, 51, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 54, 0, 0, 0, 
51, 0, 0, 0, 62, 0, 3, 0, 15, 0, 0, 0, 54, 0, 0, 0, 79, 0, 9, 0, 8, 0, 0, 0, 55, 0, 0, 0, 53, 0, 0, 0, 53, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 62, 0, 3, 0, 38, 0, 0, 0, 55, 0, 0, 0, 
249, 0, 2, 0, 50, 0, 0, 0, 248, 0, 2, 0, 56, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 58, 0, 0, 0, 15, 0, 0, 0, 62, 0, 3, 0, 57, 0, 0, 0, 58, 0, 0, 0, 57, 0, 5, 0, 8, 0, 0, 0, 59, 0, 0, 0, 13, 0, 0, 0, 57, 0, 0, 0, 
61, 0, 4, 0, 9, 0, 0, 0, 60, 0, 0, 0, 57, 0, 0, 0, 62, 0, 3, 0, 15, 0, 0, 0, 60, 0, 0, 0, 62, 0, 3, 0, 38, 0, 0, 0, 59, 0, 0, 0, 249, 0, 2, 0, 50, 0, 0, 0, 248, 0, 2, 0, 50, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 
61, 0, 0, 0, 38, 0, 0, 0, 62, 0, 3, 0, 37, 0, 0, 0, 61, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 62, 0, 0, 0, 15, 0, 0, 0, 39, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 63, 0, 0, 0, 62, 0, 0, 0, 131, 0, 5, 0, 6, 0, 0, 0, 
65, 0, 0, 0, 63, 0, 0, 0, 64, 0, 0, 0, 12, 0, 6, 0, 6, 0, 0, 0, 66, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 65, 0, 0, 0, 188, 0, 5, 0, 47, 0, 0, 0, 67, 0, 0, 0, 66, 0, 0, 0, 46, 0, 0, 0, 247, 0, 3, 0, 69, 0, 0, 0, 
0, 0, 0, 0, 250, 0, 4, 0, 67, 0, 0, 0, 68, 0, 0, 0, 69, 0, 0, 0, 248, 0, 2, 0, 68, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 73, 0, 0, 0, 37, 0, 0, 0, 72, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 74, 0, 0, 0, 73, 0, 0, 0, 
133, 0, 5, 0, 6, 0, 0, 0, 75, 0, 0, 0, 74, 0, 0, 0, 64, 0, 0, 0, 131, 0, 5, 0, 6, 0, 0, 0, 76, 0, 0, 0, 75, 0, 0, 0, 43, 0, 0, 0, 62, 0, 3, 0, 70, 0, 0, 0, 76, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 79, 0, 0, 0, 
37, 0, 0, 0, 78, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 80, 0, 0, 0, 79, 0, 0, 0, 133, 0, 5, 0, 6, 0, 0, 0, 81, 0, 0, 0, 80, 0, 0, 0, 64, 0, 0, 0, 131, 0, 5, 0, 6, 0, 0, 0, 82, 0, 0, 0, 81, 0, 0, 0, 43, 0, 0, 0, 
62, 0, 3, 0, 77, 0, 0, 0, 82, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 84, 0, 0, 0, 37, 0, 0, 0, 83, 0, 0, 0, 62, 0, 3, 0, 84, 0, 0, 0, 43, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 86, 0, 0, 0, 70, 0, 0, 0, 61, 0, 4, 0, 
6, 0, 0, 0, 87, 0, 0, 0, 70, 0, 0, 0, 133, 0, 5, 0, 6, 0, 0, 0, 88, 0, 0, 0, 86, 0, 0, 0, 87, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 89, 0, 0, 0, 77, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 90, 0, 0, 0, 77, 0, 0, 0, 
133, 0, 5, 0, 6, 0, 0, 0, 91, 0, 0, 0, 89, 0, 0, 0, 90, 0, 0, 0, 129, 0, 5, 0, 6, 0, 0, 0, 92, 0, 0, 0, 88, 0, 0, 0, 91, 0, 0, 0, 12, 0, 8, 0, 6, 0, 0, 0, 94, 0, 0, 0, 1, 0, 0, 0, 43, 0, 0, 0, 92, 0, 0, 0, 
93, 0, 0, 0, 43, 0, 0, 0, 12, 0, 6, 0, 6, 0, 0, 0, 95, 0, 0, 0, 1, 0, 0, 0, 31, 0, 0, 0, 94, 0, 0, 0, 131, 0, 5, 0, 6, 0, 0, 0, 96, 0, 0, 0, 43, 0, 0, 0, 95, 0, 0, 0, 62, 0, 3, 0, 85, 0, 0, 0, 96, 0, 0, 0, 
61, 0, 4, 0, 6, 0, 0, 0, 97, 0, 0, 0, 85, 0, 0, 0, 133, 0, 5, 0, 6, 0, 0, 0, 99, 0, 0, 0, 97, 0, 0, 0, 98, 0, 0, 0, 129, 0, 5, 0, 6, 0, 0, 0, 100, 0, 0, 0, 99, 0, 0, 0, 98, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 
102, 0, 0, 0, 37, 0, 0, 0, 101, 0, 0, 0, 62, 0, 3, 0, 102, 0, 0, 0, 100, 0, 0, 0, 249, 0, 2, 0, 69, 0, 0, 0, 248, 0, 2, 0, 69, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 103, 0, 0, 0, 15, 0, 0, 0, 39, 0, 0, 0, 61, 0, 4, 0, 
6, 0, 0, 0, 104, 0, 0, 0, 103, 0, 0, 0, 131, 0, 5, 0, 6, 0, 0, 0, 106, 0, 0, 0, 104, 0, 0, 0, 105, 0, 0, 0, 12, 0, 6, 0, 6, 0, 0, 0, 107, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 106, 0, 0, 0, 188, 0, 5, 0, 47, 0, 0, 0, 
108, 0, 0, 0, 107, 0, 0, 0, 46, 0, 0, 0, 247, 0, 3, 0, 110, 0, 0, 0, 0, 0, 0, 0, 250, 0, 4, 0, 108, 0, 0, 0, 109, 0, 0, 0, 110, 0, 0, 0, 248, 0, 2, 0, 109, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 111, 0, 0, 0, 37, 0, 0, 0, 
79, 0, 7, 0, 7, 0, 0, 0, 112, 0, 0, 0, 111, 0, 0, 0, 111, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 113, 0, 0, 0, 37, 0, 0, 0, 79, 0, 9, 0, 8, 0, 0, 0, 114, 0, 0, 0, 113, 0, 0, 0, 112, 0, 0, 0, 
0, 0, 0, 0, 4, 0, 0, 0, 5, 0, 0, 0, 3, 0, 0, 0, 62, 0, 3, 0, 37, 0, 0, 0, 114, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 115, 0, 0, 0, 37, 0, 0, 0, 83, 0, 0, 0, 62, 0, 3, 0, 115, 0, 0, 0, 43, 0, 0, 0, 249, 0, 2, 0, 
110, 0, 0, 0, 248, 0, 2, 0, 110, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 117, 0, 0, 0, 37, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 119, 0, 0, 0, 15, 0, 0, 0, 118, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 120, 0, 0, 0, 119, 0, 0, 0, 
133, 0, 5, 0, 8, 0, 0, 0, 121, 0, 0, 0, 117, 0, 0, 0, 120, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 123, 0, 0, 0, 15, 0, 0, 0, 122, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 124, 0, 0, 0, 123, 0, 0, 0, 129, 0, 5, 0, 8, 0, 0, 0, 
125, 0, 0, 0, 121, 0, 0, 0, 124, 0, 0, 0, 62, 0, 3, 0, 116, 0, 0, 0, 125, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 126, 0, 0, 0, 116, 0, 0, 0, 254, 0, 2, 0, 126, 0, 0, 0, 56, 0, 1, 0, 
        };
    }
}
#endif
