// Copyright (c) homuler & The Vignette Authors. Licensed under the MIT license.
// See the LICENSE file in the repository root for more details.

using System;
using System.Collections.Generic;
using Akihabara.Framework.Port;
using Akihabara.Framework.Protobuf;
using Akihabara.Native;

namespace Akihabara.Framework.Packet
{
    public class LandmarkListVectorPacket : Packet<List<LandmarkList>>
    {
        public LandmarkListVectorPacket() : base() { }
        public LandmarkListVectorPacket(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner) { }

        public override List<LandmarkList> Get()
        {
            UnsafeNativeMethods.mp_Packet__GetLandmarkListVector(MpPtr, out var serializedProtoVectorPtr).Assert();
            GC.KeepAlive(this);

            var landmarkLists = External.Protobuf.DeserializeProtoVector<LandmarkList>(serializedProtoVectorPtr, LandmarkList.Parser);
            UnsafeNativeMethods.mp_api_SerializedProtoVector__delete(serializedProtoVectorPtr);

            return landmarkLists;
        }

        public override StatusOr<List<LandmarkList>> Consume()
        {
            throw new NotSupportedException();
        }

        public override Status ValidateAsType()
        {
            throw new NotSupportedException();
        }
    }
}
