using AmphiSys.AmphiMonitor.Service.DTO;
using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class RespiratoryRateDatareadDTOConvert
    {

        // Returns a RespiratoryRateDatareadDTO
        /// <summary>
        /// Returns a RespiratoryRateDatareadDTO from respiratory rate monitor data
        /// </summary>
        /// <returns>
        /// A RespiratoryRateDatareadDTO
        /// </returns>
        /// <param name="respiratoryRateToConvert">Respiratory rate to convert
        /// </param>
        public static RespiratoryRateDatareadDTO FromRespiratoryRate(RespiratoryRate respiratoryRateToConvert)
        {
            RespiratoryRateDatareadDTO respiratoryRateDatareadDTOToReturn = new RespiratoryRateDatareadDTO();
            if (respiratoryRateToConvert != null)
            {
                respiratoryRateDatareadDTOToReturn = new RespiratoryRateDatareadDTO(respiratoryRateToConvert.BreathsPerMinute, respiratoryRateToConvert.TimeOfDataCreation);
            }
            return respiratoryRateDatareadDTOToReturn;
        }
    }
}