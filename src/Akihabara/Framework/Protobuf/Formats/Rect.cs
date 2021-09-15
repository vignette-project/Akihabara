// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protofiles/framework/formats/rect.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Akihabara.Framework.Protobuf {

  /// <summary>Holder for reflection information generated from protofiles/framework/formats/rect.proto</summary>
  public static partial class RectReflection {

    #region Descriptor
    /// <summary>File descriptor for protofiles/framework/formats/rect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidwcm90b2ZpbGVzL2ZyYW1ld29yay9mb3JtYXRzL3JlY3QucHJvdG8SHGFr",
            "aWhhYmFyYS5mcmFtZXdvcmsucHJvdG9idWYibwoEUmVjdBIQCgh4X2NlbnRl",
            "chgBIAIoBRIQCgh5X2NlbnRlchgCIAIoBRIOCgZoZWlnaHQYAyACKAUSDQoF",
            "d2lkdGgYBCACKAUSEwoIcm90YXRpb24YBSABKAI6ATASDwoHcmVjdF9pZBgG",
            "IAEoAyJ5Cg5Ob3JtYWxpemVkUmVjdBIQCgh4X2NlbnRlchgBIAIoAhIQCgh5",
            "X2NlbnRlchgCIAIoAhIOCgZoZWlnaHQYAyACKAISDQoFd2lkdGgYBCACKAIS",
            "EwoIcm90YXRpb24YBSABKAI6ATASDwoHcmVjdF9pZBgGIAEoAw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.Rect), global::Akihabara.Framework.Protobuf.Rect.Parser, new[]{ "XCenter", "YCenter", "Height", "Width", "Rotation", "RectId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.NormalizedRect), global::Akihabara.Framework.Protobuf.NormalizedRect.Parser, new[]{ "XCenter", "YCenter", "Height", "Width", "Rotation", "RectId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A rectangle with rotation in image coordinates.
  /// </summary>
  public sealed partial class Rect : pb::IMessage<Rect>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Rect> _parser = new pb::MessageParser<Rect>(() => new Rect());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Rect> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akihabara.Framework.Protobuf.RectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Rect() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Rect(Rect other) : this() {
      _hasBits0 = other._hasBits0;
      xCenter_ = other.xCenter_;
      yCenter_ = other.yCenter_;
      height_ = other.height_;
      width_ = other.width_;
      rotation_ = other.rotation_;
      rectId_ = other.rectId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Rect Clone() {
      return new Rect(this);
    }

    /// <summary>Field number for the "x_center" field.</summary>
    public const int XCenterFieldNumber = 1;
    private readonly static int XCenterDefaultValue = 0;

    private int xCenter_;
    /// <summary>
    /// Location of the center of the rectangle in image coordinates.
    /// The (0, 0) point is at the (top, left) corner.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int XCenter {
      get { if ((_hasBits0 & 1) != 0) { return xCenter_; } else { return XCenterDefaultValue; } }
      set {
        _hasBits0 |= 1;
        xCenter_ = value;
      }
    }
    /// <summary>Gets whether the "x_center" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasXCenter {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "x_center" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearXCenter() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "y_center" field.</summary>
    public const int YCenterFieldNumber = 2;
    private readonly static int YCenterDefaultValue = 0;

    private int yCenter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int YCenter {
      get { if ((_hasBits0 & 2) != 0) { return yCenter_; } else { return YCenterDefaultValue; } }
      set {
        _hasBits0 |= 2;
        yCenter_ = value;
      }
    }
    /// <summary>Gets whether the "y_center" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasYCenter {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "y_center" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearYCenter() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 3;
    private readonly static int HeightDefaultValue = 0;

    private int height_;
    /// <summary>
    /// Size of the rectangle.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Height {
      get { if ((_hasBits0 & 4) != 0) { return height_; } else { return HeightDefaultValue; } }
      set {
        _hasBits0 |= 4;
        height_ = value;
      }
    }
    /// <summary>Gets whether the "height" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHeight {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "height" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHeight() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 4;
    private readonly static int WidthDefaultValue = 0;

    private int width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Width {
      get { if ((_hasBits0 & 8) != 0) { return width_; } else { return WidthDefaultValue; } }
      set {
        _hasBits0 |= 8;
        width_ = value;
      }
    }
    /// <summary>Gets whether the "width" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasWidth {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "width" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearWidth() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 5;
    private readonly static float RotationDefaultValue = 0F;

    private float rotation_;
    /// <summary>
    /// Rotation angle is clockwise in radians.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Rotation {
      get { if ((_hasBits0 & 16) != 0) { return rotation_; } else { return RotationDefaultValue; } }
      set {
        _hasBits0 |= 16;
        rotation_ = value;
      }
    }
    /// <summary>Gets whether the "rotation" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRotation {
      get { return (_hasBits0 & 16) != 0; }
    }
    /// <summary>Clears the value of the "rotation" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRotation() {
      _hasBits0 &= ~16;
    }

    /// <summary>Field number for the "rect_id" field.</summary>
    public const int RectIdFieldNumber = 6;
    private readonly static long RectIdDefaultValue = 0L;

    private long rectId_;
    /// <summary>
    /// Optional unique id to help associate different Rects to each other.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RectId {
      get { if ((_hasBits0 & 32) != 0) { return rectId_; } else { return RectIdDefaultValue; } }
      set {
        _hasBits0 |= 32;
        rectId_ = value;
      }
    }
    /// <summary>Gets whether the "rect_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRectId {
      get { return (_hasBits0 & 32) != 0; }
    }
    /// <summary>Clears the value of the "rect_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRectId() {
      _hasBits0 &= ~32;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Rect);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Rect other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (XCenter != other.XCenter) return false;
      if (YCenter != other.YCenter) return false;
      if (Height != other.Height) return false;
      if (Width != other.Width) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Rotation, other.Rotation)) return false;
      if (RectId != other.RectId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasXCenter) hash ^= XCenter.GetHashCode();
      if (HasYCenter) hash ^= YCenter.GetHashCode();
      if (HasHeight) hash ^= Height.GetHashCode();
      if (HasWidth) hash ^= Width.GetHashCode();
      if (HasRotation) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Rotation);
      if (HasRectId) hash ^= RectId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasXCenter) {
        output.WriteRawTag(8);
        output.WriteInt32(XCenter);
      }
      if (HasYCenter) {
        output.WriteRawTag(16);
        output.WriteInt32(YCenter);
      }
      if (HasHeight) {
        output.WriteRawTag(24);
        output.WriteInt32(Height);
      }
      if (HasWidth) {
        output.WriteRawTag(32);
        output.WriteInt32(Width);
      }
      if (HasRotation) {
        output.WriteRawTag(45);
        output.WriteFloat(Rotation);
      }
      if (HasRectId) {
        output.WriteRawTag(48);
        output.WriteInt64(RectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasXCenter) {
        output.WriteRawTag(8);
        output.WriteInt32(XCenter);
      }
      if (HasYCenter) {
        output.WriteRawTag(16);
        output.WriteInt32(YCenter);
      }
      if (HasHeight) {
        output.WriteRawTag(24);
        output.WriteInt32(Height);
      }
      if (HasWidth) {
        output.WriteRawTag(32);
        output.WriteInt32(Width);
      }
      if (HasRotation) {
        output.WriteRawTag(45);
        output.WriteFloat(Rotation);
      }
      if (HasRectId) {
        output.WriteRawTag(48);
        output.WriteInt64(RectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasXCenter) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(XCenter);
      }
      if (HasYCenter) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(YCenter);
      }
      if (HasHeight) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (HasWidth) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (HasRotation) {
        size += 1 + 4;
      }
      if (HasRectId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RectId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Rect other) {
      if (other == null) {
        return;
      }
      if (other.HasXCenter) {
        XCenter = other.XCenter;
      }
      if (other.HasYCenter) {
        YCenter = other.YCenter;
      }
      if (other.HasHeight) {
        Height = other.Height;
      }
      if (other.HasWidth) {
        Width = other.Width;
      }
      if (other.HasRotation) {
        Rotation = other.Rotation;
      }
      if (other.HasRectId) {
        RectId = other.RectId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            XCenter = input.ReadInt32();
            break;
          }
          case 16: {
            YCenter = input.ReadInt32();
            break;
          }
          case 24: {
            Height = input.ReadInt32();
            break;
          }
          case 32: {
            Width = input.ReadInt32();
            break;
          }
          case 45: {
            Rotation = input.ReadFloat();
            break;
          }
          case 48: {
            RectId = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            XCenter = input.ReadInt32();
            break;
          }
          case 16: {
            YCenter = input.ReadInt32();
            break;
          }
          case 24: {
            Height = input.ReadInt32();
            break;
          }
          case 32: {
            Width = input.ReadInt32();
            break;
          }
          case 45: {
            Rotation = input.ReadFloat();
            break;
          }
          case 48: {
            RectId = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A rectangle with rotation in normalized coordinates. The values of box center
  /// location and size are within [0, 1].
  /// </summary>
  public sealed partial class NormalizedRect : pb::IMessage<NormalizedRect>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NormalizedRect> _parser = new pb::MessageParser<NormalizedRect>(() => new NormalizedRect());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NormalizedRect> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akihabara.Framework.Protobuf.RectReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NormalizedRect() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NormalizedRect(NormalizedRect other) : this() {
      _hasBits0 = other._hasBits0;
      xCenter_ = other.xCenter_;
      yCenter_ = other.yCenter_;
      height_ = other.height_;
      width_ = other.width_;
      rotation_ = other.rotation_;
      rectId_ = other.rectId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NormalizedRect Clone() {
      return new NormalizedRect(this);
    }

    /// <summary>Field number for the "x_center" field.</summary>
    public const int XCenterFieldNumber = 1;
    private readonly static float XCenterDefaultValue = 0F;

    private float xCenter_;
    /// <summary>
    /// Location of the center of the rectangle in image coordinates.
    /// The (0.0, 0.0) point is at the (top, left) corner.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float XCenter {
      get { if ((_hasBits0 & 1) != 0) { return xCenter_; } else { return XCenterDefaultValue; } }
      set {
        _hasBits0 |= 1;
        xCenter_ = value;
      }
    }
    /// <summary>Gets whether the "x_center" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasXCenter {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "x_center" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearXCenter() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "y_center" field.</summary>
    public const int YCenterFieldNumber = 2;
    private readonly static float YCenterDefaultValue = 0F;

    private float yCenter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float YCenter {
      get { if ((_hasBits0 & 2) != 0) { return yCenter_; } else { return YCenterDefaultValue; } }
      set {
        _hasBits0 |= 2;
        yCenter_ = value;
      }
    }
    /// <summary>Gets whether the "y_center" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasYCenter {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "y_center" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearYCenter() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 3;
    private readonly static float HeightDefaultValue = 0F;

    private float height_;
    /// <summary>
    /// Size of the rectangle.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Height {
      get { if ((_hasBits0 & 4) != 0) { return height_; } else { return HeightDefaultValue; } }
      set {
        _hasBits0 |= 4;
        height_ = value;
      }
    }
    /// <summary>Gets whether the "height" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHeight {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "height" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHeight() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 4;
    private readonly static float WidthDefaultValue = 0F;

    private float width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Width {
      get { if ((_hasBits0 & 8) != 0) { return width_; } else { return WidthDefaultValue; } }
      set {
        _hasBits0 |= 8;
        width_ = value;
      }
    }
    /// <summary>Gets whether the "width" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasWidth {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "width" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearWidth() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 5;
    private readonly static float RotationDefaultValue = 0F;

    private float rotation_;
    /// <summary>
    /// Rotation angle is clockwise in radians.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Rotation {
      get { if ((_hasBits0 & 16) != 0) { return rotation_; } else { return RotationDefaultValue; } }
      set {
        _hasBits0 |= 16;
        rotation_ = value;
      }
    }
    /// <summary>Gets whether the "rotation" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRotation {
      get { return (_hasBits0 & 16) != 0; }
    }
    /// <summary>Clears the value of the "rotation" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRotation() {
      _hasBits0 &= ~16;
    }

    /// <summary>Field number for the "rect_id" field.</summary>
    public const int RectIdFieldNumber = 6;
    private readonly static long RectIdDefaultValue = 0L;

    private long rectId_;
    /// <summary>
    /// Optional unique id to help associate different NormalizedRects to each
    /// other.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RectId {
      get { if ((_hasBits0 & 32) != 0) { return rectId_; } else { return RectIdDefaultValue; } }
      set {
        _hasBits0 |= 32;
        rectId_ = value;
      }
    }
    /// <summary>Gets whether the "rect_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRectId {
      get { return (_hasBits0 & 32) != 0; }
    }
    /// <summary>Clears the value of the "rect_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRectId() {
      _hasBits0 &= ~32;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NormalizedRect);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NormalizedRect other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(XCenter, other.XCenter)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(YCenter, other.YCenter)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Height, other.Height)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Width, other.Width)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Rotation, other.Rotation)) return false;
      if (RectId != other.RectId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasXCenter) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(XCenter);
      if (HasYCenter) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(YCenter);
      if (HasHeight) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Height);
      if (HasWidth) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Width);
      if (HasRotation) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Rotation);
      if (HasRectId) hash ^= RectId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasXCenter) {
        output.WriteRawTag(13);
        output.WriteFloat(XCenter);
      }
      if (HasYCenter) {
        output.WriteRawTag(21);
        output.WriteFloat(YCenter);
      }
      if (HasHeight) {
        output.WriteRawTag(29);
        output.WriteFloat(Height);
      }
      if (HasWidth) {
        output.WriteRawTag(37);
        output.WriteFloat(Width);
      }
      if (HasRotation) {
        output.WriteRawTag(45);
        output.WriteFloat(Rotation);
      }
      if (HasRectId) {
        output.WriteRawTag(48);
        output.WriteInt64(RectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasXCenter) {
        output.WriteRawTag(13);
        output.WriteFloat(XCenter);
      }
      if (HasYCenter) {
        output.WriteRawTag(21);
        output.WriteFloat(YCenter);
      }
      if (HasHeight) {
        output.WriteRawTag(29);
        output.WriteFloat(Height);
      }
      if (HasWidth) {
        output.WriteRawTag(37);
        output.WriteFloat(Width);
      }
      if (HasRotation) {
        output.WriteRawTag(45);
        output.WriteFloat(Rotation);
      }
      if (HasRectId) {
        output.WriteRawTag(48);
        output.WriteInt64(RectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasXCenter) {
        size += 1 + 4;
      }
      if (HasYCenter) {
        size += 1 + 4;
      }
      if (HasHeight) {
        size += 1 + 4;
      }
      if (HasWidth) {
        size += 1 + 4;
      }
      if (HasRotation) {
        size += 1 + 4;
      }
      if (HasRectId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RectId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NormalizedRect other) {
      if (other == null) {
        return;
      }
      if (other.HasXCenter) {
        XCenter = other.XCenter;
      }
      if (other.HasYCenter) {
        YCenter = other.YCenter;
      }
      if (other.HasHeight) {
        Height = other.Height;
      }
      if (other.HasWidth) {
        Width = other.Width;
      }
      if (other.HasRotation) {
        Rotation = other.Rotation;
      }
      if (other.HasRectId) {
        RectId = other.RectId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            XCenter = input.ReadFloat();
            break;
          }
          case 21: {
            YCenter = input.ReadFloat();
            break;
          }
          case 29: {
            Height = input.ReadFloat();
            break;
          }
          case 37: {
            Width = input.ReadFloat();
            break;
          }
          case 45: {
            Rotation = input.ReadFloat();
            break;
          }
          case 48: {
            RectId = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 13: {
            XCenter = input.ReadFloat();
            break;
          }
          case 21: {
            YCenter = input.ReadFloat();
            break;
          }
          case 29: {
            Height = input.ReadFloat();
            break;
          }
          case 37: {
            Width = input.ReadFloat();
            break;
          }
          case 45: {
            Rotation = input.ReadFloat();
            break;
          }
          case 48: {
            RectId = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code