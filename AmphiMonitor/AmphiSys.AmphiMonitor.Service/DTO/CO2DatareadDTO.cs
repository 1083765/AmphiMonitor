namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class CO2DatareadDTO : MonitorDataDatareadDTO
    {
        public double Concentration { get; set; }

        // Constuct a CO2DatareadDTO object
        /// <summary>
        /// Constuct a CO2DatareadDTO object
        /// </summary>
        public CO2DatareadDTO()
        {
        }

        // Constuct a CO2DatareadDTO object
        /// <summary>
        /// Constuct a CO2DatareadDTO object
        /// </summary>
        /// <param name="concentration">Concentration
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public CO2DatareadDTO(double concentration, DateTime timeOfDataCreation)
        {
            Concentration = concentration;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}