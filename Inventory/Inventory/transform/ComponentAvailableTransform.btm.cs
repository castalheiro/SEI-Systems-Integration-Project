namespace Inventory {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inventory.CheckComponent", typeof(global::Inventory.CheckComponent))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inventory.CheckStockSQLService+OutStock", typeof(global::Inventory.CheckStockSQLService.OutStock))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Inventory.ComponentAvailable", typeof(global::Inventory.ComponentAvailable))]
    public sealed class ComponentAvailableTransform : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s0 s1 userCSharp"" version=""1.0"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://CheckStockSQL"" xmlns:s1=""http://Inventory.CheckComponent"" xmlns:ns0=""http://Inventory.ComponentAvailable"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:MathAdd(string(InputMessagePart_1/s0:OutStock/s0:inventory/@stock_quantity) , &quot;1&quot;)"" />
    <ns0:Component>
      <ComponentInfo>
        <Category>
          <xsl:value-of select=""InputMessagePart_0/s1:Component/Category/text()"" />
        </Category>
        <Option>
          <xsl:value-of select=""InputMessagePart_0/s1:Component/Option/text()"" />
        </Option>
        <Identifier>
          <xsl:value-of select=""InputMessagePart_0/s1:Component/Identifier/text()"" />
        </Identifier>
      </ComponentInfo>
      <Quantity>
        <xsl:value-of select=""$var:v1"" />
      </Quantity>
    </ns0:Component>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string MathAdd(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 0;
	foreach (string obj in listValues)
	{
	double d = 0;
		if (IsNumeric(obj, ref d))
		{
			ret += d;
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Inventory.CheckComponent";
        
        private const global::Inventory.CheckComponent _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"Inventory.CheckStockSQLService+OutStock";
        
        private const global::Inventory.CheckStockSQLService.OutStock _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"Inventory.ComponentAvailable";
        
        private const global::Inventory.ComponentAvailable _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Inventory.ComponentAvailable";
                return _TrgSchemas;
            }
        }
    }
}
