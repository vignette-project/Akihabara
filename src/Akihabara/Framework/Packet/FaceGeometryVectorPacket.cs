// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using Akihabara.Framework.Port;
using Akihabara.Framework.Protobuf.FaceGeometry;
using Akihabara.Native;
using System;
using System.Collections.Generic;

namespace Akihabara.Framework.Packet
{
    public class FaceGeometryVectorPacket : Packet<List<FaceGeometry>>
    {
        public FaceGeometryVectorPacket() : base() { }
        public FaceGeometryVectorPacket(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner) { }

        public override List<FaceGeometry> Get()
        {
            UnsafeNativeMethods.mp_Packet__GetFaceGeometryVector(MpPtr, out var serializedProtoVectorPtr).Assert();
            GC.KeepAlive(this);

            var geometries = External.Protobuf.DeserializeProtoVector<FaceGeometry>(serializedProtoVectorPtr, FaceGeometry.Parser);
            UnsafeNativeMethods.mp_api_SerializedProtoVector__delete(serializedProtoVectorPtr);

            return geometries;
        }

        public override StatusOr<List<FaceGeometry>> Consume()
        {
            throw new NotSupportedException();
        }

        public override Status ValidateAsType()
        {
            throw new NotSupportedException();
        }
    }
}
