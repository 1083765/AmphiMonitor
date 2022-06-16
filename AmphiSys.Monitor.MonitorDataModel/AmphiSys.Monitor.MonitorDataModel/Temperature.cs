using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public class Temperature : MonitorData
    {
        [DataMember]
        public double Degrees { get; set; }


        // Constuct a Temperature object.
        /// <summary>
        /// Constuct a empty Temperature object.
        /// </summary>
        public Temperature()
        {
        }

        // Constuct a Temperature object.
        /// <summary>
        /// Constuct a Temperature object.
        /// </summary>
        /// <param name="degrees">Body temperature in degrees celsius</param>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public Temperature(double degrees, DateTime timeOfDataCreation)
        {
            Degrees = degrees;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}