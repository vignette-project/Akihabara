// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: calculator_options.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Akihabara.Framework.ProtoCalculator
{

    /// <summary>Holder for reflection information generated from calculator_options.proto</summary>
    public static partial class CalculatorOptionsReflection
    {

        #region Descriptor
        /// <summary>File descriptor for calculator_options.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static CalculatorOptionsReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "ChhjYWxjdWxhdG9yX29wdGlvbnMucHJvdG8SJGFraWhhYmFyYS5mcmFtZXdv",
                  "cmsucHJvdG9fY2FsY3VsYXRvciI5ChFDYWxjdWxhdG9yT3B0aW9ucxIYCgxt",
                  "ZXJnZV9maWVsZHMYASABKAhCAhgBKgoIoJwBEICAgIAC"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.ProtoCalculator.CalculatorOptions), global::Akihabara.Framework.ProtoCalculator.CalculatorOptions.Parser, new[]{ "MergeFields" }, null, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// Options for Calculators. Each Calculator implementation should
    /// have its own options proto, which should look like this:
    ///
    /// message MyCalculatorOptions {
    ///   extend CalculatorOptions {
    ///     optional MyCalculatorOptions ext = &lt;unique id, e.g. the CL#>;
    ///   }
    ///   optional string field_needed_by_my_calculator = 1;
    ///   optional int32 another_field = 2;
    ///   // etc
    /// }
    /// </summary>
    public sealed partial class CalculatorOptions : pb::IExtendableMessage<CalculatorOptions>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<CalculatorOptions> _parser = new pb::MessageParser<CalculatorOptions>(() => new CalculatorOptions());
        private pb::UnknownFieldSet _unknownFields;
        private pb::ExtensionSet<CalculatorOptions> _extensions;
        private pb::ExtensionSet<CalculatorOptions> _Extensions { get { return _extensions; } }
        private int _hasBits0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<CalculatorOptions> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Akihabara.Framework.ProtoCalculator.CalculatorOptionsReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CalculatorOptions()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CalculatorOptions(CalculatorOptions other) : this()
        {
            _hasBits0 = other._hasBits0;
            mergeFields_ = other.mergeFields_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            _extensions = pb::ExtensionSet.Clone(other._extensions);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CalculatorOptions Clone()
        {
            return new CalculatorOptions(this);
        }

        /// <summary>Field number for the "merge_fields" field.</summary>
        public const int MergeFieldsFieldNumber = 1;
        private readonly static bool MergeFieldsDefaultValue = false;

        private bool mergeFields_;
        /// <summary>
        /// If true, this proto specifies a subset of field values,
        /// which should override corresponding field values.
        /// </summary>
        [global::System.ObsoleteAttribute]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool MergeFields
        {
            get { if ((_hasBits0 & 1) != 0) { return mergeFields_; } else { return MergeFieldsDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                mergeFields_ = value;
            }
        }
        /// <summary>Gets whether the "merge_fields" field is set</summary>
        [global::System.ObsoleteAttribute]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasMergeFields
        {
            get { return (_hasBits0 & 1) != 0; }
        }
        /// <summary>Clears the value of the "merge_fields" field</summary>
        [global::System.ObsoleteAttribute]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearMergeFields()
        {
            _hasBits0 &= ~1;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other)
        {
            return Equals(other as CalculatorOptions);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(CalculatorOptions other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (MergeFields != other.MergeFields) return false;
            if (!Equals(_extensions, other._extensions))
            {
                return false;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode()
        {
            int hash = 1;
            if (HasMergeFields) hash ^= MergeFields.GetHashCode();
            if (_extensions != null)
            {
                hash ^= _extensions.GetHashCode();
            }
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (HasMergeFields) {
        output.WriteRawTag(8);
        output.WriteBool(MergeFields);
      }
      if (_extensions != null) {
        _extensions.WriteTo(output);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (HasMergeFields)
            {
                output.WriteRawTag(8);
                output.WriteBool(MergeFields);
            }
            if (_extensions != null)
            {
                _extensions.WriteTo(ref output);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize()
        {
            int size = 0;
            if (HasMergeFields)
            {
                size += 1 + 1;
            }
            if (_extensions != null)
            {
                size += _extensions.CalculateSize();
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(CalculatorOptions other)
        {
            if (other == null)
            {
                return;
            }
            if (other.HasMergeFields)
            {
                MergeFields = other.MergeFields;
            }
            pb::ExtensionSet.MergeFrom(ref _extensions, other._extensions);
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (!pb::ExtensionSet.TryMergeFieldFrom(ref _extensions, input)) {
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            }
            break;
          case 8: {
            MergeFields = input.ReadBool();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        if (!pb::ExtensionSet.TryMergeFieldFrom(ref _extensions, ref input))
                        {
                            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        }
                        break;
                    case 8:
                        {
                            MergeFields = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

        public TValue GetExtension<TValue>(pb::Extension<CalculatorOptions, TValue> extension)
        {
            return pb::ExtensionSet.Get(ref _extensions, extension);
        }
        public pbc::RepeatedField<TValue> GetExtension<TValue>(pb::RepeatedExtension<CalculatorOptions, TValue> extension)
        {
            return pb::ExtensionSet.Get(ref _extensions, extension);
        }
        public pbc::RepeatedField<TValue> GetOrInitializeExtension<TValue>(pb::RepeatedExtension<CalculatorOptions, TValue> extension)
        {
            return pb::ExtensionSet.GetOrInitialize(ref _extensions, extension);
        }
        public void SetExtension<TValue>(pb::Extension<CalculatorOptions, TValue> extension, TValue value)
        {
            pb::ExtensionSet.Set(ref _extensions, extension, value);
        }
        public bool HasExtension<TValue>(pb::Extension<CalculatorOptions, TValue> extension)
        {
            return pb::ExtensionSet.Has(ref _extensions, extension);
        }
        public void ClearExtension<TValue>(pb::Extension<CalculatorOptions, TValue> extension)
        {
            pb::ExtensionSet.Clear(ref _extensions, extension);
        }
        public void ClearExtension<TValue>(pb::RepeatedExtension<CalculatorOptions, TValue> extension)
        {
            pb::ExtensionSet.Clear(ref _extensions, extension);
        }

    }

    #endregion

}

#endregion Designer generated code
