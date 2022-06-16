using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.AmphiMonitor.Service.BusinessLogic
{
    public interface IMonitorDataLogic
    {
        // Gets a list of monitor data.
        /// <summary>
        /// Gets a list of monitor data from monitor data container.
        /// </summary>
        /// <returns>
        /// A list of monitor data.
        /// </returns> 
        List<MonitorData> GetMonitorData();

        // Gets a HeartRate object.
        /// <summary>
        /// Gets a HeartRate object from monitor data container.
        /// </summary>
        /// <returns>
        /// A HeartRate object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        HeartRate GenerateHeartRate(int patientType);

        // Gets a NIBP object.
        /// <summary>
        /// Gets a NIBP object from monitor data container.
        /// </summary>
        /// <returns>
        /// A NIBP object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        NIBP GenerateNIBP(int patientType);

        // Gets a IBP object.
        /// <summary>
        /// Gets a IBP object from monitor data container.
        /// </summary>
        /// <returns>
        /// A IBP object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        IBP GenerateIBP(int patientType);

        // Gets a SpO2 object.
        /// <summary>
        /// Gets a SpO2 object from monitor data container.
        /// </summary>
        /// <returns>
        /// A SpO2 object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        SpO2 GenerateSpO2(int patientType);

        // Gets a Pulse object.
        /// <summary>
        /// Gets a Pulse object from monitor data container.
        /// </summary>
        /// <returns>
        /// A Pulse object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        Pulse GeneratePulse(int patientType);

        // Gets a CO2 object.
        /// <summary>
        /// Gets a CO2 object from monitor data container.
        /// </summary>
        /// <returns>
        /// A CO2 object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        CO2 GenerateCO2(int patientType);

        // Gets a RespiratoryRate object.
        /// <summary>
        /// Gets a RespiratoryRate object from monitor data container.
        /// </summary>
        /// <returns>
        /// A RespiratoryRate object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        RespiratoryRate GenerateRespiratoryRate(int patientType);

        // Gets a Temperature object.
        /// <summary>
        /// Gets a Temperature object from monitor data container.
        /// </summary>
        /// <returns>
        /// A Temperature object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        Temperature GenerateTemperature(int patientType);

        // Gets a MonitorEvent object.
        /// <summary>
        /// Gets a MonitorEvent object from monitor data container.
        /// </summary>
        /// <returns>
        /// A MonitorEvent object.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        MonitorEvent GenerateMonitorEvent(int patientType);

    }
}