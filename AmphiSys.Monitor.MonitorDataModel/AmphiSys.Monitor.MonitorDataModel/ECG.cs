using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public class ECG : MonitorData
    {

        // Constuct a ECG object.
        /// <summary>
        /// Constuct a empty ECG object.
        /// </summary>
        public ECG()
        {
        }

        // Constuct a ECG object.
        /// <summary>
        /// Constuct a ECG object.
        /// </summary>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public ECG(DateTime timeOfDataCreation)
        {
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}