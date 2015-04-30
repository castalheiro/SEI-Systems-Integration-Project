namespace Supplier {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Supplier.OrderComponent", typeof(global::Supplier.OrderComponent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Supplier.ShippingOrder", typeof(global::Supplier.ShippingOrder))]
    public sealed class Transform_2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://Supplier.ShippingOrder"" xmlns:s0=""http://Supplier.OrderComponent"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:OrderComponent"" />
  </xsl:template>
  <xsl:template match=""/s0:OrderComponent"" />
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Supplier.OrderComponent";
        
        private const global::Supplier.OrderComponent _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Supplier.ShippingOrder";
        
        private const global::Supplier.ShippingOrder _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Supplier.OrderComponent";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Supplier.ShippingOrder";
                return _TrgSchemas;
            }
        }
    }
}
