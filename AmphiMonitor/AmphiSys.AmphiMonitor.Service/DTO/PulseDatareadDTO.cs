namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class PulseDatareadDTO : MonitorDataDatareadDTO
    {
        public int BeatsPerMinute { get; set; }

        // Constuct a PulseDatareadDTO object
        /// <summary>
        /// Constuct a PulseDatareadDTO object
        /// </summary>
        public PulseDatareadDTO()
        {
        }

        // Constuct a PulseDatareadDTO object
        /// <summary>
        /// Constuct a PulseDatareadDTO object
        /// </summary>
        /// <param name="beatsPerMinute">Beats per minute
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public PulseDatareadDTO(int beatsPerMinute, DateTime timeOfDataCreation)
        {
            BeatsPerMinute = beatsPerMinute;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}