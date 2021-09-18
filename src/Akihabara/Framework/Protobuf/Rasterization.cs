// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/framework/formats/annotation/rasterization.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Akihabara.Framework.Protobuf {

  /// <summary>Holder for reflection information generated from mediapipe/framework/formats/annotation/rasterization.proto</summary>
  public static partial class RasterizationReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/framework/formats/annotation/rasterization.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RasterizationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjptZWRpYXBpcGUvZnJhbWV3b3JrL2Zvcm1hdHMvYW5ub3RhdGlvbi9yYXN0",
            "ZXJpemF0aW9uLnByb3RvEhxha2loYWJhcmEuZnJhbWV3b3JrLnByb3RvYnVm",
            "Io8BCg1SYXN0ZXJpemF0aW9uEkYKCGludGVydmFsGAEgAygLMjQuYWtpaGFi",
            "YXJhLmZyYW1ld29yay5wcm90b2J1Zi5SYXN0ZXJpemF0aW9uLkludGVydmFs",
            "GjYKCEludGVydmFsEgkKAXkYASACKAUSDgoGbGVmdF94GAIgAigFEg8KB3Jp",
            "Z2h0X3gYAyACKAVCQwotY29tLmdvb2dsZS5tZWRpYXBpcGUuZm9ybWF0cy5h",
            "bm5vdGF0aW9uLnByb3RvQhJSYXN0ZXJpemF0aW9uUHJvdG8="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.Rasterization), global::Akihabara.Framework.Protobuf.Rasterization.Parser, new[]{ "Interval" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.Rasterization.Types.Interval), global::Akihabara.Framework.Protobuf.Rasterization.Types.Interval.Parser, new[]{ "Y", "LeftX", "RightX" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Region can be represented in each frame as a set of scanlines
  /// (compressed RLE, similar to rasterization of polygons).
  /// For each scanline with y-coordinate y, we save (possibly multiple) intervals
  /// of occupied pixels represented as a pair [left_x, right_x].
  /// </summary>
  public sealed partial class Rasterization : pb::IMessage<Rasterization> {
    private static readonly pb::MessageParser<Rasterization> _parser = new pb::MessageParser<Rasterization>(() => new Rasterization());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Rasterization> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akihabara.Framework.Protobuf.RasterizationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rasterization() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rasterization(Rasterization other) : this() {
      interval_ = other.interval_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rasterization Clone() {
      return new Rasterization(this);
    }

    /// <summary>Field number for the "interval" field.</summary>
    public const int IntervalFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Akihabara.Framework.Protobuf.Rasterization.Types.Interval> _repeated_interval_codec
        = pb::FieldCodec.ForMessage(10, global::Akihabara.Framework.Protobuf.Rasterization.Types.Interval.Parser);
    private readonly pbc::RepeatedField<global::Akihabara.Framework.Protobuf.Rasterization.Types.Interval> interval_ = new pbc::RepeatedField<global::Akihabara.Framework.Protobuf.Rasterization.Types.Interval>();
    /// <summary>
    /// Intervals are always sorted by y-coordinate.
    /// Therefore, a region occupies a set of scanlines ranging
    /// from interval(0).y() to interval(interval_size() - 1)).y().
    /// Note: In video, at some scanlines no interval might be present.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Akihabara.Framework.Protobuf.Rasterization.Types.Interval> Interval {
      get { return interval_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Rasterization);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Rasterization other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!interval_.Equals(other.interval_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= interval_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      interval_.WriteTo(output, _repeated_interval_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += interval_.CalculateSize(_repeated_interval_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Rasterization other) {
      if (other == null) {
        return;
      }
      interval_.Add(other.interval_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            interval_.AddEntriesFrom(input, _repeated_interval_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Rasterization message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Interval : pb::IMessage<Interval> {
        private static readonly pb::MessageParser<Interval> _parser = new pb::MessageParser<Interval>(() => new Interval());
        private pb::UnknownFieldSet _unknownFields;
        private int _hasBits0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Interval> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Akihabara.Framework.Protobuf.Rasterization.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Interval() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Interval(Interval other) : this() {
          _hasBits0 = other._hasBits0;
          y_ = other.y_;
          leftX_ = other.leftX_;
          rightX_ = other.rightX_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Interval Clone() {
          return new Interval(this);
        }

        /// <summary>Field number for the "y" field.</summary>
        public const int YFieldNumber = 1;
        private readonly static int YDefaultValue = 0;

        private int y_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Y {
          get { if ((_hasBits0 & 1) != 0) { return y_; } else { return YDefaultValue; } }
          set {
            _hasBits0 |= 1;
            y_ = value;
          }
        }
        /// <summary>Gets whether the "y" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool HasY {
          get { return (_hasBits0 & 1) != 0; }
        }
        /// <summary>Clears the value of the "y" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearY() {
          _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "left_x" field.</summary>
        public const int LeftXFieldNumber = 2;
        private readonly static int LeftXDefaultValue = 0;

        private int leftX_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int LeftX {
          get { if ((_hasBits0 & 2) != 0) { return leftX_; } else { return LeftXDefaultValue; } }
          set {
            _hasBits0 |= 2;
            leftX_ = value;
          }
        }
        /// <summary>Gets whether the "left_x" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool HasLeftX {
          get { return (_hasBits0 & 2) != 0; }
        }
        /// <summary>Clears the value of the "left_x" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearLeftX() {
          _hasBits0 &= ~2;
        }

        /// <summary>Field number for the "right_x" field.</summary>
        public const int RightXFieldNumber = 3;
        private readonly static int RightXDefaultValue = 0;

        private int rightX_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int RightX {
          get { if ((_hasBits0 & 4) != 0) { return rightX_; } else { return RightXDefaultValue; } }
          set {
            _hasBits0 |= 4;
            rightX_ = value;
          }
        }
        /// <summary>Gets whether the "right_x" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool HasRightX {
          get { return (_hasBits0 & 4) != 0; }
        }
        /// <summary>Clears the value of the "right_x" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearRightX() {
          _hasBits0 &= ~4;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Interval);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Interval other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Y != other.Y) return false;
          if (LeftX != other.LeftX) return false;
          if (RightX != other.RightX) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (HasY) hash ^= Y.GetHashCode();
          if (HasLeftX) hash ^= LeftX.GetHashCode();
          if (HasRightX) hash ^= RightX.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (HasY) {
            output.WriteRawTag(8);
            output.WriteInt32(Y);
          }
          if (HasLeftX) {
            output.WriteRawTag(16);
            output.WriteInt32(LeftX);
          }
          if (HasRightX) {
            output.WriteRawTag(24);
            output.WriteInt32(RightX);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (HasY) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Y);
          }
          if (HasLeftX) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(LeftX);
          }
          if (HasRightX) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(RightX);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Interval other) {
          if (other == null) {
            return;
          }
          if (other.HasY) {
            Y = other.Y;
          }
          if (other.HasLeftX) {
            LeftX = other.LeftX;
          }
          if (other.HasRightX) {
            RightX = other.RightX;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                Y = input.ReadInt32();
                break;
              }
              case 16: {
                LeftX = input.ReadInt32();
                break;
              }
              case 24: {
                RightX = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
