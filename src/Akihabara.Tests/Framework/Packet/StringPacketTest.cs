// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

using Akihabara.Core;
using Akihabara.Framework;
using Akihabara.Framework.Packet;
using Akihabara.Framework.Port;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace Akihabara.Tests.Framework.Packet
{
    [TestFixture]
    public class StringPacketTest
    {
        #region Constructor
        [Test, SignalAbort]
        public void Ctor_ShouldInstantiatePacket_When_CalledWithNoArguments()
        {
            var packet = new StringPacket();

            Assert.AreEqual(packet.ValidateAsType().Code, Status.StatusCode.Internal);
            Assert.Throws<MediapipeException>(() => { packet.Get(); });
            Assert.AreEqual(packet.Timestamp(), Timestamp.Unset());
        }

        [Test]
        public void Ctor_ShouldInstantiatePacket_When_CalledWithString()
        {
            var packet = new StringPacket("test");

            Assert.True(packet.ValidateAsType().ok);
            Assert.AreEqual(packet.Get(), "test");
            Assert.AreEqual(packet.Timestamp(), Timestamp.Unset());
        }

        [Test]
        public void Ctor_ShouldInstantiatePacket_When_CalledWithByteArray()
        {
            byte[] bytes = new byte[] { (byte)'t', (byte)'e', (byte)'s', (byte)'t' };
            var packet = new StringPacket(bytes);

            Assert.True(packet.ValidateAsType().ok);
            Assert.AreEqual(packet.Get(), "test");
            Assert.AreEqual(packet.Timestamp(), Timestamp.Unset());
        }

        [Test]
        public void Ctor_ShouldInstantiatePacket_When_CalledWithStringAndTimestamp()
        {
            var timestamp = new Timestamp(1);
            var packet = new StringPacket("test", timestamp);

            Assert.True(packet.ValidateAsType().ok);
            Assert.AreEqual(packet.Get(), "test");
            Assert.AreEqual(packet.Timestamp(), timestamp);
        }

        [Test]
        public void Ctor_ShouldInstantiatePacket_When_CalledWithByteArrayAndTimestamp()
        {
            var timestamp = new Timestamp(1);
            byte[] bytes = new byte[] { (byte)'t', (byte)'e', (byte)'s', (byte)'t' };
            var packet = new StringPacket(bytes, timestamp);

            Assert.True(packet.ValidateAsType().ok);
            Assert.AreEqual(packet.Get(), "test");
            Assert.AreEqual(packet.Timestamp(), timestamp);
        }
        #endregion

        #region #isDisposed
        [Test]
        public void IsDisposed_ShouldReturnFalse_When_NotDisposedYet()
        {
            var packet = new StringPacket();

            Assert.False(packet.IsDisposed);
        }

        [Test]
        public void IsDisposed_ShouldReturnTrue_When_AlreadyDisposed()
        {
            var packet = new StringPacket();
            packet.Dispose();

            Assert.True(packet.IsDisposed);
        }
        #endregion

        #region #GetByteArray
        [Test]
        public void GetByteArray_ShouldReturnByteArray()
        {
            byte[] bytes = new byte[] { (byte)'a', (byte)'b', 0, (byte)'c' };
            var packet = new StringPacket(bytes);

            Assert.AreEqual(packet.GetByteArray(), bytes);
            Assert.AreEqual(packet.Get(), "ab");
        }
        #endregion

        #region #Consume
        [Test]
        public void Consume_ShouldThrowNotSupportedException()
        {
            var packet = new StringPacket();

            Assert.Throws<NotSupportedException>(() => { packet.Consume(); });
        }
        #endregion

        #region #DebugTypeName
        [Test]
        public void DebugTypeName_ShouldReturnString_When_ValueIsSet()
        {
            var packet = new StringPacket("test");
            var regex = new Regex("string");

            Assert.True(regex.IsMatch(packet.DebugTypeName()));
        }
        #endregion
    }
}
