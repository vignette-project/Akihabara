// Copyright (c) homuler & The Vignette Authors. Licensed under the MIT license.
// See the LICENSE file in the repository root for more details.

using System;
using Akihabara.Framework.Port;
using Akihabara.Framework.Protobuf;
using Akihabara.Native;

namespace Akihabara.Framework.Packet
{
    public class RectPacket : Packet<Rect>
    {
        public RectPacket() : base() { }
        public RectPacket(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner) { }

        public override Rect Get()
        {
            UnsafeNativeMethods.mp_Packet__GetRect(MpPtr, out var serializedProtoPtr).Assert();
            GC.KeepAlive(this);

            var rect = External.Protobuf.DeserializeProto<Rect>(serializedProtoPtr, Rect.Parser);
            UnsafeNativeMethods.mp_api_SerializedProto__delete(serializedProtoPtr);

            return rect;
        }

        public override StatusOr<Rect> Consume()
        {
            throw new NotSupportedException();
        }

        public override Status ValidateAsType()
        {
            throw new NotSupportedException();
        }
    }
}
