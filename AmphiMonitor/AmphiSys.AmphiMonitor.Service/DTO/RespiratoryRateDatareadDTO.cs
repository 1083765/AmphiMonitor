namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class RespiratoryRateDatareadDTO : MonitorDataDatareadDTO
    {
        public int BreathsPerMinute { get; set; }

        // Constuct a RespiratoryRateDatareadDTO object
        /// <summary>
        /// Constuct a RespiratoryRateDatareadDTO object
        /// </summary>
        public RespiratoryRateDatareadDTO()
        {
        }

        // Constuct a RespiratoryRateDatareadDTO object
        /// <summary>
        /// Constuct a RespiratoryRateDatareadDTO object
        /// </summary>
        /// <param name="breathsPerMinute">Breaths per minute
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public RespiratoryRateDatareadDTO(int breathsPerMinute, DateTime timeOfDataCreation)
        {
            BreathsPerMinute = breathsPerMinute;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}