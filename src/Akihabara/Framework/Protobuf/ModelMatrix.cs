// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/graphs/object_detection_3d/calculators/model_matrix.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Akihabara.Framework.Protobuf {

  /// <summary>Holder for reflection information generated from mediapipe/graphs/object_detection_3d/calculators/model_matrix.proto</summary>
  public static partial class ModelMatrixReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/graphs/object_detection_3d/calculators/model_matrix.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModelMatrixReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNtZWRpYXBpcGUvZ3JhcGhzL29iamVjdF9kZXRlY3Rpb25fM2QvY2FsY3Vs",
            "YXRvcnMvbW9kZWxfbWF0cml4LnByb3RvEhxha2loYWJhcmEuZnJhbWV3b3Jr",
            "LnByb3RvYnVmIlkKFVRpbWVkTW9kZWxNYXRyaXhQcm90bxIaCg5tYXRyaXhf",
            "ZW50cmllcxgBIAMoAkICEAESFAoJdGltZV9tc2VjGAIgASgDOgEwEg4KAmlk",
            "GAMgASgFOgItMSJmChlUaW1lZE1vZGVsTWF0cml4UHJvdG9MaXN0EkkKDG1v",
            "ZGVsX21hdHJpeBgBIAMoCzIzLmFraWhhYmFyYS5mcmFtZXdvcmsucHJvdG9i",
            "dWYuVGltZWRNb2RlbE1hdHJpeFByb3RvIlQKEFRpbWVkVmVjdG9yUHJvdG8S",
            "GgoOdmVjdG9yX2VudHJpZXMYASADKAJCAhABEhQKCXRpbWVfbXNlYxgCIAEo",
            "AzoBMBIOCgJpZBgDIAEoBToCLTEiWwoUVGltZWRWZWN0b3JQcm90b0xpc3QS",
            "QwoLdmVjdG9yX2xpc3QYASADKAsyLi5ha2loYWJhcmEuZnJhbWV3b3JrLnBy",
            "b3RvYnVmLlRpbWVkVmVjdG9yUHJvdG8="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.TimedModelMatrixProto), global::Akihabara.Framework.Protobuf.TimedModelMatrixProto.Parser, new[]{ "MatrixEntries", "TimeMsec", "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.TimedModelMatrixProtoList), global::Akihabara.Framework.Protobuf.TimedModelMatrixProtoList.Parser, new[]{ "ModelMatrix" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.TimedVectorProto), global::Akihabara.Framework.Protobuf.TimedVectorProto.Parser, new[]{ "VectorEntries", "TimeMsec", "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.TimedVectorProtoList), global::Akihabara.Framework.Protobuf.TimedVectorProtoList.Parser, new[]{ "VectorList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TimedModelMatrixProto : pb::IMessage<TimedModelMatrixProto> {
    private static readonly pb::MessageParser<TimedModelMatrixProto> _parser = new pb::MessageParser<TimedModelMatrixProto>(() => new TimedModelMatrixProto());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimedModelMatrixProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akihabara.Framework.Protobuf.ModelMatrixReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedModelMatrixProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedModelMatrixProto(TimedModelMatrixProto other) : this() {
      _hasBits0 = other._hasBits0;
      matrixEntries_ = other.matrixEntries_.Clone();
      timeMsec_ = other.timeMsec_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedModelMatrixProto Clone() {
      return new TimedModelMatrixProto(this);
    }

    /// <summary>Field number for the "matrix_entries" field.</summary>
    public const int MatrixEntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<float> _repeated_matrixEntries_codec
        = pb::FieldCodec.ForFloat(10);
    private readonly pbc::RepeatedField<float> matrixEntries_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// 4x4 model matrix stored in ROW major order.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> MatrixEntries {
      get { return matrixEntries_; }
    }

    /// <summary>Field number for the "time_msec" field.</summary>
    public const int TimeMsecFieldNumber = 2;
    private readonly static long TimeMsecDefaultValue = 0L;

    private long timeMsec_;
    /// <summary>
    /// Timestamp of this model matrix in milliseconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TimeMsec {
      get { if ((_hasBits0 & 1) != 0) { return timeMsec_; } else { return TimeMsecDefaultValue; } }
      set {
        _hasBits0 |= 1;
        timeMsec_ = value;
      }
    }
    /// <summary>Gets whether the "time_msec" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasTimeMsec {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "time_msec" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTimeMsec() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private readonly static int IdDefaultValue = -1;

    private int id_;
    /// <summary>
    /// Unique per object id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { if ((_hasBits0 & 2) != 0) { return id_; } else { return IdDefaultValue; } }
      set {
        _hasBits0 |= 2;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimedModelMatrixProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimedModelMatrixProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!matrixEntries_.Equals(other.matrixEntries_)) return false;
      if (TimeMsec != other.TimeMsec) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= matrixEntries_.GetHashCode();
      if (HasTimeMsec) hash ^= TimeMsec.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
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
      matrixEntries_.WriteTo(output, _repeated_matrixEntries_codec);
      if (HasTimeMsec) {
        output.WriteRawTag(16);
        output.WriteInt64(TimeMsec);
      }
      if (HasId) {
        output.WriteRawTag(24);
        output.WriteInt32(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += matrixEntries_.CalculateSize(_repeated_matrixEntries_codec);
      if (HasTimeMsec) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimeMsec);
      }
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimedModelMatrixProto other) {
      if (other == null) {
        return;
      }
      matrixEntries_.Add(other.matrixEntries_);
      if (other.HasTimeMsec) {
        TimeMsec = other.TimeMsec;
      }
      if (other.HasId) {
        Id = other.Id;
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
          case 10:
          case 13: {
            matrixEntries_.AddEntriesFrom(input, _repeated_matrixEntries_codec);
            break;
          }
          case 16: {
            TimeMsec = input.ReadInt64();
            break;
          }
          case 24: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TimedModelMatrixProtoList : pb::IMessage<TimedModelMatrixProtoList> {
    private static readonly pb::MessageParser<TimedModelMatrixProtoList> _parser = new pb::MessageParser<TimedModelMatrixProtoList>(() => new TimedModelMatrixProtoList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimedModelMatrixProtoList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akihabara.Framework.Protobuf.ModelMatrixReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedModelMatrixProtoList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedModelMatrixProtoList(TimedModelMatrixProtoList other) : this() {
      modelMatrix_ = other.modelMatrix_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedModelMatrixProtoList Clone() {
      return new TimedModelMatrixProtoList(this);
    }

    /// <summary>Field number for the "model_matrix" field.</summary>
    public const int ModelMatrixFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Akihabara.Framework.Protobuf.TimedModelMatrixProto> _repeated_modelMatrix_codec
        = pb::FieldCodec.ForMessage(10, global::Akihabara.Framework.Protobuf.TimedModelMatrixProto.Parser);
    private readonly pbc::RepeatedField<global::Akihabara.Framework.Protobuf.TimedModelMatrixProto> modelMatrix_ = new pbc::RepeatedField<global::Akihabara.Framework.Protobuf.TimedModelMatrixProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Akihabara.Framework.Protobuf.TimedModelMatrixProto> ModelMatrix {
      get { return modelMatrix_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimedModelMatrixProtoList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimedModelMatrixProtoList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!modelMatrix_.Equals(other.modelMatrix_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= modelMatrix_.GetHashCode();
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
      modelMatrix_.WriteTo(output, _repeated_modelMatrix_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += modelMatrix_.CalculateSize(_repeated_modelMatrix_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimedModelMatrixProtoList other) {
      if (other == null) {
        return;
      }
      modelMatrix_.Add(other.modelMatrix_);
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
            modelMatrix_.AddEntriesFrom(input, _repeated_modelMatrix_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// For convenience, when the desired information or transformation can be
  /// encoded into vectors (e.g. when the matrix represents a scale or Euler-angle-
  /// based rotation operation.)
  /// </summary>
  public sealed partial class TimedVectorProto : pb::IMessage<TimedVectorProto> {
    private static readonly pb::MessageParser<TimedVectorProto> _parser = new pb::MessageParser<TimedVectorProto>(() => new TimedVectorProto());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimedVectorProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akihabara.Framework.Protobuf.ModelMatrixReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedVectorProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedVectorProto(TimedVectorProto other) : this() {
      _hasBits0 = other._hasBits0;
      vectorEntries_ = other.vectorEntries_.Clone();
      timeMsec_ = other.timeMsec_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedVectorProto Clone() {
      return new TimedVectorProto(this);
    }

    /// <summary>Field number for the "vector_entries" field.</summary>
    public const int VectorEntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<float> _repeated_vectorEntries_codec
        = pb::FieldCodec.ForFloat(10);
    private readonly pbc::RepeatedField<float> vectorEntries_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// The vector values themselves.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> VectorEntries {
      get { return vectorEntries_; }
    }

    /// <summary>Field number for the "time_msec" field.</summary>
    public const int TimeMsecFieldNumber = 2;
    private readonly static long TimeMsecDefaultValue = 0L;

    private long timeMsec_;
    /// <summary>
    /// Timestamp of this vector in milliseconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TimeMsec {
      get { if ((_hasBits0 & 1) != 0) { return timeMsec_; } else { return TimeMsecDefaultValue; } }
      set {
        _hasBits0 |= 1;
        timeMsec_ = value;
      }
    }
    /// <summary>Gets whether the "time_msec" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasTimeMsec {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "time_msec" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTimeMsec() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private readonly static int IdDefaultValue = -1;

    private int id_;
    /// <summary>
    /// Unique per object id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { if ((_hasBits0 & 2) != 0) { return id_; } else { return IdDefaultValue; } }
      set {
        _hasBits0 |= 2;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimedVectorProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimedVectorProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!vectorEntries_.Equals(other.vectorEntries_)) return false;
      if (TimeMsec != other.TimeMsec) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= vectorEntries_.GetHashCode();
      if (HasTimeMsec) hash ^= TimeMsec.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
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
      vectorEntries_.WriteTo(output, _repeated_vectorEntries_codec);
      if (HasTimeMsec) {
        output.WriteRawTag(16);
        output.WriteInt64(TimeMsec);
      }
      if (HasId) {
        output.WriteRawTag(24);
        output.WriteInt32(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += vectorEntries_.CalculateSize(_repeated_vectorEntries_codec);
      if (HasTimeMsec) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimeMsec);
      }
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimedVectorProto other) {
      if (other == null) {
        return;
      }
      vectorEntries_.Add(other.vectorEntries_);
      if (other.HasTimeMsec) {
        TimeMsec = other.TimeMsec;
      }
      if (other.HasId) {
        Id = other.Id;
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
          case 10:
          case 13: {
            vectorEntries_.AddEntriesFrom(input, _repeated_vectorEntries_codec);
            break;
          }
          case 16: {
            TimeMsec = input.ReadInt64();
            break;
          }
          case 24: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TimedVectorProtoList : pb::IMessage<TimedVectorProtoList> {
    private static readonly pb::MessageParser<TimedVectorProtoList> _parser = new pb::MessageParser<TimedVectorProtoList>(() => new TimedVectorProtoList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimedVectorProtoList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akihabara.Framework.Protobuf.ModelMatrixReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedVectorProtoList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedVectorProtoList(TimedVectorProtoList other) : this() {
      vectorList_ = other.vectorList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimedVectorProtoList Clone() {
      return new TimedVectorProtoList(this);
    }

    /// <summary>Field number for the "vector_list" field.</summary>
    public const int VectorListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Akihabara.Framework.Protobuf.TimedVectorProto> _repeated_vectorList_codec
        = pb::FieldCodec.ForMessage(10, global::Akihabara.Framework.Protobuf.TimedVectorProto.Parser);
    private readonly pbc::RepeatedField<global::Akihabara.Framework.Protobuf.TimedVectorProto> vectorList_ = new pbc::RepeatedField<global::Akihabara.Framework.Protobuf.TimedVectorProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Akihabara.Framework.Protobuf.TimedVectorProto> VectorList {
      get { return vectorList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimedVectorProtoList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimedVectorProtoList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!vectorList_.Equals(other.vectorList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= vectorList_.GetHashCode();
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
      vectorList_.WriteTo(output, _repeated_vectorList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += vectorList_.CalculateSize(_repeated_vectorList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimedVectorProtoList other) {
      if (other == null) {
        return;
      }
      vectorList_.Add(other.vectorList_);
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
            vectorList_.AddEntriesFrom(input, _repeated_vectorList_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
