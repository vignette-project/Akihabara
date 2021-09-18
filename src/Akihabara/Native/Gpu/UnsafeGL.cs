// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using System;
using System.Runtime.InteropServices;

namespace Akihabara.Native.Gpu
{
    public partial class UnsafeNativeMethods : NativeMethods
    {
        [DllImport(MediaPipeLibrary)]
        public static extern void glFlush();

        [DllImport(MediaPipeLibrary)]
        public static extern void glReadPixels(int x, int y, int width, int height, UInt32 glFormat, UInt32 glType,
            IntPtr pixels);
    }
}
