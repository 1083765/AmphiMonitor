using AmphiSys.Monitor.MonitorDataModel;
using System.Collections.Generic;

namespace AmphiSys.AmphiMonitor.Model
{
    public class MonitorDataContainer
    {
        private static MonitorDataContainer _instance;
        public ECG ECG { get; set; }
        public HeartRate HeartRate { get; set; }
        public NIBP NIBP { get; set; }
        public IBP IBP { get; set; }
        public SpO2 SpO2 { get; set; }
        public Pulse Pulse { get; set; }
        public CO2 CO2 { get; set; }
        public RespiratoryRate RespiratoryRate { get; set; }
        public Temperature Temperature { get; set; }
        public List<MonitorEvent> MonitorEvents { get; set; }

        // Constuct a MonitorDataContainer object.
        /// <summary>
        /// Constuct a MonitorDataContainer object.
        /// </summary>
        private MonitorDataContainer()
        {
            MonitorEvents = new List<MonitorEvent>();
        }

        // Get instance of static container.
        /// <summary>
        /// Get instance of static container if not null or create new container.
        /// </summary>
        /// <returns>
        /// MonitorDataContainer object.
        /// </returns>
        public static MonitorDataContainer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MonitorDataContainer();
            }
            return _instance;
        }

        // Add and return monitor data.
        /// <summary>
        /// Add and return a list of monitor data.
        /// </summary>
        /// <returns>
        /// List of MonitorData object.
        /// </returns>
        public List<MonitorData> GetMonitorData()
        {
            List<MonitorData> monitorData = new List<MonitorData>();

            if (HeartRate != null)
            {
                monitorData.Add(HeartRate);
                HeartRate = null;
            }
            if (NIBP != null)
            {
                monitorData.Add(NIBP);
                NIBP = null;
            }
            if (IBP != null)
            {
                monitorData.Add(IBP);
                IBP = null;
            }
            if (SpO2 != null)
            {
                monitorData.Add(SpO2);
                SpO2 = null;
            }
            if (Pulse != null)
            {
                monitorData.Add(Pulse);
                Pulse = null;
            }
            if (CO2 != null)
            {
                monitorData.Add(CO2);
                CO2 = null;
            }
            if (Temperature != null)
            {
                monitorData.Add(Temperature);
                Temperature = null;
            }
            if (MonitorEvents != null)
            {
                foreach (MonitorEvent monitorEvent in MonitorEvents)
                {
                    monitorData.Add(monitorEvent);
                }
                MonitorEvents.Clear();
            }
            return monitorData;
        }
    }
}