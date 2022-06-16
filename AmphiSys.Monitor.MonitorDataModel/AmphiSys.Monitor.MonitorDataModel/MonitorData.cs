using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    [KnownType(typeof(CO2))]
    [KnownType(typeof(ECG))]
    [KnownType(typeof(HeartRate))]
    [KnownType(typeof(IBP))]
    [KnownType(typeof(NIBP))]
    [KnownType(typeof(Pulse))]
    [KnownType(typeof(RespiratoryRate))]
    [KnownType(typeof(SpO2))]
    [KnownType(typeof(Temperature))]
    [KnownType(typeof(MonitorEvent))]

    // Abstract MonitorData class.
    /// <summary>
    /// Restricted class that cannot be used to create objects.
    /// To access it, it must be inherited from another class.
    /// </summary>
    public abstract class MonitorData
    {
        [DataMember]
        public DateTime TimeOfDataCreation { get; set; }
    }
}