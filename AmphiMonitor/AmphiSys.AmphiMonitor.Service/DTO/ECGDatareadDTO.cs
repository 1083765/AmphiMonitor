namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class ECGDatareadDTO : MonitorDataDatareadDTO
    {

        // Constuct a ECGDatareadDTO object
        /// <summary>
        /// Constuct a ECGDatareadDTO object
        /// </summary>
        public ECGDatareadDTO()
        {
        }

        // Constuct a ECGDatareadDTO object
        /// <summary>
        /// Constuct a ECGDatareadDTO object
        /// </summary>
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public ECGDatareadDTO(DateTime timeOfDataCreation)
        {
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}
