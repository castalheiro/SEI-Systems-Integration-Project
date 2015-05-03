namespace Inventory {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inventory.CheckComponent", typeof(global::Inventory.CheckComponent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inventory.CheckStockSQLService+OutStock", typeof(global::Inventory.CheckStockSQLService.OutStock))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Supplier.OrderComponent", typeof(global::Supplier.OrderComponent))]
    public sealed class OrderComponentTransform : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s0 s1 userJScript"" version=""1.0"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://CheckStockSQL"" xmlns:s1=""http://Inventory.CheckComponent"" xmlns:ns0=""http://Inventory.OrderComponent"" xmlns:userJScript=""http://schemas.microsoft.com/BizTalk/2003/userJScript"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <ns0:Component>
      <ComponentInfo>
        <Category>
          <xsl:value-of select=""InputMessagePart_0/s1:Component/Category/text()"" />
        </Category>
        <Option>
          <xsl:value-of select=""InputMessagePart_0/s1:Component/Option/text()"" />
        </Option>
      </ComponentInfo>
      <xsl:variable name=""var:v1"" select=""userJScript:MyConcat()"" />
      <PurchaseNumber>
        <xsl:value-of select=""$var:v1"" />
      </PurchaseNumber>
      <xsl:if test=""InputMessagePart_1/s0:OutStock/s0:inventory/@stock_quantity"">
        <Quantity>
          <xsl:value-of select=""InputMessagePart_1/s0:OutStock/s0:inventory/@stock_quantity"" />
        </Quantity>
      </xsl:if>
    </ns0:Component>
  </xsl:template>
  <msxsl:script language=""JScript"" implements-prefix=""userJScript""><![CDATA[
///*Uncomment the following code for a sample Inline JScript function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

function MyConcat()
{
              var date = new Date();
              var timestamp = date.getTime();

	return timestamp;
}




]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Inventory.CheckComponent";
        
        private const global::Inventory.CheckComponent _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"Inventory.CheckStockSQLService+OutStock";
        
        private const global::Inventory.CheckStockSQLService.OutStock _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"Supplier.OrderComponent";
        
        private const global::Supplier.OrderComponent _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"Inventory.CheckComponent";
                _SrcSchemas[1] = @"Inventory.CheckStockSQLService+OutStock";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Supplier.OrderComponent";
                return _TrgSchemas;
            }
        }
    }
}
