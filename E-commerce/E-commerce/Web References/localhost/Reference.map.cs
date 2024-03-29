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
namespace E_commerce.localhost {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://Bank/")]
    [Microsoft.XLANGs.BaseTypes.WebServiceUrlAttribute("http://localhost/Bank/Service.asmx")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Service() {
            string urlSetting = System.Configuration.ConfigurationManager.AppSettings["E-commerce.localhost.Service"];
            if ((urlSetting != null)) {
                this.Url = string.Concat(urlSetting, "");
            }
            else {
                this.Url = "http://localhost/Bank/Service.asmx";
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Bank/ConfirmPayment", RequestNamespace="http://Bank/", ResponseNamespace="http://Bank/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ConfirmPayment(string creditCard, string customerName, double amount) {
            object[] results = this.Invoke("ConfirmPayment", new object[] {
                        creditCard,
                        customerName,
                        amount});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginConfirmPayment(string creditCard, string customerName, double amount, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ConfirmPayment", new object[] {
                        creditCard,
                        customerName,
                        amount}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndConfirmPayment(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}
