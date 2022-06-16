namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class IBPDatareadDTO : MonitorDataDatareadDTO
    {
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public int MeanArterialPressure { get; set; }

        // Constuct a IBPDatareadDTO object
        /// <summary>
        /// Constuct a IBPDatareadDTO object
        /// </summary>
        public IBPDatareadDTO()
        {
        }

        // Constuct a IBPDatareadDTO object
        /// <summary>
        /// Constuct a IBPDatareadDTO object
        /// </summary>
        /// <param name="systolic">Systolic
        /// <param name="diastolic">Diastolic
        /// <param name="meanArterialPressure">Mean arterial pressure
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public IBPDatareadDTO(int systolic, int diastolic, int meanArterialPressure, DateTime timeOfDataCreation)
        {
            Systolic = systolic;
            Diastolic = diastolic;
            MeanArterialPressure = meanArterialPressure;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}