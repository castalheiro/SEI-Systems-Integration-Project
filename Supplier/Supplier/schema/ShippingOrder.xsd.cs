namespace Supplier {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Supplier.ShippingOrder",@"ShippingOrder")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PurchaseNumber", XPath = @"/*[local-name()='ShippingOrder' and namespace-uri()='http://Supplier.ShippingOrder']/*[local-name()='PurchaseNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Supplier.PurchaseNumber), XPath = @"/*[local-name()='ShippingOrder' and namespace-uri()='http://Supplier.ShippingOrder']/*[local-name()='PurchaseNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DeliveryAddress", XPath = @"/*[local-name()='ShippingOrder' and namespace-uri()='http://Supplier.ShippingOrder']/*[local-name()='DeliveryAddress' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ShippingOrder"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Supplier.Properties", typeof(global::Supplier.Properties))]
    public sealed class ShippingOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Supplier.ShippingOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Supplier.Properties"" targetNamespace=""http://Supplier.ShippingOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Supplier.Properties"" location=""Supplier.Properties"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ShippingOrder"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ShippingOrder' and namespace-uri()='http://Supplier.ShippingOrder']/*[local-name()='PurchaseNumber' and namespace-uri()='']"" />
          <b:property name=""ns0:PurchaseNumber"" xpath=""/*[local-name()='ShippingOrder' and namespace-uri()='http://Supplier.ShippingOrder']/*[local-name()='PurchaseNumber' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ShippingOrder' and namespace-uri()='http://Supplier.ShippingOrder']/*[local-name()='DeliveryAddress' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PurchaseNumber"" type=""xs:string"" />
        <xs:element name=""DeliveryAddress"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ShippingOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ShippingOrder";
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
