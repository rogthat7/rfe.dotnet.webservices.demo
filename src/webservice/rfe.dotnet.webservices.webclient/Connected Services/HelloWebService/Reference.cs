//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rfe.dotnet.webservices.webclient.HelloWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloWebService.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessage", ReplyAction="*")]
        rfe.dotnet.webservices.webclient.HelloWebService.GetMessageResponse GetMessage(rfe.dotnet.webservices.webclient.HelloWebService.GetMessageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMessage", Namespace="http://tempuri.org/", Order=0)]
        public rfe.dotnet.webservices.webclient.HelloWebService.GetMessageRequestBody Body;
        
        public GetMessageRequest() {
        }
        
        public GetMessageRequest(rfe.dotnet.webservices.webclient.HelloWebService.GetMessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMessageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public GetMessageRequestBody() {
        }
        
        public GetMessageRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public rfe.dotnet.webservices.webclient.HelloWebService.GetMessageResponseBody Body;
        
        public GetMessageResponse() {
        }
        
        public GetMessageResponse(rfe.dotnet.webservices.webclient.HelloWebService.GetMessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMessageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetMessageResult;
        
        public GetMessageResponseBody() {
        }
        
        public GetMessageResponseBody(string GetMessageResult) {
            this.GetMessageResult = GetMessageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : rfe.dotnet.webservices.webclient.HelloWebService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<rfe.dotnet.webservices.webclient.HelloWebService.WebService1Soap>, rfe.dotnet.webservices.webclient.HelloWebService.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        rfe.dotnet.webservices.webclient.HelloWebService.GetMessageResponse rfe.dotnet.webservices.webclient.HelloWebService.WebService1Soap.GetMessage(rfe.dotnet.webservices.webclient.HelloWebService.GetMessageRequest request) {
            return base.Channel.GetMessage(request);
        }
        
        public string GetMessage(string name) {
            rfe.dotnet.webservices.webclient.HelloWebService.GetMessageRequest inValue = new rfe.dotnet.webservices.webclient.HelloWebService.GetMessageRequest();
            inValue.Body = new rfe.dotnet.webservices.webclient.HelloWebService.GetMessageRequestBody();
            inValue.Body.name = name;
            rfe.dotnet.webservices.webclient.HelloWebService.GetMessageResponse retVal = ((rfe.dotnet.webservices.webclient.HelloWebService.WebService1Soap)(this)).GetMessage(inValue);
            return retVal.Body.GetMessageResult;
        }
    }
}
