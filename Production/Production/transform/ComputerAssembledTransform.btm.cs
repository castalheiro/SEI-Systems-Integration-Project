namespace Production {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Production.AssembleComputer", typeof(global::Production.AssembleComputer))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Production.ComputerAssembled", typeof(global::Production.ComputerAssembled))]
    public sealed class ComputerAssembledTransform : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Production.AssembleComputer"" xmlns:ns0=""http://Production.ComputerAssembled"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AssembleComputer"" />
  </xsl:template>
  <xsl:template match=""/s0:AssembleComputer"">
    <ns0:ComputerAssembled>
      <OrderNumber>
        <xsl:value-of select=""OrderNumber/text()"" />
      </OrderNumber>
    </ns0:ComputerAssembled>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Production.AssembleComputer";
        
        private const global::Production.AssembleComputer _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Production.ComputerAssembled";
        
        private const global::Production.ComputerAssembled _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Production.AssembleComputer";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Production.ComputerAssembled";
                return _TrgSchemas;
            }
        }
    }
}
