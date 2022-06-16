using AmphiSys.Monitor.MonitorDataModel;
using AmphiSys.AmphiMonitor.Service.DTO;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class NIBPDatareadDTOConvert
    {

        // Returns an NIBPDatareadDTO
        /// <summary>
        /// Returns an NIBPDatareadDTO from NIBP monitor data
        /// </summary>
        /// <returns>
        /// An NIBPDatareadDTO
        /// </returns>
        /// <param name="nIBPToConvert">NIBP to convert
        /// </param>
        public static NIBPDatareadDTO FromNIBP(NIBP nIBPToConvert)
        {
            NIBPDatareadDTO nIBPDatareadDTOToReturn = new NIBPDatareadDTO();
            if (nIBPToConvert != null)
            {
                nIBPDatareadDTOToReturn = new NIBPDatareadDTO(nIBPToConvert.Systolic, nIBPToConvert.Diastolic, nIBPToConvert.MeanArterialPressure, nIBPToConvert.TimeOfDataCreation);
            }
            return nIBPDatareadDTOToReturn;
        }
    }
}