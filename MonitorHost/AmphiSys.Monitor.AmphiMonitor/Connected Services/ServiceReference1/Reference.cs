//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmphiSys.Monitor.Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.AmphiMonitor.WCFService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Measurement", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.AmphiMonitor.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(AmphiSys.Monitor.Client.ServiceReference1.NIBP))]
    public partial class Measurement : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeOfMeasuremtField;
        
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
        public System.DateTime TimeOfMeasuremt {
            get {
                return this.TimeOfMeasuremtField;
            }
            set {
                if ((this.TimeOfMeasuremtField.Equals(value) != true)) {
                    this.TimeOfMeasuremtField = value;
                    this.RaisePropertyChanged("TimeOfMeasuremt");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NIBP", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.AmphiMonitor.Model")]
    [System.SerializableAttribute()]
    public partial class NIBP : AmphiSys.Monitor.Client.ServiceReference1.Measurement {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DiastolicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MeanArterialPressureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SystolicField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Diastolic {
            get {
                return this.DiastolicField;
            }
            set {
                if ((this.DiastolicField.Equals(value) != true)) {
                    this.DiastolicField = value;
                    this.RaisePropertyChanged("Diastolic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MeanArterialPressure {
            get {
                return this.MeanArterialPressureField;
            }
            set {
                if ((this.MeanArterialPressureField.Equals(value) != true)) {
                    this.MeanArterialPressureField = value;
                    this.RaisePropertyChanged("MeanArterialPressure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Systolic {
            get {
                return this.SystolicField;
            }
            set {
                if ((this.SystolicField.Equals(value) != true)) {
                    this.SystolicField = value;
                    this.RaisePropertyChanged("Systolic");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.Servicemodel.Samples", ConfigurationName="ServiceReference1.IAmphiMonitorAccess")]
    public interface IAmphiMonitorAccess {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetData", ReplyAction="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetData", ReplyAction="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetDataUsingDataContrac" +
            "t", ReplyAction="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetDataUsingDataContrac" +
            "tResponse")]
        AmphiSys.Monitor.Client.ServiceReference1.CompositeType GetDataUsingDataContract(AmphiSys.Monitor.Client.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetDataUsingDataContrac" +
            "t", ReplyAction="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetDataUsingDataContrac" +
            "tResponse")]
        System.Threading.Tasks.Task<AmphiSys.Monitor.Client.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(AmphiSys.Monitor.Client.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetNIBP", ReplyAction="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetNIBPResponse")]
        AmphiSys.Monitor.Client.ServiceReference1.NIBP GetNIBP();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetNIBP", ReplyAction="http://Microsoft.Servicemodel.Samples/IAmphiMonitorAccess/GetNIBPResponse")]
        System.Threading.Tasks.Task<AmphiSys.Monitor.Client.ServiceReference1.NIBP> GetNIBPAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAmphiMonitorAccessChannel : AmphiSys.Monitor.Client.ServiceReference1.IAmphiMonitorAccess, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AmphiMonitorAccessClient : System.ServiceModel.ClientBase<AmphiSys.Monitor.Client.ServiceReference1.IAmphiMonitorAccess>, AmphiSys.Monitor.Client.ServiceReference1.IAmphiMonitorAccess {
        
        public AmphiMonitorAccessClient() {
        }
        
        public AmphiMonitorAccessClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AmphiMonitorAccessClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AmphiMonitorAccessClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AmphiMonitorAccessClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public AmphiSys.Monitor.Client.ServiceReference1.CompositeType GetDataUsingDataContract(AmphiSys.Monitor.Client.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<AmphiSys.Monitor.Client.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(AmphiSys.Monitor.Client.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public AmphiSys.Monitor.Client.ServiceReference1.NIBP GetNIBP() {
            return base.Channel.GetNIBP();
        }
        
        public System.Threading.Tasks.Task<AmphiSys.Monitor.Client.ServiceReference1.NIBP> GetNIBPAsync() {
            return base.Channel.GetNIBPAsync();
        }
    }
}
