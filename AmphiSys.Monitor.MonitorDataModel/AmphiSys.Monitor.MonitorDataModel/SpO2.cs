using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public  class SpO2 : MonitorData
    {
        [DataMember]
        public int Saturation { get; set; }


        // Constuct a SpO2 object.
        /// <summary>
        /// Constuct a empty SpO2 object.
        /// </summary>
        public SpO2()
        {
        }

        // Constuct a SpO2 object.
        /// <summary>
        /// Constuct a SpO2 object.
        /// </summary>
        /// <param name="saturation">Oxygen saturation</param>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public SpO2(int saturation, DateTime timeOfDataCreation)
        {
            Saturation = saturation;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}