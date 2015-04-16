namespace E_commerce {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"E_commerce.CustomerOrder", typeof(global::E_commerce.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"E_commerce.OrderConfirmation", typeof(global::E_commerce.OrderConfirmation))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://E_commerce.OrderConfirmation"" xmlns:s0=""http://E_commerce.CustomerOrder"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerOrder"">
    <ns0:OrderConfirmation>
      <OrderNumber>
        <xsl:value-of select=""OrderNumber/text()"" />
      </OrderNumber>
      <CustomerName>
        <xsl:value-of select=""CustomerName/text()"" />
      </CustomerName>
      <Address>
        <xsl:value-of select=""Address/text()"" />
      </Address>
      <Price>
        <xsl:value-of select=""Price/text()"" />
      </Price>
      <ComponentsList>
        <xsl:for-each select=""ComponentsList/Component"">
          <Component>
            <Category>
              <xsl:value-of select=""Category/text()"" />
            </Category>
            <Option>
              <xsl:value-of select=""Option/text()"" />
            </Option>
          </Component>
        </xsl:for-each>
      </ComponentsList>
    </ns0:OrderConfirmation>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"E_commerce.CustomerOrder";
        
        private const global::E_commerce.CustomerOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"E_commerce.OrderConfirmation";
        
        private const global::E_commerce.OrderConfirmation _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"E_commerce.CustomerOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"E_commerce.OrderConfirmation";
                return _TrgSchemas;
            }
        }
    }
}
