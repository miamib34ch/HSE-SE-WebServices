﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Use_Service.ServiceFahrenheitToCelsius {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://fahrenheittocelsiusconversion.azurewebsites.net/", ConfigurationName="ServiceFahrenheitToCelsius.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fahrenheittocelsiusconversion.azurewebsites.net/IService/FahrenheitToCelsi" +
            "us", ReplyAction="http://fahrenheittocelsiusconversion.azurewebsites.net/IService/FahrenheitToCelsi" +
            "usResponse")]
        double FahrenheitToCelsius(double farenheitDegrees);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fahrenheittocelsiusconversion.azurewebsites.net/IService/FahrenheitToCelsi" +
            "us", ReplyAction="http://fahrenheittocelsiusconversion.azurewebsites.net/IService/FahrenheitToCelsi" +
            "usResponse")]
        System.Threading.Tasks.Task<double> FahrenheitToCelsiusAsync(double farenheitDegrees);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fahrenheittocelsiusconversion.azurewebsites.net/IService/CelsiusToFahrenhe" +
            "it", ReplyAction="http://fahrenheittocelsiusconversion.azurewebsites.net/IService/CelsiusToFahrenhe" +
            "itResponse")]
        double CelsiusToFahrenheit(double celsiusDegrees);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fahrenheittocelsiusconversion.azurewebsites.net/IService/CelsiusToFahrenhe" +
            "it", ReplyAction="http://fahrenheittocelsiusconversion.azurewebsites.net/IService/CelsiusToFahrenhe" +
            "itResponse")]
        System.Threading.Tasks.Task<double> CelsiusToFahrenheitAsync(double celsiusDegrees);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Use_Service.ServiceFahrenheitToCelsius.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Use_Service.ServiceFahrenheitToCelsius.IService>, Use_Service.ServiceFahrenheitToCelsius.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double FahrenheitToCelsius(double farenheitDegrees) {
            return base.Channel.FahrenheitToCelsius(farenheitDegrees);
        }
        
        public System.Threading.Tasks.Task<double> FahrenheitToCelsiusAsync(double farenheitDegrees) {
            return base.Channel.FahrenheitToCelsiusAsync(farenheitDegrees);
        }
        
        public double CelsiusToFahrenheit(double celsiusDegrees) {
            return base.Channel.CelsiusToFahrenheit(celsiusDegrees);
        }
        
        public System.Threading.Tasks.Task<double> CelsiusToFahrenheitAsync(double celsiusDegrees) {
            return base.Channel.CelsiusToFahrenheitAsync(celsiusDegrees);
        }
    }
}