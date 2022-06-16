﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitorHostServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MonitorData", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.CO2))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.ECG))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.HeartRate))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.IBP))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.NIBP))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.Pulse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.RespiratoryRate))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.SpO2))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.Temperature))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MonitorHostServiceReference.MonitorEvent))]
    public partial class MonitorData : object
    {
        
        private System.DateTime TimeOfDataCreationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeOfDataCreation
        {
            get
            {
                return this.TimeOfDataCreationField;
            }
            set
            {
                this.TimeOfDataCreationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CO2", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class CO2 : MonitorHostServiceReference.MonitorData
    {
        
        private int ConcentrationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Concentration
        {
            get
            {
                return this.ConcentrationField;
            }
            set
            {
                this.ConcentrationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ECG", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class ECG : MonitorHostServiceReference.MonitorData
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HeartRate", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class HeartRate : MonitorHostServiceReference.MonitorData
    {
        
        private int BeatsPerMinuteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BeatsPerMinute
        {
            get
            {
                return this.BeatsPerMinuteField;
            }
            set
            {
                this.BeatsPerMinuteField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IBP", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class IBP : MonitorHostServiceReference.MonitorData
    {
        
        private int DiastolicField;
        
        private int MeanArterialPressureField;
        
        private int SystolicField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Diastolic
        {
            get
            {
                return this.DiastolicField;
            }
            set
            {
                this.DiastolicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MeanArterialPressure
        {
            get
            {
                return this.MeanArterialPressureField;
            }
            set
            {
                this.MeanArterialPressureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Systolic
        {
            get
            {
                return this.SystolicField;
            }
            set
            {
                this.SystolicField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NIBP", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class NIBP : MonitorHostServiceReference.MonitorData
    {
        
        private int DiastolicField;
        
        private int MeanArterialPressureField;
        
        private int SystolicField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Diastolic
        {
            get
            {
                return this.DiastolicField;
            }
            set
            {
                this.DiastolicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MeanArterialPressure
        {
            get
            {
                return this.MeanArterialPressureField;
            }
            set
            {
                this.MeanArterialPressureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Systolic
        {
            get
            {
                return this.SystolicField;
            }
            set
            {
                this.SystolicField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pulse", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class Pulse : MonitorHostServiceReference.MonitorData
    {
        
        private int BeatsPerMinuteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BeatsPerMinute
        {
            get
            {
                return this.BeatsPerMinuteField;
            }
            set
            {
                this.BeatsPerMinuteField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespiratoryRate", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class RespiratoryRate : MonitorHostServiceReference.MonitorData
    {
        
        private int BreathsPerMinuteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BreathsPerMinute
        {
            get
            {
                return this.BreathsPerMinuteField;
            }
            set
            {
                this.BreathsPerMinuteField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SpO2", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class SpO2 : MonitorHostServiceReference.MonitorData
    {
        
        private int SaturationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Saturation
        {
            get
            {
                return this.SaturationField;
            }
            set
            {
                this.SaturationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Temperature", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class Temperature : MonitorHostServiceReference.MonitorData
    {
        
        private double DegreesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Degrees
        {
            get
            {
                return this.DegreesField;
            }
            set
            {
                this.DegreesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MonitorEvent", Namespace="http://schemas.datacontract.org/2004/07/AmphiSys.Monitor.MonitorDataModel")]
    public partial class MonitorEvent : MonitorHostServiceReference.MonitorData
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="MonitorHostServiceReference.IMonitorAccess")]
    public interface IMonitorAccess
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IMonitorAccess/GetMonitorData", ReplyAction="http://Microsoft.ServiceModel.Samples/IMonitorAccess/GetMonitorDataResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AmphiSys.Monitor.MonitorDataModel.MonitorData>> GetMonitorDataAsync(int selectedMonitor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IMonitorAccess/DisconnectMonitor", ReplyAction="http://Microsoft.ServiceModel.Samples/IMonitorAccess/DisconnectMonitorResponse")]
        System.Threading.Tasks.Task DisconnectMonitorAsync(int selectedMonitor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IMonitorAccess/ConnectMonitor", ReplyAction="http://Microsoft.ServiceModel.Samples/IMonitorAccess/ConnectMonitorResponse")]
        System.Threading.Tasks.Task ConnectMonitorAsync(int selectedMonitor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IMonitorAccessChannel : MonitorHostServiceReference.IMonitorAccess, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class MonitorAccessClient : System.ServiceModel.ClientBase<MonitorHostServiceReference.IMonitorAccess>, MonitorHostServiceReference.IMonitorAccess
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MonitorAccessClient() : 
                base(MonitorAccessClient.GetDefaultBinding(), MonitorAccessClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMonitorAccess.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MonitorAccessClient(EndpointConfiguration endpointConfiguration) : 
                base(MonitorAccessClient.GetBindingForEndpoint(endpointConfiguration), MonitorAccessClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MonitorAccessClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MonitorAccessClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MonitorAccessClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MonitorAccessClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MonitorAccessClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AmphiSys.Monitor.MonitorDataModel.MonitorData>> GetMonitorDataAsync(int selectedMonitor)
        {
            return base.Channel.GetMonitorDataAsync(selectedMonitor);
        }
        
        public System.Threading.Tasks.Task DisconnectMonitorAsync(int selectedMonitor)
        {
            return base.Channel.DisconnectMonitorAsync(selectedMonitor);
        }
        
        public System.Threading.Tasks.Task ConnectMonitorAsync(int selectedMonitor)
        {
            return base.Channel.ConnectMonitorAsync(selectedMonitor);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMonitorAccess))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMonitorAccess))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/AmphiSys.Monitor.WCFService/MonitorAccess");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MonitorAccessClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMonitorAccess);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MonitorAccessClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMonitorAccess);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMonitorAccess,
        }
    }
}
