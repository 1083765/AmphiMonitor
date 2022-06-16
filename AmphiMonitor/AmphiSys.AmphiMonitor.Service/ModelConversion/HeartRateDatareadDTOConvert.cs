using AmphiSys.Monitor.MonitorDataModel;
using AmphiSys.AmphiMonitor.Service.DTO;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class HeartRateDatareadDTOConvert
    {

        // Returns a HeartRateDatareadDTO
        /// <summary>
        /// Returns a HeartRateDatareadDTO from heart rate monitor data
        /// </summary>
        /// <returns>
        /// A HeartRateDatareadDTO
        /// </returns>
        /// <param name="heartRateToConvert">Heart rate to convert
        /// </param>
        public static HeartRateDatareadDTO FromHeartRate(HeartRate heartRateToConvert)
        {
            HeartRateDatareadDTO heartRateDatareadDTOToReturn = new HeartRateDatareadDTO();
            if (heartRateToConvert != null)
            {
                heartRateDatareadDTOToReturn = new HeartRateDatareadDTO(heartRateToConvert.BeatsPerMinute, heartRateToConvert.TimeOfDataCreation);
            }
            return heartRateDatareadDTOToReturn;
        }
    }
}