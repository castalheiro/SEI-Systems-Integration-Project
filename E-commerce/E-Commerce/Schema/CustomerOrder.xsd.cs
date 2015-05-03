namespace E_Commerce {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://E_Commerce.CustomerOrder",@"CustomerOrder")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "OrderNumber", XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='OrderNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CustomerName", XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='CustomerName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Address", XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='Address' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CreditCard", XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='CreditCard' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Double), "Price", XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='Price' and namespace-uri()='']", XsdType = @"double")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerOrder"})]
    public sealed class CustomerOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://E_Commerce.CustomerOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://E_Commerce.CustomerOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerOrder"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='OrderNumber' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='CustomerName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='Address' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='CreditCard' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://E_Commerce.CustomerOrder']/*[local-name()='Price' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderNumber"" type=""xs:string"" />
        <xs:element name=""CustomerName"" type=""xs:string"" />
        <xs:element name=""Address"" type=""xs:string"" />
        <xs:element name=""CreditCard"" type=""xs:string"" />
        <xs:element name=""Price"" type=""xs:double"" />
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
        
        public CustomerOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerOrder";
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
