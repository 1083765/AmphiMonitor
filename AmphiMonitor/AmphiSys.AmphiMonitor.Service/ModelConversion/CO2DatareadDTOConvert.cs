using AmphiSys.Monitor.MonitorDataModel;
using AmphiSys.AmphiMonitor.Service.DTO;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class CO2DatareadDTOConvert
    {

        // Returns a CO2DatareadDTO
        /// <summary>
        /// Returns a CO2DatareadDTO from CO2 monitor data
        /// </summary>
        /// <returns>
        /// A CO2DatareadDTO
        /// </returns>
        /// <param name="cO2ToConvert">CO2 to convert
        /// </param>
        public static CO2DatareadDTO FromCO2(CO2 cO2ToConvert)
        {
            CO2DatareadDTO cO2DatareadDTOToReturn = new CO2DatareadDTO();
            if (cO2ToConvert != null)
            {
                cO2DatareadDTOToReturn = new CO2DatareadDTO(cO2ToConvert.Concentration, cO2ToConvert.TimeOfDataCreation);
            }
            return cO2DatareadDTOToReturn;
        }
    }
}