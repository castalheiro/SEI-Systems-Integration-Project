//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VisualStudio.BizTalkProject.Generators, Version 4.0.30319.34209.
// 
namespace Production.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="InventoryServiceSoap", Namespace="http://InventoryService/")]
    [Microsoft.XLANGs.BaseTypes.WebServiceUrlAttribute("http://localhost/InventoryService/InventoryService.asmx")]
    public partial class InventoryService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public InventoryService() {
            string urlSetting = System.Configuration.ConfigurationManager.AppSettings["Production.localhost.InventoryService"];
            if ((urlSetting != null)) {
                this.Url = string.Concat(urlSetting, "");
            }
            else {
                this.Url = "http://localhost/InventoryService/InventoryService.asmx";
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://InventoryService/DecreaseStock", RequestNamespace="http://InventoryService/", ResponseNamespace="http://InventoryService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DecreaseStock(string category, string option) {
            this.Invoke("DecreaseStock", new object[] {
                        category,
                        option});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDecreaseStock(string category, string option, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DecreaseStock", new object[] {
                        category,
                        option}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndDecreaseStock(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
}
