namespace Production {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Production.AssembleComputer",@"AssembleComputer")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "OrderNumber", XPath = @"/*[local-name()='AssembleComputer' and namespace-uri()='http://Production.AssembleComputer']/*[local-name()='OrderNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Production.schema.OrderNumber), XPath = @"/*[local-name()='AssembleComputer' and namespace-uri()='http://Production.AssembleComputer']/*[local-name()='OrderNumber' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AssembleComputer"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Production.schema.PropertySchema", typeof(global::Production.schema.PropertySchema))]
    public sealed class AssembleComputer : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Production.AssembleComputer"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Production.PropertySchema"" targetNamespace=""http://Production.AssembleComputer"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Production.PropertySchema"" location=""Production.schema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AssembleComputer"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='AssembleComputer' and namespace-uri()='http://Production.AssembleComputer']/*[local-name()='OrderNumber' and namespace-uri()='']"" />
          <b:property name=""ns0:OrderNumber"" xpath=""/*[local-name()='AssembleComputer' and namespace-uri()='http://Production.AssembleComputer']/*[local-name()='OrderNumber' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderNumber"" type=""xs:string"" />
        <xs:element name=""ComponentsList"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""4"" maxOccurs=""4"" name=""Component"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Category"" type=""xs:string"" />
                    <xs:element name=""Option"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AssembleComputer() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AssembleComputer";
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
