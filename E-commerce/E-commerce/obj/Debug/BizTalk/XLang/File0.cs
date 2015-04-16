
#pragma warning disable 162

namespace E_commerce.localhost.Service_
{

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_4.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.String' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='string' nillable='true' type='xs:string' />
</xs:schema>",
        @"string",
        null,
        typeof(System.String),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_String__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_String__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.String); } }
        public System.String TypedValue { get { return (System.String) this.RetrieveAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        public System.String WriteableTypedValue { get { return (System.String) this.RetrieveForWriteAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.String); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_4.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.Double' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='double' type='xs:double' />
</xs:schema>",
        @"double",
        null,
        typeof(System.Double),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_Double__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_Double__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.Double); } }
        public System.Double TypedValue { get { return (System.Double) this.RetrieveAs(typeof(System.Double)); } set { this.LoadFrom(value); } }
        public System.Double WriteableTypedValue { get { return (System.Double) this.RetrieveForWriteAs(typeof(System.Double)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.Double); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eRequest,
        "E_commerce.localhost.Service.ConfirmPayment",
        new System.Type[]{
            typeof(System.String),
            typeof(System.String),
            typeof(System.Double)
        },
        new string[]{
            "creditCard",
            "customerName",
            "amount"
        },
        new System.Type[]{
            typeof(__System_String__),
            typeof(__System_String__),
            typeof(__System_Double__)
        },
        0,
        @"string"
    )]
    [System.SerializableAttribute]
    sealed public class ConfirmPayment_request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_String__ creditCard;
        public __System_String__ customerName;
        public __System_Double__ amount;

        private void __CreatePartWrappers()
        {
            creditCard = new __System_String__(this, "creditCard", 0);
            this.AddPart("creditCard", 0, creditCard);
            customerName = new __System_String__(this, "customerName", 1);
            this.AddPart("customerName", 1, customerName);
            amount = new __System_Double__(this, "amount", 2);
            this.AddPart("amount", 2, amount);
        }

        public ConfirmPayment_request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eResponse,
        "E_commerce.localhost.Service.ConfirmPayment",
        new System.Type[]{
            typeof(System.String)
        },
        new string[]{
            "ConfirmPaymentResult"
        },
        new System.Type[]{
            typeof(__System_String__)
        },
        0,
        @"string"
    )]
    [System.SerializableAttribute]
    sealed public class ConfirmPayment_response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_String__ ConfirmPaymentResult;

        private void __CreatePartWrappers()
        {
            ConfirmPaymentResult = new __System_String__(this, "ConfirmPaymentResult", 0);
            this.AddPart("ConfirmPaymentResult", 0, ConfirmPaymentResult);
        }

        public ConfirmPayment_response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ConfirmPayment",
        new System.Type[]{
            typeof(E_commerce.localhost.Service_.ConfirmPayment_request), 
            typeof(E_commerce.localhost.Service_.ConfirmPayment_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(E_commerce.localhost.Service))]
    [System.SerializableAttribute]
    sealed public class Service : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Service(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Service(Service p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Service p = new Service(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ConfirmPayment = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ConfirmPayment",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(Service),
            typeof(ConfirmPayment_request),
            typeof(ConfirmPayment_response),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ConfirmPayment" ] = ConfirmPayment;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(true)]
    [Microsoft.XLANGs.BaseTypes.TargetXmlNamespaceAttribute("http://Bank/")]
    sealed public class _MODULE_PROXY_ { }
}
