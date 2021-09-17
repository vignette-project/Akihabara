﻿using Akihabara.Framework.Port;
using Akihabara.Framework.Protobuf;
using Akihabara.Native;
using System;

namespace Akihabara.Framework.Packet
{
    public class LandmarkListPacket : Packet<LandmarkList>
    {
        public LandmarkListPacket() : base() { }
        public LandmarkListPacket(IntPtr ptr, bool isOwner = true) : base(ptr, isOwner) { }

        public override LandmarkList Get()
        {
            UnsafeNativeMethods.mp_Packet__GetLandmarkList(MpPtr, out var serializedProtoPtr).Assert();
            GC.KeepAlive(this);

            var landmarkList = External.Protobuf.DeserializeProto<LandmarkList>(serializedProtoPtr, LandmarkList.Parser);
            UnsafeNativeMethods.mp_api_SerializedProto__delete(serializedProtoPtr);

            return landmarkList;
        }

        public override StatusOr<LandmarkList> Consume()
        {
            throw new NotSupportedException();
        }

        public override Status ValidateAsType()
        {
            throw new NotSupportedException();
        }
    }
}
