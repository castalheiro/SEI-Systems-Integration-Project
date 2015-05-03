namespace Production {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Production.RequestComponent",@"Component")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Category", XPath = @"/*[local-name()='Component' and namespace-uri()='http://Production.RequestComponent']/*[local-name()='Category' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Option", XPath = @"/*[local-name()='Component' and namespace-uri()='http://Production.RequestComponent']/*[local-name()='Option' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Component"})]
    public sealed class RequestComponent : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Production.RequestComponent"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Production.RequestComponent"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Component"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Component' and namespace-uri()='http://Production.RequestComponent']/*[local-name()='Category' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Component' and namespace-uri()='http://Production.RequestComponent']/*[local-name()='Option' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Category"" type=""xs:string"" />
        <xs:element name=""Option"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RequestComponent() {
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
