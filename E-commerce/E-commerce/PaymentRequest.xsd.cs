namespace E_commerce {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://E_commerce.PaymentRequest",@"PaymentRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CreditCard", XPath = @"/*[local-name()='PaymentRequest' and namespace-uri()='http://E_commerce.PaymentRequest']/*[local-name()='CreditCard' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CustomerName", XPath = @"/*[local-name()='PaymentRequest' and namespace-uri()='http://E_commerce.PaymentRequest']/*[local-name()='CustomerName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Amount", XPath = @"/*[local-name()='PaymentRequest' and namespace-uri()='http://E_commerce.PaymentRequest']/*[local-name()='Amount' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PaymentRequest"})]
    public sealed class PaymentRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://E_commerce.PaymentRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://E_commerce.PaymentRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PaymentRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PaymentRequest' and namespace-uri()='http://E_commerce.PaymentRequest']/*[local-name()='CreditCard' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PaymentRequest' and namespace-uri()='http://E_commerce.PaymentRequest']/*[local-name()='CustomerName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PaymentRequest' and namespace-uri()='http://E_commerce.PaymentRequest']/*[local-name()='Amount' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CreditCard"" type=""xs:string"" />
        <xs:element name=""CustomerName"" type=""xs:string"" />
        <xs:element name=""Amount"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PaymentRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PaymentRequest";
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
