﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Verification", ReplyAction="http://tempuri.org/IService1/VerificationResponse")]
        string Verification(string xmlUrl, string xsdUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Verification", ReplyAction="http://tempuri.org/IService1/VerificationResponse")]
        System.Threading.Tasks.Task<string> VerificationAsync(string xmlUrl, string xsdUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/XPathSearch", ReplyAction="http://tempuri.org/IService1/XPathSearchResponse")]
        string XPathSearch(string xmlUrl, string xPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/XPathSearch", ReplyAction="http://tempuri.org/IService1/XPathSearchResponse")]
        System.Threading.Tasks.Task<string> XPathSearchAsync(string xmlUrl, string xPath);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleApplication1.ServiceReference1.IService1>, ConsoleApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Verification(string xmlUrl, string xsdUrl) {
            return base.Channel.Verification(xmlUrl, xsdUrl);
        }
        
        public System.Threading.Tasks.Task<string> VerificationAsync(string xmlUrl, string xsdUrl) {
            return base.Channel.VerificationAsync(xmlUrl, xsdUrl);
        }
        
        public string XPathSearch(string xmlUrl, string xPath) {
            return base.Channel.XPathSearch(xmlUrl, xPath);
        }
        
        public System.Threading.Tasks.Task<string> XPathSearchAsync(string xmlUrl, string xPath) {
            return base.Channel.XPathSearchAsync(xmlUrl, xPath);
        }
    }
}
