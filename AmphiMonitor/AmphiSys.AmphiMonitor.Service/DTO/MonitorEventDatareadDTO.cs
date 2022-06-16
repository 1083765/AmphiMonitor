namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class MonitorEventDatareadDTO
    {
        public DateTime TimeOfDataCreation { get; set; }

        // Constuct a MonitorEventDatareadDTO object
        /// <summary>
        /// Constuct a MonitorEventDatareadDTO object
        /// </summary>
        public MonitorEventDatareadDTO()
        {
        }

        // Constuct a MonitorEventDatareadDTO object
        /// <summary>
        /// Constuct a MonitorEventDatareadDTO object
        /// </summary>
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public MonitorEventDatareadDTO(DateTime timeOfDataCreation)
        {
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}