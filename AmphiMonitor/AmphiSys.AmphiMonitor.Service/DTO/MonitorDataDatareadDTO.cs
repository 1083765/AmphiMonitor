namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public abstract class MonitorDataDatareadDTO
    {
        public DateTime TimeOfDataCreation { get; set; }

        // Constuct a MonitorDataDatareadDTO object
        /// <summary>
        /// Constuct a MonitorDataDatareadDTO object
        /// </summary>
        public MonitorDataDatareadDTO()
        {
        }

        // Constuct a MonitorDataDatareadDTO object
        /// <summary>
        /// Constuct a MonitorDataDatareadDTO object
        /// </summary>
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public MonitorDataDatareadDTO(DateTime timeOfDataCreation)
        {
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}