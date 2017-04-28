﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CF.VRent.Entities.KEMASWSIF_CONFIGRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConfigModel", Namespace="urn:kemas")]
    [System.SerializableAttribute()]
    public partial class ConfigModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long BookingMaxDurationField;
        
        private long BookingAheadTimeField;
        
        private long BookingBufferTimeField;
        
        private long BookingMaxLeadTimeField;
        
        private long BookingMaxWaitTimeField;
        
        private long LostItemEnabledField;
        
        private long LostItemTimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long BookingMaxDuration {
            get {
                return this.BookingMaxDurationField;
            }
            set {
                if ((this.BookingMaxDurationField.Equals(value) != true)) {
                    this.BookingMaxDurationField = value;
                    this.RaisePropertyChanged("BookingMaxDuration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public long BookingAheadTime {
            get {
                return this.BookingAheadTimeField;
            }
            set {
                if ((this.BookingAheadTimeField.Equals(value) != true)) {
                    this.BookingAheadTimeField = value;
                    this.RaisePropertyChanged("BookingAheadTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public long BookingBufferTime {
            get {
                return this.BookingBufferTimeField;
            }
            set {
                if ((this.BookingBufferTimeField.Equals(value) != true)) {
                    this.BookingBufferTimeField = value;
                    this.RaisePropertyChanged("BookingBufferTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public long BookingMaxLeadTime {
            get {
                return this.BookingMaxLeadTimeField;
            }
            set {
                if ((this.BookingMaxLeadTimeField.Equals(value) != true)) {
                    this.BookingMaxLeadTimeField = value;
                    this.RaisePropertyChanged("BookingMaxLeadTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public long BookingMaxWaitTime {
            get {
                return this.BookingMaxWaitTimeField;
            }
            set {
                if ((this.BookingMaxWaitTimeField.Equals(value) != true)) {
                    this.BookingMaxWaitTimeField = value;
                    this.RaisePropertyChanged("BookingMaxWaitTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public long LostItemEnabled {
            get {
                return this.LostItemEnabledField;
            }
            set {
                if ((this.LostItemEnabledField.Equals(value) != true)) {
                    this.LostItemEnabledField = value;
                    this.RaisePropertyChanged("LostItemEnabled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public long LostItemTime {
            get {
                return this.LostItemTimeField;
            }
            set {
                if ((this.LostItemTimeField.Equals(value) != true)) {
                    this.LostItemTimeField = value;
                    this.RaisePropertyChanged("LostItemTime");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:kemas", ConfigurationName="KEMASWSIF_CONFIGRef.WSKemasPortType")]
    public interface WSKemasPortType {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://kemas.de/vwnms/config) of message getSystemConfigurationRequest does not match the default value (urn:kemas)
        [System.ServiceModel.OperationContractAttribute(Action="getSystemConfiguration", ReplyAction="*")]
        CF.VRent.Entities.KEMASWSIF_CONFIGRef.getSystemConfigurationResponse getSystemConfiguration(CF.VRent.Entities.KEMASWSIF_CONFIGRef.getSystemConfigurationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getSystemConfiguration", WrapperNamespace="http://kemas.de/vwnms/config", IsWrapped=true)]
    public partial class getSystemConfigurationRequest {
        
        public getSystemConfigurationRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getSystemConfigurationResponse", WrapperNamespace="http://kemas.de/vwnms/config", IsWrapped=true)]
    public partial class getSystemConfigurationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.ConfigModel parameters;
        
        public getSystemConfigurationResponse() {
        }
        
        public getSystemConfigurationResponse(CF.VRent.Entities.KEMASWSIF_CONFIGRef.ConfigModel parameters) {
            this.parameters = parameters;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSKemasPortTypeChannel : CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSKemasPortTypeClient : System.ServiceModel.ClientBase<CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType>, CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType {
        
        public WSKemasPortTypeClient() {
        }
        
        public WSKemasPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSKemasPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSKemasPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSKemasPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CF.VRent.Entities.KEMASWSIF_CONFIGRef.getSystemConfigurationResponse CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType.getSystemConfiguration(CF.VRent.Entities.KEMASWSIF_CONFIGRef.getSystemConfigurationRequest request) {
            return base.Channel.getSystemConfiguration(request);
        }
        
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.ConfigModel getSystemConfiguration() {
            CF.VRent.Entities.KEMASWSIF_CONFIGRef.getSystemConfigurationRequest inValue = new CF.VRent.Entities.KEMASWSIF_CONFIGRef.getSystemConfigurationRequest();
            CF.VRent.Entities.KEMASWSIF_CONFIGRef.getSystemConfigurationResponse retVal = ((CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType)(this)).getSystemConfiguration(inValue);
            return retVal.parameters;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:kemas", ConfigurationName="KEMASWSIF_CONFIGRef.WSKemasPortType2")]
    public interface WSKemasPortType2 {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://kemas.de/vwnms/config2) of message getClientsRequest does not match the default value (urn:kemas)
        [System.ServiceModel.OperationContractAttribute(Action="getClients", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsResponse1 getClients(CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://kemas.de/vwnms/config2) of message getCitiesRequest does not match the default value (urn:kemas)
        [System.ServiceModel.OperationContractAttribute(Action="getCities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesResponse1 getCities(CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://kemas.de/vwnms/config2) of message updateClientRequest does not match the default value (urn:kemas)
        [System.ServiceModel.OperationContractAttribute(Action="updateClient", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientResponse1 updateClient(CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:kemas")]
    public partial class getClientsResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Error errorField;
        
        private Client[] clientsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Error Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
                this.RaisePropertyChanged("Error");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Clients", Order=1)]
        public Client[] Clients {
            get {
                return this.clientsField;
            }
            set {
                this.clientsField = value;
                this.RaisePropertyChanged("Clients");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:kemas")]
    public partial class Error : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string errorCodeField;
        
        private string errorMessageField;
        
        private string errorJSONField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ErrorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("ErrorCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ErrorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
                this.RaisePropertyChanged("ErrorMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ErrorJSON {
            get {
                return this.errorJSONField;
            }
            set {
                this.errorJSONField = value;
                this.RaisePropertyChanged("ErrorJSON");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:kemas")]
    public partial class updateClientResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Error errorField;
        
        private Client clientField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Error Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
                this.RaisePropertyChanged("Error");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Client Client {
            get {
                return this.clientField;
            }
            set {
                this.clientField = value;
                this.RaisePropertyChanged("Client");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:kemas")]
    public partial class Client : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private int enabledField;
        
        private string numberField;
        
        private string nameField;
        
        private string commentField;
        
        private string contactPersonField;
        
        private string addressField;
        
        private string contactInfoField;
        
        private int countEmployeesField;
        
        private int depositField;
        
        private string bankAccountInfoField;
        
        private string businessLicenseIDField;
        
        private string orgCodeCertificateField;
        
        private string legalRepresentativeIDField;
        
        private string mailField;
        
        private string statusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("Enabled");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
                this.RaisePropertyChanged("Number");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
                this.RaisePropertyChanged("Comment");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ContactPerson {
            get {
                return this.contactPersonField;
            }
            set {
                this.contactPersonField = value;
                this.RaisePropertyChanged("ContactPerson");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string ContactInfo {
            get {
                return this.contactInfoField;
            }
            set {
                this.contactInfoField = value;
                this.RaisePropertyChanged("ContactInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int CountEmployees {
            get {
                return this.countEmployeesField;
            }
            set {
                this.countEmployeesField = value;
                this.RaisePropertyChanged("CountEmployees");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int Deposit {
            get {
                return this.depositField;
            }
            set {
                this.depositField = value;
                this.RaisePropertyChanged("Deposit");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string BankAccountInfo {
            get {
                return this.bankAccountInfoField;
            }
            set {
                this.bankAccountInfoField = value;
                this.RaisePropertyChanged("BankAccountInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string BusinessLicenseID {
            get {
                return this.businessLicenseIDField;
            }
            set {
                this.businessLicenseIDField = value;
                this.RaisePropertyChanged("BusinessLicenseID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string OrgCodeCertificate {
            get {
                return this.orgCodeCertificateField;
            }
            set {
                this.orgCodeCertificateField = value;
                this.RaisePropertyChanged("OrgCodeCertificate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string LegalRepresentativeID {
            get {
                return this.legalRepresentativeIDField;
            }
            set {
                this.legalRepresentativeIDField = value;
                this.RaisePropertyChanged("LegalRepresentativeID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string Mail {
            get {
                return this.mailField;
            }
            set {
                this.mailField = value;
                this.RaisePropertyChanged("Mail");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:kemas")]
    public partial class updateClientRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sessionIDField;
        
        private Client clientField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SessionID {
            get {
                return this.sessionIDField;
            }
            set {
                this.sessionIDField = value;
                this.RaisePropertyChanged("SessionID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Client Client {
            get {
                return this.clientField;
            }
            set {
                this.clientField = value;
                this.RaisePropertyChanged("Client");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:kemas")]
    public partial class City : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:kemas")]
    public partial class getCitiesResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Error errorField;
        
        private City[] citiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Error Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
                this.RaisePropertyChanged("Error");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cities", Order=1)]
        public City[] Cities {
            get {
                return this.citiesField;
            }
            set {
                this.citiesField = value;
                this.RaisePropertyChanged("Cities");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getClients", WrapperNamespace="http://kemas.de/vwnms/config2", IsWrapped=true)]
    public partial class getClientsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string SessionID;
        
        public getClientsRequest() {
        }
        
        public getClientsRequest(string SessionID) {
            this.SessionID = SessionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getClientsResponse", WrapperNamespace="http://kemas.de/vwnms/config2", IsWrapped=true)]
    public partial class getClientsResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsResponse getClientsResponse;
        
        public getClientsResponse1() {
        }
        
        public getClientsResponse1(CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsResponse getClientsResponse) {
            this.getClientsResponse = getClientsResponse;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCities", WrapperNamespace="http://kemas.de/vwnms/config2", IsWrapped=true)]
    public partial class getCitiesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string SessionID;
        
        public getCitiesRequest() {
        }
        
        public getCitiesRequest(string SessionID) {
            this.SessionID = SessionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCitiesResponse", WrapperNamespace="http://kemas.de/vwnms/config2", IsWrapped=true)]
    public partial class getCitiesResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesResponse getCitiesResponse;
        
        public getCitiesResponse1() {
        }
        
        public getCitiesResponse1(CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesResponse getCitiesResponse) {
            this.getCitiesResponse = getCitiesResponse;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateClient", WrapperNamespace="http://kemas.de/vwnms/config2", IsWrapped=true)]
    public partial class updateClientRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientRequest updateClientRequest;
        
        public updateClientRequest1() {
        }
        
        public updateClientRequest1(CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientRequest updateClientRequest) {
            this.updateClientRequest = updateClientRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateClientResponse", WrapperNamespace="http://kemas.de/vwnms/config2", IsWrapped=true)]
    public partial class updateClientResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientResponse updateClientResponse;
        
        public updateClientResponse1() {
        }
        
        public updateClientResponse1(CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientResponse updateClientResponse) {
            this.updateClientResponse = updateClientResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSKemasPortType2Channel : CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSKemasPortType2Client : System.ServiceModel.ClientBase<CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2>, CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2 {
        
        public WSKemasPortType2Client() {
        }
        
        public WSKemasPortType2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSKemasPortType2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSKemasPortType2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSKemasPortType2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsResponse1 CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2.getClients(CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsRequest request) {
            return base.Channel.getClients(request);
        }
        
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsResponse getClients(string SessionID) {
            CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsRequest inValue = new CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsRequest();
            inValue.SessionID = SessionID;
            CF.VRent.Entities.KEMASWSIF_CONFIGRef.getClientsResponse1 retVal = ((CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2)(this)).getClients(inValue);
            return retVal.getClientsResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesResponse1 CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2.getCities(CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesRequest request) {
            return base.Channel.getCities(request);
        }
        
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesResponse getCities(string SessionID) {
            CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesRequest inValue = new CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesRequest();
            inValue.SessionID = SessionID;
            CF.VRent.Entities.KEMASWSIF_CONFIGRef.getCitiesResponse1 retVal = ((CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2)(this)).getCities(inValue);
            return retVal.getCitiesResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientResponse1 CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2.updateClient(CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientRequest1 request) {
            return base.Channel.updateClient(request);
        }
        
        public CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientResponse updateClient(CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientRequest updateClientRequest) {
            CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientRequest1 inValue = new CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientRequest1();
            inValue.updateClientRequest = updateClientRequest;
            CF.VRent.Entities.KEMASWSIF_CONFIGRef.updateClientResponse1 retVal = ((CF.VRent.Entities.KEMASWSIF_CONFIGRef.WSKemasPortType2)(this)).updateClient(inValue);
            return retVal.updateClientResponse;
        }
    }
}
