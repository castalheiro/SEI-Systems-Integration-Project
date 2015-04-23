namespace E_Commerce {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"E_Commerce.CustomerOrder", typeof(global::E_Commerce.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"E_Commerce.CheckComponent", typeof(global::E_Commerce.CheckComponent))]
    public sealed class Transform_3 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://E_Commerce.Schema1"" xmlns:s0=""http://E_Commerce.CustomerOrder"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerOrder"" />
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"E_Commerce.CustomerOrder";
        
        private const global::E_Commerce.CustomerOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"E_Commerce.CheckComponent";
        
        private const global::E_Commerce.CheckComponent _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"E_Commerce.CustomerOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"E_Commerce.CheckComponent";
                return _TrgSchemas;
            }
        }
    }
}
