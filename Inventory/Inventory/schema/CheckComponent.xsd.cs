namespace Inventory {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Inventory.CheckComponent",@"Component")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Category", XPath = @"/*[local-name()='Component' and namespace-uri()='http://Inventory.CheckComponent']/*[local-name()='Category' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Option", XPath = @"/*[local-name()='Component' and namespace-uri()='http://Inventory.CheckComponent']/*[local-name()='Option' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Identifier", XPath = @"/*[local-name()='Component' and namespace-uri()='http://Inventory.CheckComponent']/*[local-name()='Identifier' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Inventory.schema.Identifier), XPath = @"/*[local-name()='Component' and namespace-uri()='http://Inventory.CheckComponent']/*[local-name()='Identifier' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Component"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inventory.schema.CheckComponentPropertySchema", typeof(global::Inventory.schema.CheckComponentPropertySchema))]
    public sealed class CheckComponent : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Inventory.CheckComponent"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Inventory.ComponentPropertySchema"" targetNamespace=""http://Inventory.CheckComponent"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Inventory.ComponentPropertySchema"" location=""Inventory.schema.CheckComponentPropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Component"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Component' and namespace-uri()='http://Inventory.CheckComponent']/*[local-name()='Category' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Component' and namespace-uri()='http://Inventory.CheckComponent']/*[local-name()='Option' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Component' and namespace-uri()='http://Inventory.CheckComponent']/*[local-name()='Identifier' and namespace-uri()='']"" />
          <b:property name=""ns0:Identifier"" xpath=""/*[local-name()='Component' and namespace-uri()='http://Inventory.CheckComponent']/*[local-name()='Identifier' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Identifier"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:properties>
                <b:property distinguished=""true"" xpath=""/*[local-name()='Identifier' and namespace-uri()='http://Inventory.CheckComponent']"" />
                <b:property name=""ns0:Property1"" xpath=""/*[local-name()='Identifier' and namespace-uri()='http://Inventory.CheckComponent']"" />
              </b:properties>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""Category"" type=""xs:string"" />
        <xs:element name=""Option"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CheckComponent() {
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
