﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CF.VRent.Entities.KEMASWSIF_CATALOGRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Elements", Namespace="urn:kemas", ItemName="Elements")]
    [System.SerializableAttribute()]
    public class Elements : System.Collections.Generic.List<CF.VRent.Entities.KEMASWSIF_CATALOGRef.Element> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Element", Namespace="urn:kemas")]
    [System.SerializableAttribute()]
    public partial class Element : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string keyField;
        
        private string valueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string key {
            get {
                return this.keyField;
            }
            set {
                if ((object.ReferenceEquals(this.keyField, value) != true)) {
                    this.keyField = value;
                    this.RaisePropertyChanged("key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                if ((object.ReferenceEquals(this.valueField, value) != true)) {
                    this.valueField = value;
                    this.RaisePropertyChanged("value");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:kemas", ConfigurationName="KEMASWSIF_CATALOGRef.WSKemasPortType")]
    public interface WSKemasPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="getCategory", ReplyAction="*")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Categories")]
        CF.VRent.Entities.KEMASWSIF_CATALOGRef.Elements getCategory();
        
        [System.ServiceModel.OperationContractAttribute(Action="getTypeOfJourney", ReplyAction="*")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Types")]
        CF.VRent.Entities.KEMASWSIF_CATALOGRef.Elements getTypeOfJourney(string Language);
        
        [System.ServiceModel.OperationContractAttribute(Action="getUserTypeOfJourney", ReplyAction="*")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Types")]
        CF.VRent.Entities.KEMASWSIF_CATALOGRef.Elements getUserTypeOfJourney(string UserID, string Lang);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSKemasPortTypeChannel : CF.VRent.Entities.KEMASWSIF_CATALOGRef.WSKemasPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSKemasPortTypeClient : System.ServiceModel.ClientBase<CF.VRent.Entities.KEMASWSIF_CATALOGRef.WSKemasPortType>, CF.VRent.Entities.KEMASWSIF_CATALOGRef.WSKemasPortType {
        
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
        
        public CF.VRent.Entities.KEMASWSIF_CATALOGRef.Elements getCategory() {
            return base.Channel.getCategory();
        }
        
        public CF.VRent.Entities.KEMASWSIF_CATALOGRef.Elements getTypeOfJourney(string Language) {
            return base.Channel.getTypeOfJourney(Language);
        }
        
        public CF.VRent.Entities.KEMASWSIF_CATALOGRef.Elements getUserTypeOfJourney(string UserID, string Lang) {
            return base.Channel.getUserTypeOfJourney(UserID, Lang);
        }
    }
}
