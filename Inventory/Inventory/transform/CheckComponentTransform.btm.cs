namespace Inventory {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inventory.CheckComponent", typeof(global::Inventory.CheckComponent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inventory.IncreaseStockSQLService+InComponent", typeof(global::Inventory.IncreaseStockSQLService.InComponent))]
    public sealed class CheckComponentTransform : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Inventory.CheckComponent"" xmlns:ns0=""http://IncreaseStockSQL"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Component"" />
  </xsl:template>
  <xsl:template match=""/s0:Component"">
    <ns0:InComponent>
      <ns0:IncreaseStock>
        <xsl:attribute name=""category"">
          <xsl:value-of select=""Category/text()"" />
        </xsl:attribute>
        <xsl:attribute name=""option"">
          <xsl:value-of select=""Option/text()"" />
        </xsl:attribute>
      </ns0:IncreaseStock>
    </ns0:InComponent>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Inventory.CheckComponent";
        
        private const global::Inventory.CheckComponent _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Inventory.IncreaseStockSQLService+InComponent";
        
        private const global::Inventory.IncreaseStockSQLService.InComponent _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Inventory.CheckComponent";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Inventory.IncreaseStockSQLService+InComponent";
                return _TrgSchemas;
            }
        }
    }
}
