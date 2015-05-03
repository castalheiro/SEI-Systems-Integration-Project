namespace Inventory {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "inventory.stock_quantity", XPath = @"/*[local-name()='OutStock' and namespace-uri()='http://CheckStockSQL']/*[local-name()='inventory' and namespace-uri()='http://CheckStockSQL']/@*[local-name()='stock_quantity' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InComponent", @"OutStock"})]
    public sealed class CheckStockSQLService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CheckStockSQL"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://CheckStockSQL"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [CheckStock] @category=&quot;Hard Disk&quot;, @option=&quot;128 GB&quot;"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""InComponent"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CheckStock"">
          <xs:complexType>
            <xs:attribute name=""category"" type=""xs:string"" />
            <xs:attribute name=""option"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OutStock"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='OutStock' and namespace-uri()='http://CheckStockSQL']/*[local-name()='inventory' and namespace-uri()='http://CheckStockSQL']/@*[local-name()='stock_quantity' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://InventorySQL"" minOccurs=""1"" name=""inventory"" type=""inventoryType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""inventoryType"">
    <xs:attribute name=""stock_quantity"" type=""xs:int"" />
  </xs:complexType>
</xs:schema>";
        
        public CheckStockSQLService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "InComponent";
                _RootElements[1] = "OutStock";
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
        
        [Schema(@"http://CheckStockSQL",@"InComponent")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InComponent"})]
        public sealed class InComponent : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InComponent() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InComponent";
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
        
        [Schema(@"http://CheckStockSQL",@"OutStock")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "inventory.stock_quantity", XPath = @"/*[local-name()='OutStock' and namespace-uri()='http://CheckStockSQL']/*[local-name()='inventory' and namespace-uri()='http://CheckStockSQL']/@*[local-name()='stock_quantity' and namespace-uri()='']", XsdType = @"int")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OutStock"})]
        public sealed class OutStock : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OutStock() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OutStock";
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
}
