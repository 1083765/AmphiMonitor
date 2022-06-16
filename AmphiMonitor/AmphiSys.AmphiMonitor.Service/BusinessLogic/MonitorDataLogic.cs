using AmphiSys.Monitor.MonitorDataModel;
using AmphiSys.AmphiMonitor.Model;

namespace AmphiSys.AmphiMonitor.Service.BusinessLogic
{
    public class MonitorDataLogic : IMonitorDataLogic
    {
        MonitorDataGenerator _monitorDataGenerator;
        MonitorDataContainer _monitorDataContainer;

        // Constuct a MonitorDataLogic object.
        /// <summary>
        /// Constuct a MonitorDataLogic object and get a instance of MonitorDataContainer
        /// and create a MonitorDataGenerator.
        /// </summary>
        public MonitorDataLogic()
        {
            _monitorDataGenerator = new MonitorDataGenerator();
            _monitorDataContainer = MonitorDataContainer.GetInstance();
        }

        // Gets a list of monitor data.
        /// <inheritdoc/> 
        public List<MonitorData> GetMonitorData()
        {
            List<MonitorData> monitorData = new List<MonitorData>();

            monitorData = _monitorDataContainer.GetMonitorData();

            return monitorData;
        }

        // Gets a heart rate object.
        /// <inheritdoc/>
        public HeartRate GenerateHeartRate(int patientType)
        {
            HeartRate heartRate = new HeartRate();

            heartRate = _monitorDataGenerator.GenerateHeartRate(patientType);

            return heartRate;
        }

        // Gets a NIBP object.
        /// <inheritdoc/>
        public NIBP GenerateNIBP(int patientType)
        {
            NIBP nIBP = new NIBP();

            nIBP = _monitorDataGenerator.GenerateNIBP(patientType);

            return nIBP;
        }

        // Gets a IBP object.
        /// <inheritdoc/>
        public IBP GenerateIBP(int patientType)
        {
            IBP iBP = new IBP();

            iBP = _monitorDataGenerator.GenerateIBP(patientType);

            return iBP;
        }

        // Gets a SpO2 object.
        /// <inheritdoc/>
        public SpO2 GenerateSpO2(int patientType)
        {
            SpO2 spO2 = new SpO2();

            spO2 = _monitorDataGenerator.GenerateSpO2(patientType);

            return spO2;
        }

        // Gets a Pulse object.
        /// <inheritdoc/>
        public Pulse GeneratePulse(int patientType)
        {
            Pulse pulse = new Pulse();

            pulse = _monitorDataGenerator.GeneratePulse(patientType);

            return pulse;
        }

        // Gets a CO2 object.
        /// <inheritdoc/>
        public CO2 GenerateCO2(int patientType)
        {
            CO2 cO2 = new CO2();

            cO2 = _monitorDataGenerator.GenerateCO2(patientType);

            return cO2;
        }

        // Gets a RespiratoryRate object.
        /// <inheritdoc/>
        public RespiratoryRate GenerateRespiratoryRate(int patientType)
        {
            RespiratoryRate respiratoryRate = new RespiratoryRate();

            respiratoryRate = _monitorDataGenerator.GenerateRespiratoryRate(patientType);

            return respiratoryRate;
        }

        // Gets a Temperature object.
        /// <inheritdoc/>
        public Temperature GenerateTemperature(int patientType)
        {
            Temperature temperature = new Temperature();

            temperature = _monitorDataGenerator.GenerateTemperature(patientType);

            return temperature;
        }

        // Gets a MonitorEvent object.
        /// <inheritdoc/>
        public MonitorEvent GenerateMonitorEvent(int patientType)
        {
            MonitorEvent monitorEvent = new MonitorEvent();

            monitorEvent = _monitorDataGenerator.GenerateMonitorEvent();

            return monitorEvent;
        }
    }
}
