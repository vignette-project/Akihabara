// Copyright (c) homuler & The Vignette Authors. Licensed under the MIT license.
// See the LICENSE file in the repository root for more details.

using System;
using System.Runtime.InteropServices;
using Akihabara.Gpu;

namespace Akihabara.Native.Gpu
{
    public partial class UnsafeNativeMethods : NativeMethods
    {
        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp__GlTextureInfoForGpuBufferFormat__ui_i_ui(
            GpuBufferFormat format, int plane, GlVersion glVersion, out IntPtr glTextureInfo);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern void mp_GlTextureInfo__delete(IntPtr glTextureInfo);
    }
}
