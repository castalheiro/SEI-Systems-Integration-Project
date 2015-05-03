namespace E_Commerce {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://E_Commerce.OrderConfirmation",@"OrderConfirmation")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "OrderNumber", XPath = @"/*[local-name()='OrderConfirmation' and namespace-uri()='http://E_Commerce.OrderConfirmation']/*[local-name()='OrderNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CustomerName", XPath = @"/*[local-name()='OrderConfirmation' and namespace-uri()='http://E_Commerce.OrderConfirmation']/*[local-name()='CustomerName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Address", XPath = @"/*[local-name()='OrderConfirmation' and namespace-uri()='http://E_Commerce.OrderConfirmation']/*[local-name()='Address' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Double), "Price", XPath = @"/*[local-name()='OrderConfirmation' and namespace-uri()='http://E_Commerce.OrderConfirmation']/*[local-name()='Price' and namespace-uri()='']", XsdType = @"double")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderConfirmation"})]
    public sealed class OrderConfirmation : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://E_Commerce.OrderConfirmation"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://E_Commerce.OrderConfirmation"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""OrderConfirmation"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='OrderConfirmation' and namespace-uri()='http://E_Commerce.OrderConfirmation']/*[local-name()='OrderNumber' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='OrderConfirmation' and namespace-uri()='http://E_Commerce.OrderConfirmation']/*[local-name()='CustomerName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='OrderConfirmation' and namespace-uri()='http://E_Commerce.OrderConfirmation']/*[local-name()='Address' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='OrderConfirmation' and namespace-uri()='http://E_Commerce.OrderConfirmation']/*[local-name()='Price' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderNumber"" type=""xs:string"" />
        <xs:element name=""CustomerName"" type=""xs:string"" />
        <xs:element name=""Address"" type=""xs:string"" />
        <xs:element name=""Price"" type=""xs:double"" />
        <xs:element name=""ComponentsList"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Component"">
                <xs:complexType>
                  <xs:sequence minOccurs=""4"" maxOccurs=""4"">
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
        
        public OrderConfirmation() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrderConfirmation";
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
