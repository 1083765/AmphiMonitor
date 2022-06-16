namespace AmphiSys.AmphiMonitor.Service.DTO
{
    public class NIBPDatareadDTO : MonitorDataDatareadDTO
    {
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public int MeanArterialPressure { get; set; }

        // Constuct a NIBPDatareadDTO object
        /// <summary>
        /// Constuct a NIBPDatareadDTO object
        /// </summary>
        public NIBPDatareadDTO()
        {
        }

        // Constuct a NIBPDatareadDTO object
        /// <summary>
        /// Constuct a NIBPDatareadDTO object
        /// </summary>
        /// <param name="systolic">Systolic
        /// <param name="diastolic">Diastolic
        /// <param name="meanArterialPressure">Mean arterial pressure
        /// <param name="timeOfDataCreation">Time of data creation
        /// </param>
        public NIBPDatareadDTO(int systolic, int diastolic, int meanArterialPressure, DateTime timeOfDataCreation)
        {
            Systolic = systolic;
            Diastolic = diastolic;
            MeanArterialPressure = meanArterialPressure;
            TimeOfDataCreation = timeOfDataCreation;
        }
    }
}