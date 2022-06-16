using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public class RespiratoryRate : MonitorData
    {
        [DataMember]
        public int BreathsPerMinute { get; set; }

        // Constuct a RespiratoryRate object.
        /// <summary>
        /// Constuct a empty RespiratoryRate object.
        /// </summary>
        public RespiratoryRate()
        {
        }

        // Constuct a RespiratoryRate object.
        /// <summary>
        /// Constuct a RespiratoryRate object.
        /// </summary>
        /// <param name="breathsPerMinute">Breaths per minute</param>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public RespiratoryRate(int breathsPerMinute, DateTime timeOfDataCreation)
        {
            BreathsPerMinute = breathsPerMinute;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}