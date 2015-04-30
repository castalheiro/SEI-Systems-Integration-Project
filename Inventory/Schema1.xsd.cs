namespace Inventory {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Inventory.Schema1",@"Component")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Component"})]
    public sealed class Schema1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Inventory.Schema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Inventory.Schema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Component"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Record"">
          <xs:complexType>
            <xs:attribute name=""Category"" type=""xs:string"" />
            <xs:attribute name=""Option"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""PurchaseNumber"" type=""xs:string"" />
      <xs:attribute name=""Quantity"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Schema1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Component";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}