using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public class CO2 : MonitorData
    {
        [DataMember]
        public int Concentration { get; set; }

        // Constuct a CO2 object.
        /// <summary>
        /// Constuct a empty CO2 object.
        /// </summary>
        public CO2()
        {
        }

        // Constuct a CO2 object.
        /// <summary>
        /// Constuct a CO2 object.
        /// </summary>
        /// <param name="concentration">Concentration of CO2</param>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public CO2(int concentration, DateTime timeOfDataCreation)
        {
            Concentration = concentration;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}