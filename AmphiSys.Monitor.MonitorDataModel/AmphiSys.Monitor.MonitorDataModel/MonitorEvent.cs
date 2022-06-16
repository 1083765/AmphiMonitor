using System;
using System.Runtime.Serialization;

namespace AmphiSys.Monitor.MonitorDataModel
{
    [DataContract]
    public class MonitorEvent : MonitorData
    {
        // Constuct a MonitorEvent object.
        /// <summary>
        /// Constuct a MonitorEvent object.
        /// </summary>
        public MonitorEvent()
        {
        }

        // Constuct a MonitorEvent object.
        /// <summary>
        /// Constuct a MonitorEvent object.
        /// </summary>
        /// <param name="timeOfDataCreation">Time of creation</param>
        public MonitorEvent(DateTime timeOfDataCreation)
        {
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}