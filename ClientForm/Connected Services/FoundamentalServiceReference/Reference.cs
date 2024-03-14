﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientForm.FoundamentalServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonDTO", Namespace="http://schemas.datacontract.org/2004/07/WcfFoundamentalService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class PersonDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PersonalIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonalId {
            get {
                return this.PersonalIdField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalIdField, value) != true)) {
                    this.PersonalIdField = value;
                    this.RaisePropertyChanged("PersonalId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FoundamentalServiceReference.IFoundamental")]
    public interface IFoundamental {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoundamental/GetAllPerson", ReplyAction="http://tempuri.org/IFoundamental/GetAllPersonResponse")]
        ClientForm.FoundamentalServiceReference.PersonDTO[] GetAllPerson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoundamental/GetAllPerson", ReplyAction="http://tempuri.org/IFoundamental/GetAllPersonResponse")]
        System.Threading.Tasks.Task<ClientForm.FoundamentalServiceReference.PersonDTO[]> GetAllPersonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoundamental/AddPerson", ReplyAction="http://tempuri.org/IFoundamental/AddPersonResponse")]
        void AddPerson(ClientForm.FoundamentalServiceReference.PersonDTO NewPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoundamental/AddPerson", ReplyAction="http://tempuri.org/IFoundamental/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(ClientForm.FoundamentalServiceReference.PersonDTO NewPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoundamental/DeletePersonById", ReplyAction="http://tempuri.org/IFoundamental/DeletePersonByIdResponse")]
        void DeletePersonById(int personId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoundamental/DeletePersonById", ReplyAction="http://tempuri.org/IFoundamental/DeletePersonByIdResponse")]
        System.Threading.Tasks.Task DeletePersonByIdAsync(int personId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoundamental/GetPersonById", ReplyAction="http://tempuri.org/IFoundamental/GetPersonByIdResponse")]
        ClientForm.FoundamentalServiceReference.PersonDTO GetPersonById(int personId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoundamental/GetPersonById", ReplyAction="http://tempuri.org/IFoundamental/GetPersonByIdResponse")]
        System.Threading.Tasks.Task<ClientForm.FoundamentalServiceReference.PersonDTO> GetPersonByIdAsync(int personId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFoundamentalChannel : ClientForm.FoundamentalServiceReference.IFoundamental, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FoundamentalClient : System.ServiceModel.ClientBase<ClientForm.FoundamentalServiceReference.IFoundamental>, ClientForm.FoundamentalServiceReference.IFoundamental {
        
        public FoundamentalClient() {
        }
        
        public FoundamentalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FoundamentalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FoundamentalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FoundamentalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientForm.FoundamentalServiceReference.PersonDTO[] GetAllPerson() {
            return base.Channel.GetAllPerson();
        }
        
        public System.Threading.Tasks.Task<ClientForm.FoundamentalServiceReference.PersonDTO[]> GetAllPersonAsync() {
            return base.Channel.GetAllPersonAsync();
        }
        
        public void AddPerson(ClientForm.FoundamentalServiceReference.PersonDTO NewPerson) {
            base.Channel.AddPerson(NewPerson);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(ClientForm.FoundamentalServiceReference.PersonDTO NewPerson) {
            return base.Channel.AddPersonAsync(NewPerson);
        }
        
        public void DeletePersonById(int personId) {
            base.Channel.DeletePersonById(personId);
        }
        
        public System.Threading.Tasks.Task DeletePersonByIdAsync(int personId) {
            return base.Channel.DeletePersonByIdAsync(personId);
        }
        
        public ClientForm.FoundamentalServiceReference.PersonDTO GetPersonById(int personId) {
            return base.Channel.GetPersonById(personId);
        }
        
        public System.Threading.Tasks.Task<ClientForm.FoundamentalServiceReference.PersonDTO> GetPersonByIdAsync(int personId) {
            return base.Channel.GetPersonByIdAsync(personId);
        }
    }
}
