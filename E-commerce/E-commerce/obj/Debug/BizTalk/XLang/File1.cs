
#pragma warning disable 162

namespace E_commerce
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(E_commerce.__messagetype_E_commerce_CustomerOrder)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortTypeOrchInput : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortTypeOrchInput(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortTypeOrchInput(PortTypeOrchInput p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortTypeOrchInput p = new PortTypeOrchInput(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortTypeOrchInput),
            typeof(__messagetype_E_commerce_CustomerOrder),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(E_commerce.__messagetype_E_commerce_OrderConfirmation)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortTypeOrchOutput : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortTypeOrchOutput(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortTypeOrchOutput(PortTypeOrchOutput p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortTypeOrchOutput p = new PortTypeOrchOutput(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortTypeOrchOutput),
            typeof(__messagetype_E_commerce_OrderConfirmation),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 242 "C:\Tutorial\Lessons\E-commerce\E-commerce\E-commerceOrchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "PortOrchInput", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(E_commerce.PortTypeOrchInput),
            typeof(E_commerce.localhost.Service_.Service),
            typeof(E_commerce.PortTypeOrchOutput)
        },
        new System.String[] {
            "PortOrchInput",
            "PortPaymentRequest",
            "PortOrchOutput"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class E_commerceOrchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(E_commerceOrchestration));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static E_commerceOrchestration()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __E_commerceOrchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public E_commerceOrchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "E_commerceOrchestration", tracker)
        {
            ConstructorHelper();
        }

        public E_commerceOrchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "E_commerceOrchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>63c3b41d-3992-4667-863f-cb1f889c9414</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>3538d5e4-ae02-49c5-be57-60323a6f8a0b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c6d189fb-4c44-4f65-85dd-9129485ccc2c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>d38fcfe0-31ef-4b31-83c3-d910606efe89</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>116b059d-91aa-4cc3-ba2a-f194cfba6dc7</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>4cbe6ad8-b978-4cdb-adbd-4798c04e8e72</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>4e7a4ca2-f08a-423e-8758-b12259739788</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>28c1010e-1a7e-49ed-b3b4-24c9628a317c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>b019b351-8985-449c-8808-598134787172</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>f68e9c1b-5948-4658-b45c-fc9df35c6c47</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1fda0fe1-f552-49ca-a6da-8fc259e5222c</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>96e4fe58-5fc8-4d93-a273-74037c8a77b7</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>3fdefae8-ad04-4b83-89f0-dae303446655</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'E_commerceOrchestration'</ActionName><IsAtomic>0</IsAtomic><Line>242</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>257</Line><Position>22</Position><ShapeID>'3538d5e4-ae02-49c5-be57-60323a6f8a0b'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomerOrder</name><part>part</part><schema>E_commerce.CustomerOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>259</Line><Position>13</Position><ShapeID>'c6d189fb-4c44-4f65-85dd-9129485ccc2c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>267</Line><Position>13</Position><ShapeID>'4cbe6ad8-b978-4cdb-adbd-4798c04e8e72'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>269</Line><Position>13</Position><ShapeID>'4e7a4ca2-f08a-423e-8758-b12259739788'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>271</Line><Position>13</Position><ShapeID>'28c1010e-1a7e-49ed-b3b4-24c9628a317c'</ShapeID>
<Messages>
	<MsgInfo><name>msgOrderConfirmation</name><part>part</part><schema>E_commerce.OrderConfirmation</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgCustomerOrder</name><part>part</part><schema>E_commerce.CustomerOrder</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>277</Line><Position>13</Position><ShapeID>'3fdefae8-ad04-4b83-89f0-dae303446655'</ShapeID>
<Messages>
	<MsgInfo><name>msgOrderConfirmation</name><part>part</part><schema>E_commerce.OrderConfirmation</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='07527bce-cf4d-4ef0-b60a-09a1a75fbcfe' LowerBound='1.1' HigherBound='58.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='E_commerce' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='b843fb62-bbd2-433d-800a-da7c3b435695' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortTypeOrchInput' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8cf1a2b2-fc61-4f7e-9d28-790d339c77fb' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='5f567b1c-51eb-4279-887b-f370b26e5110' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.26'>
                    <om:Property Name='Ref' Value='E_commerce.CustomerOrder' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='88a0b10d-0c42-45a2-9c3c-bc9e91ff0858' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortTypeOrchOutput' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f28d2a75-9fac-4c0c-bba5-d2035bc4ad00' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='50f50db0-0b59-4801-83f0-b52695d587c2' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.30'>
                    <om:Property Name='Ref' Value='E_commerce.OrderConfirmation' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='5ee5b5f6-e323-4583-b9a3-bcc188fd1639' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='57.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='E_commerceOrchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='32a563b4-5615-4c76-aa55-e4e294e3f252' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='E_commerce.CustomerOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCustomerOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='972202d0-77ab-4784-891c-84ab0210f454' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='E_commerce.OrderConfirmation' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOrderConfirmation' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='841031c4-7b0a-4b8c-8ee7-d49e4e4029bc' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='Type' Value='E_commerce.localhost.Service_.ConfirmPayment_request' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgPaymentRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='5bdd7bf4-8b74-4fb3-962e-a5ad8b88a13e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='Type' Value='E_commerce.localhost.Service_.ConfirmPayment_response' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgPaymentConfirmation' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='63c3b41d-3992-4667-863f-cb1f889c9414' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='3538d5e4-ae02-49c5-be57-60323a6f8a0b' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='PortOrchInput' />
                    <om:Property Name='MessageName' Value='msgCustomerOrder' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='c6d189fb-4c44-4f65-85dd-9129485ccc2c' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='43.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='d38fcfe0-31ef-4b31-83c3-d910606efe89' ParentLink='ComplexStatement_Statement' LowerBound='38.1' HigherBound='42.1'>
                        <om:Property Name='Expression' Value='msgPaymentRequest.creditCard = msgCustomerOrder.CreditCard;&#xD;&#xA;msgPaymentRequest.customerName = msgCustomerOrder.CustomerName;&#xD;&#xA;msgPaymentRequest.amount = msgCustomerOrder.Price;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='116b059d-91aa-4cc3-ba2a-f194cfba6dc7' ParentLink='Construct_MessageRef' LowerBound='36.23' HigherBound='36.40'>
                        <om:Property Name='Ref' Value='msgPaymentRequest' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='4cbe6ad8-b978-4cdb-adbd-4798c04e8e72' ParentLink='ServiceBody_Statement' LowerBound='43.1' HigherBound='45.1'>
                    <om:Property Name='PortName' Value='PortPaymentRequest' />
                    <om:Property Name='MessageName' Value='msgPaymentRequest' />
                    <om:Property Name='OperationName' Value='ConfirmPayment' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='4e7a4ca2-f08a-423e-8758-b12259739788' ParentLink='ServiceBody_Statement' LowerBound='45.1' HigherBound='47.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='PortPaymentRequest' />
                    <om:Property Name='MessageName' Value='msgPaymentConfirmation' />
                    <om:Property Name='OperationName' Value='ConfirmPayment' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='28c1010e-1a7e-49ed-b3b4-24c9628a317c' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='53.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_2' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='b019b351-8985-449c-8808-598134787172' ParentLink='ComplexStatement_Statement' LowerBound='50.1' HigherBound='52.1'>
                        <om:Property Name='ClassName' Value='E_commerce.Transform_1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='f68e9c1b-5948-4658-b45c-fc9df35c6c47' ParentLink='Transform_InputMessagePartRef' LowerBound='51.76' HigherBound='51.92'>
                            <om:Property Name='MessageRef' Value='msgCustomerOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='1fda0fe1-f552-49ca-a6da-8fc259e5222c' ParentLink='Transform_OutputMessagePartRef' LowerBound='51.28' HigherBound='51.48'>
                            <om:Property Name='MessageRef' Value='msgOrderConfirmation' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='96e4fe58-5fc8-4d93-a273-74037c8a77b7' ParentLink='Construct_MessageRef' LowerBound='48.23' HigherBound='48.43'>
                        <om:Property Name='Ref' Value='msgOrderConfirmation' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='3fdefae8-ad04-4b83-89f0-dae303446655' ParentLink='ServiceBody_Statement' LowerBound='53.1' HigherBound='55.1'>
                    <om:Property Name='PortName' Value='PortOrchOutput' />
                    <om:Property Name='MessageName' Value='msgOrderConfirmation' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4fac6c1e-7077-463d-9928-209183fa47cc' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='33' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='E_commerce.PortTypeOrchOutput' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PortOrchOutput' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c8629e93-aa59-4fec-901e-c1c03b1c429c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='584b0bd2-2eaf-4e67-ae62-2cbb42d01c45' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='0' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='E_commerce.PortTypeOrchInput' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PortOrchInput' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='439db07a-1049-4547-94ba-2e5c5776666a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8bf9a598-b689-4000-a752-2108dc487d52' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='25.1' HigherBound='27.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='18' />
                <om:Property Name='IsWebPort' Value='True' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='E_commerce.localhost.Service_.Service' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PortPaymentRequest' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='bc52138b-936f-47dc-a37c-03eaa78b72a0' ParentLink='PortDeclaration_CLRAttribute' LowerBound='25.1' HigherBound='26.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.PassThruReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.PassThruTransmit' />
                    <om:Property Name='TransportType' Value='SOAP' />
                    <om:Property Name='URI' Value='http://localhost/Bank/Service.asmx' />
                    <om:Property Name='IsDynamic' Value='False' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __E_commerceOrchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __E_commerceOrchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "E_commerceOrchestration")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                E_commerceOrchestration __svc__ = (E_commerceOrchestration)_service;
                __E_commerceOrchestration_root_0 __ctx0__ = (__E_commerceOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.PortPaymentRequest != null)
                {
                    __svc__.PortPaymentRequest.Close(this, null);
                    __svc__.PortPaymentRequest = null;
                }
                if (__svc__.PortOrchInput != null)
                {
                    __svc__.PortOrchInput.Close(this, null);
                    __svc__.PortOrchInput = null;
                }
                if (__svc__.PortOrchOutput != null)
                {
                    __svc__.PortOrchOutput.Close(this, null);
                    __svc__.PortOrchOutput = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __E_commerceOrchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __E_commerceOrchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "E_commerceOrchestration")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                E_commerceOrchestration __svc__ = (E_commerceOrchestration)_service;
                __E_commerceOrchestration_1 __ctx1__ = (__E_commerceOrchestration_1)(__svc__._stateMgrs[1]);
                __E_commerceOrchestration_root_0 __ctx0__ = (__E_commerceOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null && __ctx1__.__msgPaymentConfirmation != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgPaymentConfirmation);
                    __ctx1__.__msgPaymentConfirmation = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgPaymentRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgPaymentRequest);
                    __ctx1__.__msgPaymentRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgOrderConfirmation != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrderConfirmation);
                    __ctx1__.__msgOrderConfirmation = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                    __ctx1__.__msgCustomerOrder = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCustomerOrder")]
            public __messagetype_E_commerce_CustomerOrder __msgCustomerOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOrderConfirmation")]
            public __messagetype_E_commerce_OrderConfirmation __msgOrderConfirmation;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgPaymentRequest")]
            internal E_commerce.localhost.Service_.ConfirmPayment_request __msgPaymentRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgPaymentConfirmation")]
            internal E_commerce.localhost.Service_.ConfirmPayment_response __msgPaymentConfirmation;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PortOrchInput")]
        internal PortTypeOrchInput PortOrchInput;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute("SOAP", "http://localhost/Bank/Service.asmx", typeof(Microsoft.BizTalk.DefaultPipelines.PassThruReceive), typeof(Microsoft.BizTalk.DefaultPipelines.PassThruTransmit), Proxy = typeof(E_commerce.localhost.Service_.Service))]
        [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(E_commerce.localhost.Service))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PortPaymentRequest")]
        internal E_commerce.localhost.Service_.Service PortPaymentRequest;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PortOrchOutput")]
        internal PortTypeOrchOutput PortOrchOutput;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortTypeOrchInput.Operation_1},
                                               typeof(E_commerceOrchestration).GetField("PortOrchInput", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(E_commerceOrchestration), "PortOrchInput"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {E_commerce.localhost.Service_.Service.ConfirmPayment},
                                               typeof(E_commerceOrchestration).GetField("PortPaymentRequest", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(E_commerceOrchestration), "PortPaymentRequest"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortTypeOrchOutput.Operation_1},
                                               typeof(E_commerceOrchestration).GetField("PortOrchOutput", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(E_commerceOrchestration), "PortOrchOutput"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "3538d5e4-ae02-49c5-be57-60323a6f8a0b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "3538d5e4-ae02-49c5-be57-60323a6f8a0b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "c6d189fb-4c44-4f65-85dd-9129485ccc2c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "c6d189fb-4c44-4f65-85dd-9129485ccc2c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "4cbe6ad8-b978-4cdb-adbd-4798c04e8e72", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "4cbe6ad8-b978-4cdb-adbd-4798c04e8e72", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "4e7a4ca2-f08a-423e-8758-b12259739788", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "4e7a4ca2-f08a-423e-8758-b12259739788", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "28c1010e-1a7e-49ed-b3b4-24c9628a317c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "28c1010e-1a7e-49ed-b3b4-24c9628a317c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "3fdefae8-ad04-4b83-89f0-dae303446655", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "3fdefae8-ad04-4b83-89f0-dae303446655", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,13,13,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,10,11,11,11,12,13,13,13,13,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __E_commerceOrchestration_1 __ctx1__ = (__E_commerceOrchestration_1)_stateMgrs[1];
            __E_commerceOrchestration_root_0 __ctx0__ = (__E_commerceOrchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                PortOrchOutput = new PortTypeOrchOutput(2, this);
                PortOrchInput = new PortTypeOrchInput(0, this);
                PortPaymentRequest = new E_commerce.localhost.Service_.Service(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], PortOrchInput, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __E_commerceOrchestration_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __E_commerceOrchestration_1 __ctx1__ = (__E_commerceOrchestration_1)_stateMgrs[1];
            __E_commerceOrchestration_root_0 __ctx0__ = (__E_commerceOrchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!PortOrchInput.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgCustomerOrder != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                __ctx1__.__msgCustomerOrder = new __messagetype_E_commerce_CustomerOrder("msgCustomerOrder", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgCustomerOrder);
                PortOrchInput.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgCustomerOrder, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (PortOrchInput != null)
                {
                    PortOrchInput.Close(__ctx1__, __seg__);
                    PortOrchInput = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgCustomerOrder);
                    __edata.PortName = @"PortOrchInput";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    E_commerce.localhost.Service_.ConfirmPayment_request __msgPaymentRequest = new E_commerce.localhost.Service_.ConfirmPayment_request("msgPaymentRequest", __ctx1__);

                    __msgPaymentRequest.creditCard.LoadFrom((System.String)__ctx1__.__msgCustomerOrder.part.GetDistinguishedField("CreditCard"));
                    __msgPaymentRequest.customerName.LoadFrom((System.String)__ctx1__.__msgCustomerOrder.part.GetDistinguishedField("CustomerName"));
                    __msgPaymentRequest.amount.LoadFrom((System.Double)__ctx1__.__msgCustomerOrder.part.GetDistinguishedField("Price"));

                    if (__ctx1__.__msgPaymentRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgPaymentRequest);
                    __ctx1__.__msgPaymentRequest = __msgPaymentRequest;
                    __ctx1__.RefMessage(__ctx1__.__msgPaymentRequest);
                }
                __ctx1__.__msgPaymentRequest.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgPaymentRequest);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                PortPaymentRequest.SendMessage(0, __ctx1__.__msgPaymentRequest, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgPaymentRequest);
                    __edata.PortName = @"PortPaymentRequest";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgPaymentRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgPaymentRequest);
                    __ctx1__.__msgPaymentRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!PortPaymentRequest.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgPaymentConfirmation != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgPaymentConfirmation);
                __ctx1__.__msgPaymentConfirmation = new E_commerce.localhost.Service_.ConfirmPayment_response("msgPaymentConfirmation", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgPaymentConfirmation);
                PortPaymentRequest.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgPaymentConfirmation, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (PortPaymentRequest != null)
                {
                    PortPaymentRequest.Close(__ctx1__, __seg__);
                    PortPaymentRequest = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgPaymentConfirmation);
                    __edata.PortName = @"PortPaymentRequest";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgPaymentConfirmation != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgPaymentConfirmation);
                    __ctx1__.__msgPaymentConfirmation = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                {
                    __messagetype_E_commerce_OrderConfirmation __msgOrderConfirmation = new __messagetype_E_commerce_OrderConfirmation("msgOrderConfirmation", __ctx1__);

                    ApplyTransform(typeof(E_commerce.Transform_1), new object[] {__msgOrderConfirmation.part}, new object[] {__ctx1__.__msgCustomerOrder.part});

                    if (__ctx1__.__msgOrderConfirmation != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgOrderConfirmation);
                    __ctx1__.__msgOrderConfirmation = __msgOrderConfirmation;
                    __ctx1__.RefMessage(__ctx1__.__msgOrderConfirmation);
                }
                __ctx1__.__msgOrderConfirmation.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgOrderConfirmation);
                    __edata.Messages.Add(__ctx1__.__msgCustomerOrder);
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOrder);
                    __ctx1__.__msgCustomerOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                PortOrchOutput.SendMessage(0, __ctx1__.__msgOrderConfirmation, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (PortOrchOutput != null)
                {
                    PortOrchOutput.Close(__ctx1__, __seg__);
                    PortOrchOutput = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgOrderConfirmation);
                    __edata.PortName = @"PortOrchOutput";
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgOrderConfirmation != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOrderConfirmation);
                    __ctx1__.__msgOrderConfirmation = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 25;
            case 25:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{C21D53B5-BC5C-4430-B560-9648B88F749C}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __E_commerce_CustomerOrder__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static E_commerce.CustomerOrder _schema = new E_commerce.CustomerOrder();

        public __E_commerce_CustomerOrder__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "E_commerce.CustomerOrder",
        new System.Type[]{
            typeof(E_commerce.CustomerOrder)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__E_commerce_CustomerOrder__)
        },
        0,
        @"http://E_commerce.CustomerOrder#CustomerOrder"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_E_commerce_CustomerOrder : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __E_commerce_CustomerOrder__ part;

        private void __CreatePartWrappers()
        {
            part = new __E_commerce_CustomerOrder__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_E_commerce_CustomerOrder(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __E_commerce_OrderConfirmation__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static E_commerce.OrderConfirmation _schema = new E_commerce.OrderConfirmation();

        public __E_commerce_OrderConfirmation__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "E_commerce.OrderConfirmation",
        new System.Type[]{
            typeof(E_commerce.OrderConfirmation)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__E_commerce_OrderConfirmation__)
        },
        0,
        @"http://E_commerce.OrderConfirmation#OrderConfirmation"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_E_commerce_OrderConfirmation : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __E_commerce_OrderConfirmation__ part;

        private void __CreatePartWrappers()
        {
            part = new __E_commerce_OrderConfirmation__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_E_commerce_OrderConfirmation(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
