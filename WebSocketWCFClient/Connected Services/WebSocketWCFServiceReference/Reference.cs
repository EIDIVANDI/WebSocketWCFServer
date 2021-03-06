﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSocketWCFClient.WebSocketWCFServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebSocketWCFServiceReference.IWebSocketService", CallbackContract=typeof(WebSocketWCFClient.WebSocketWCFServiceReference.IWebSocketServiceCallback))]
    public interface IWebSocketService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebSocketService/SendData", ReplyAction="http://tempuri.org/IWebSocketService/SendDataResponse")]
        void SendData(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebSocketService/SendData", ReplyAction="http://tempuri.org/IWebSocketService/SendDataResponse")]
        System.Threading.Tasks.Task SendDataAsync(string data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebSocketServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWebSocketService/SendBackData")]
        void SendBackData(string data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebSocketServiceChannel : WebSocketWCFClient.WebSocketWCFServiceReference.IWebSocketService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebSocketServiceClient : System.ServiceModel.DuplexClientBase<WebSocketWCFClient.WebSocketWCFServiceReference.IWebSocketService>, WebSocketWCFClient.WebSocketWCFServiceReference.IWebSocketService {
        
        public WebSocketServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public WebSocketServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public WebSocketServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebSocketServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebSocketServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SendData(string data) {
            base.Channel.SendData(data);
        }
        
        public System.Threading.Tasks.Task SendDataAsync(string data) {
            return base.Channel.SendDataAsync(data);
        }
    }
}
