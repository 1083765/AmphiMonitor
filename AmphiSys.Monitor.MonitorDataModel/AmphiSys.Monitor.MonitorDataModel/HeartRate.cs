using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public class HeartRate : MonitorData
    {
        [DataMember]
        public int BeatsPerMinute { get; set; }

        // Constuct a HeartRate object.
        /// <summary>
        /// Constuct a empty HeartRate object.
        /// </summary>
        public HeartRate()
        {
        }

        // Constuct a HeartRate object.
        /// <summary>
        /// Constuct a HeartRate object.
        /// </summary>
        /// <param name="beatsPerMinute">Beats per minute</param>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public HeartRate(int beatsPerMinute, DateTime timeOfDataCreation)
        {
            BeatsPerMinute = beatsPerMinute;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}