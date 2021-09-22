// Copyright (c) homuler & The Vignette Authors. Licensed under the MIT license.
// See the LICENSE file in the repository root for more details.

using System;
using System.Runtime.InteropServices;

namespace Akihabara.Native.Gpu
{
    public partial class UnsafeNativeMethods : NativeMethods
    {
        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_GpuBuffer__PSgtb(IntPtr glTextureBuffer, out IntPtr gpuBuffer);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern void mp_GpuBuffer__delete(IntPtr gpuBuffer);

        #region StatusOr

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern void mp_StatusOrGpuBuffer__delete(IntPtr statusOrGpuBuffer);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_StatusOrGpuBuffer__status(IntPtr statusOrGpuBuffer, out IntPtr status);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_StatusOrGpuBuffer__value(IntPtr statusOrGpuBuffer, out IntPtr gpuBuffer);

        #endregion

        #region Packet

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp__MakeGpuBufferPacket__Rgb(IntPtr gpuBuffer, out IntPtr packet);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp__MakeGpuBufferPacket_At__Rgb_Rts(IntPtr gpuBuffer, IntPtr timestamp,
            out IntPtr packet);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_Packet__ConsumeGpuBuffer(IntPtr packet, out IntPtr statusOrGpuBuffer);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_Packet__GetGpuBuffer(IntPtr packet, out IntPtr gpuBuffer);

        [DllImport(MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_Packet__ValidateAsGpuBuffer(IntPtr packet, out IntPtr status);

        #endregion
    }
}
