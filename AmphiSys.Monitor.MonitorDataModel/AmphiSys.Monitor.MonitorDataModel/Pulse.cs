using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public class Pulse : MonitorData
    {
        [DataMember]
        public int BeatsPerMinute { get; set; }

        // Constuct a Pulse object.
        /// <summary>
        /// Constuct a empty Pulse object.
        public Pulse()
        {
        }

        // Constuct a Pulse object.
        /// <summary>
        /// Constuct a Pulse object.
        /// </summary>
        /// <param name="beatsPerMinute">Beat per minute</param>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public Pulse(int beatsPerMinute, DateTime timeOfDataCreation)
        {
            BeatsPerMinute = beatsPerMinute;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}