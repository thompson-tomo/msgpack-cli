﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8670
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeWithoutAnyAttributeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> {
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> this_PackValueOfDataDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer1;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> this_PackValueOfHistoryDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer2;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> this_PackValueOfSourceDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer3;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> this_PackValueOfTimeStampDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, byte[]> this_SetUnpackedValueOfDataDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, byte[]> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int> this_UnpackValueOfDataDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Collections.Generic.Dictionary<System.DateTime, string>> this_SetUnpackedValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int> this_UnpackValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Uri> this_SetUnpackedValueOfSourceDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int> this_UnpackValueOfSourceDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.DateTime> this_SetUnpackedValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int> this_UnpackValueOfTimeStampDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeWithoutAnyAttributeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<byte[]>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<System.Uri>(schema2);
            this._serializer3 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>[4];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfData);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfHistory);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfSource);
            packOperationList[3] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfTimeStamp);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>>(4);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfData);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfHistory);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfSource);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfTimeStamp);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>[4];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfData);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfHistory);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfSource);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>>(4);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfData);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfHistory);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfSource);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Data",
                    "History",
                    "Source",
                    "TimeStamp"};
            this.this_PackValueOfDataDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfData);
            this.this_PackValueOfHistoryDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfHistory);
            this.this_PackValueOfSourceDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfSource);
            this.this_PackValueOfTimeStampDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfTimeStamp);
            this.this_SetUnpackedValueOfDataDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, byte[]>(this.SetUnpackedValueOfData);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, byte[]>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue);
            this.this_UnpackValueOfDataDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfData);
            this.this_SetUnpackedValueOfHistoryDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Collections.Generic.Dictionary<System.DateTime, string>>(this.SetUnpackedValueOfHistory);
            this.this_UnpackValueOfHistoryDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfHistory);
            this.this_SetUnpackedValueOfSourceDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.Uri>(this.SetUnpackedValueOfSource);
            this.this_UnpackValueOfSourceDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfSource);
            this.this_SetUnpackedValueOfTimeStampDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, System.DateTime>(this.SetUnpackedValueOfTimeStamp);
            this.this_UnpackValueOfTimeStampDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int, int>(this.UnpackValueOfTimeStamp);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer0.PackTo(packer, objectTree.Data);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer1.PackTo(packer, objectTree.History);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer2.PackTo(packer, objectTree.Source);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer3.PackTo(packer, objectTree.TimeStamp);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfData(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, byte[] unpackedValue) {
            unpackingContext.Data = unpackedValue;
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(byte[]), "Data", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate, this.this_SetUnpackedValueOfDataDelegate);
        }
        
        private void SetUnpackedValueOfHistory(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, System.Collections.Generic.Dictionary<System.DateTime, string> unpackedValue) {
            System.Collections.Generic.Dictionary<System.DateTime, string> existent = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
            existent = unpackingContext.History;
            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(System.Collections.Generic.Dictionary<System.DateTime, string>), "History", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfHistoryDelegate);
        }
        
        private void SetUnpackedValueOfSource(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, System.Uri unpackedValue) {
            unpackingContext.Source = unpackedValue;
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer2, itemsCount, indexOfItem, typeof(System.Uri), "Source", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfSourceDelegate);
        }
        
        private void SetUnpackedValueOfTimeStamp(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.TimeStamp = unpackedValue;
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer3, itemsCount, indexOfItem, typeof(System.DateTime), "TimeStamp", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTimeStampDelegate);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithoutAnyAttribute UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithoutAnyAttribute result = default(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute);
            result = new MsgPack.Serialization.ComplexTypeWithoutAnyAttribute();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(), this._unpackOperationTable);
            }
        }
    }
}