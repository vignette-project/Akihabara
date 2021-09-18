// Copyright 2021 (c) homuler and The Vignette Authors
// Licensed under MIT
// See LICENSE for details

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protofiles/framework/calculator_contract_test.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Akihabara.Framework.Protobuf
{

    /// <summary>Holder for reflection information generated from protofiles/framework/calculator_contract_test.proto</summary>
    public static partial class CalculatorContractTestReflection
    {

        #region Descriptor
        /// <summary>File descriptor for protofiles/framework/calculator_contract_test.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static CalculatorContractTestReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "CjNwcm90b2ZpbGVzL2ZyYW1ld29yay9jYWxjdWxhdG9yX2NvbnRyYWN0X3Rl",
                  "c3QucHJvdG8SHGFraWhhYmFyYS5mcmFtZXdvcmsucHJvdG9idWYaJXByb3Rv",
                  "ZmlsZXMvZnJhbWV3b3JrL2NhbGN1bGF0b3IucHJvdG8itQEKHUNhbGN1bGF0",
                  "b3JDb250cmFjdFRlc3RPcHRpb25zEhYKCnRlc3RfZmllbGQYASABKAE6Ai0x",
                  "MnwKA2V4dBIvLmFraWhhYmFyYS5mcmFtZXdvcmsucHJvdG9idWYuQ2FsY3Vs",
                  "YXRvck9wdGlvbnMYt9WAWiABKAsyOy5ha2loYWJhcmEuZnJhbWV3b3JrLnBy",
                  "b3RvYnVmLkNhbGN1bGF0b3JDb250cmFjdFRlc3RPcHRpb25z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::Akihabara.Framework.Protobuf.CalculatorReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Akihabara.Framework.Protobuf.CalculatorContractTestOptions), global::Akihabara.Framework.Protobuf.CalculatorContractTestOptions.Parser, new[]{ "TestField" }, null, null, new pb::Extension[] { global::Akihabara.Framework.Protobuf.CalculatorContractTestOptions.Extensions.Ext }, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class CalculatorContractTestOptions : pb::IMessage<CalculatorContractTestOptions>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<CalculatorContractTestOptions> _parser = new pb::MessageParser<CalculatorContractTestOptions>(() => new CalculatorContractTestOptions());
        private pb::UnknownFieldSet _unknownFields;
        private int _hasBits0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<CalculatorContractTestOptions> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Akihabara.Framework.Protobuf.CalculatorContractTestReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CalculatorContractTestOptions()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CalculatorContractTestOptions(CalculatorContractTestOptions other) : this()
        {
            _hasBits0 = other._hasBits0;
            testField_ = other.testField_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CalculatorContractTestOptions Clone()
        {
            return new CalculatorContractTestOptions(this);
        }

        /// <summary>Field number for the "test_field" field.</summary>
        public const int TestFieldFieldNumber = 1;
        private readonly static double TestFieldDefaultValue = -1D;

        private double testField_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public double TestField
        {
            get { if ((_hasBits0 & 1) != 0) { return testField_; } else { return TestFieldDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                testField_ = value;
            }
        }
        /// <summary>Gets whether the "test_field" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasTestField
        {
            get { return (_hasBits0 & 1) != 0; }
        }
        /// <summary>Clears the value of the "test_field" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearTestField()
        {
            _hasBits0 &= ~1;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other)
        {
            return Equals(other as CalculatorContractTestOptions);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(CalculatorContractTestOptions other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TestField, other.TestField)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode()
        {
            int hash = 1;
            if (HasTestField) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TestField);
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
      if (HasTestField) {
        output.WriteRawTag(9);
        output.WriteDouble(TestField);
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
            if (HasTestField)
            {
                output.WriteRawTag(9);
                output.WriteDouble(TestField);
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
            if (HasTestField)
            {
                size += 1 + 8;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(CalculatorContractTestOptions other)
        {
            if (other == null)
            {
                return;
            }
            if (other.HasTestField)
            {
                TestField = other.TestField;
            }
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
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            TestField = input.ReadDouble();
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
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 9:
                        {
                            TestField = input.ReadDouble();
                            break;
                        }
                }
            }
        }
#endif

        #region Extensions
        /// <summary>Container for extensions for other messages declared in the CalculatorContractTestOptions message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Extensions
        {
            public static readonly pb::Extension<global::Akihabara.Framework.Protobuf.CalculatorOptions, global::Akihabara.Framework.Protobuf.CalculatorContractTestOptions> Ext =
              new pb::Extension<global::Akihabara.Framework.Protobuf.CalculatorOptions, global::Akihabara.Framework.Protobuf.CalculatorContractTestOptions>(188754615, pb::FieldCodec.ForMessage(1510036922, global::Akihabara.Framework.Protobuf.CalculatorContractTestOptions.Parser));
        }
        #endregion

    }

    #endregion

}

#endregion Designer generated code
