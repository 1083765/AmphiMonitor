using AmphiSys.AmphiMonitor.Service.DTO;
using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class SpO2DatareadDTOConvert
    {

        // Returns a SpO2DatareadDTO
        /// <summary>
        /// Returns a SpO2DatareadDTO from SpO2 monitor data
        /// </summary>
        /// <returns>
        /// A SpO2DatareadDTO
        /// </returns>
        /// <param name="spO2ToConvert">SpO2 to convert
        /// </param>
        public static SpO2DatareadDTO FromSpO2(SpO2 spO2ToConvert)
        {
            SpO2DatareadDTO spO2DatareadDTOToReturn = new SpO2DatareadDTO();
            if (spO2ToConvert != null)
            {
                spO2DatareadDTOToReturn = new SpO2DatareadDTO(spO2ToConvert.Saturation, spO2ToConvert.TimeOfDataCreation);
            }
            return spO2DatareadDTOToReturn;
        }
    }
}