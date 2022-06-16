namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class TemperatureDatareadDTO : MonitorDataDatareadDTO
    {
        public double Degrees { get; set; }

        // Constuct a TemperatureDatareadDTO object
        /// <summary>
        /// Constuct a TemperatureDatareadDTO object
        /// </summary>
        public TemperatureDatareadDTO()
        {
        }

        // Constuct a TemperatureDatareadDTO object
        /// <summary>
        /// Constuct a TemperatureDatareadDTO object
        /// </summary>
        /// <param name="degrees">Degrees
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public TemperatureDatareadDTO(double degrees, DateTime timeOfDataCreation)
        {
            Degrees = degrees;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}