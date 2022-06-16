namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class SpO2DatareadDTO : MonitorDataDatareadDTO
    {
        public int Saturation { get; set; }

        // Constuct a SpO2DatareadDTO object
        /// <summary>
        /// Constuct a SpO2DatareadDTO object
        /// </summary>
        public SpO2DatareadDTO()
        {
        }

        // Constuct a SpO2DatareadDTO object
        /// <summary>
        /// Constuct a SpO2DatareadDTO object
        /// </summary>
        /// <param name="saturation">Saturation
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public SpO2DatareadDTO(int saturation, DateTime timeOfDataCreation)
        {
            Saturation = saturation;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}