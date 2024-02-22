﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.CalculatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNumbers", ReplyAction="http://tempuri.org/IService1/AddNumbersResponse")]
        float AddNumbers(float n1, float n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNumbers", ReplyAction="http://tempuri.org/IService1/AddNumbersResponse")]
        System.Threading.Tasks.Task<float> AddNumbersAsync(float n1, float n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SubstractNumbers", ReplyAction="http://tempuri.org/IService1/SubstractNumbersResponse")]
        float SubstractNumbers(float n1, float n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SubstractNumbers", ReplyAction="http://tempuri.org/IService1/SubstractNumbersResponse")]
        System.Threading.Tasks.Task<float> SubstractNumbersAsync(float n1, float n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DivideNumbers", ReplyAction="http://tempuri.org/IService1/DivideNumbersResponse")]
        float DivideNumbers(float n1, float n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DivideNumbers", ReplyAction="http://tempuri.org/IService1/DivideNumbersResponse")]
        System.Threading.Tasks.Task<float> DivideNumbersAsync(float n1, float n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MultiplyNumbers", ReplyAction="http://tempuri.org/IService1/MultiplyNumbersResponse")]
        float MultiplyNumbers(float n1, float n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MultiplyNumbers", ReplyAction="http://tempuri.org/IService1/MultiplyNumbersResponse")]
        System.Threading.Tasks.Task<float> MultiplyNumbersAsync(float n1, float n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApp1.CalculatorServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApp1.CalculatorServiceReference.IService1>, WindowsFormsApp1.CalculatorServiceReference.IService1 {
        
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
        
        public float AddNumbers(float n1, float n2) {
            return base.Channel.AddNumbers(n1, n2);
        }
        
        public System.Threading.Tasks.Task<float> AddNumbersAsync(float n1, float n2) {
            return base.Channel.AddNumbersAsync(n1, n2);
        }
        
        public float SubstractNumbers(float n1, float n2) {
            return base.Channel.SubstractNumbers(n1, n2);
        }
        
        public System.Threading.Tasks.Task<float> SubstractNumbersAsync(float n1, float n2) {
            return base.Channel.SubstractNumbersAsync(n1, n2);
        }
        
        public float DivideNumbers(float n1, float n2) {
            return base.Channel.DivideNumbers(n1, n2);
        }
        
        public System.Threading.Tasks.Task<float> DivideNumbersAsync(float n1, float n2) {
            return base.Channel.DivideNumbersAsync(n1, n2);
        }
        
        public float MultiplyNumbers(float n1, float n2) {
            return base.Channel.MultiplyNumbers(n1, n2);
        }
        
        public System.Threading.Tasks.Task<float> MultiplyNumbersAsync(float n1, float n2) {
            return base.Channel.MultiplyNumbersAsync(n1, n2);
        }
    }
}
