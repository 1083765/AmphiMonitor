namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class HeartRateDatareadDTO : MonitorDataDatareadDTO
    {
        public int BeatsPerMinute { get; set; }

        // Constuct a HeartRateDatareadDTO object
        /// <summary>
        /// Constuct a HeartRateDatareadDTO object
        /// </summary>
        public HeartRateDatareadDTO()
        {
        }

        // Constuct a HeartRateDatareadDTO object
        /// <summary>
        /// Constuct a HeartRateDatareadDTO object
        /// </summary>
        /// <param name="beatsPerMinute">Beats per minute
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public HeartRateDatareadDTO(int beatsPerMinute, DateTime timeOfDataCreation)
        {
            BeatsPerMinute = beatsPerMinute;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}