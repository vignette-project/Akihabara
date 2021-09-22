// Copyright (c) homuler & The Vignette Authors. Licensed under the MIT license.
// See the LICENSE file in the repository root for more details.

using System;
using Akihabara.Framework.Port;
using Akihabara.Framework.Protobuf.FaceGeometry;
using Akihabara.Native;

namespace Akihabara.Framework.Packet
{
    public class FaceGeometryPacket : Packet<FaceGeometry>
    {
        public FaceGeometryPacket() : base() { }
        public FaceGeometryPacket(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner) { }

        public override FaceGeometry Get()
        {
            UnsafeNativeMethods.mp_Packet__GetFaceGeometry(MpPtr, out var serializedProtoPtr).Assert();
            GC.KeepAlive(this);

            var geometry = External.Protobuf.DeserializeProto<FaceGeometry>(serializedProtoPtr, FaceGeometry.Parser);
            UnsafeNativeMethods.mp_api_SerializedProto__delete(serializedProtoPtr);

            return geometry;
        }

        public override StatusOr<FaceGeometry> Consume()
        {
            throw new NotSupportedException();
        }

        public override Status ValidateAsType()
        {
            throw new NotSupportedException();
        }
    }
}
