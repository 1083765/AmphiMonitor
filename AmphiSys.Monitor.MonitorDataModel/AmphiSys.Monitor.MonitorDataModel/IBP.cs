using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public class IBP : MonitorData
    {
        [DataMember]
        public int Systolic { get; set; }
        [DataMember]
        public int Diastolic { get; set; }
        [DataMember]
        public int MeanArterialPressure { get; set; }

        // Constuct a IBP object.
        /// <summary>
        /// Constuct a empty IBP object.
        /// </summary>
        public IBP()
        {
        }

        // Constuct a IBP object.
        /// <summary>
        /// Constuct a IBP object.
        /// </summary>
        /// <param name="systolic">Systolic bloodpressure</param>
        /// <param name="diastolic">Diastolic bloodpressure</param>
        /// <param name="meanArterialPressure">Mean Arterial pressure</param>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public IBP(int systolic, int diastolic, int meanArterialPressure, DateTime timeOfDataCreation)
        {
            Systolic = systolic;
            Diastolic = diastolic;
            MeanArterialPressure = meanArterialPressure;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}