using AmphiSys.Monitor.MonitorDataModel;
using AmphiSys.AmphiMonitor.Service.DTO;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class IBPDatareadDTOConvert
    {

        // Returns an IBPDatareadDTO
        /// <summary>
        /// Returns an IBPDatareadDTO from IBP monitor data
        /// </summary>
        /// <returns>
        /// An IBPDatareadDTO
        /// </returns>
        /// <param name="iBPToConvert">IBP to convert
        /// </param>
        public static IBPDatareadDTO FromIBP(IBP iBPToConvert)
        {
            IBPDatareadDTO iBPDatareadDTOToReturn = new IBPDatareadDTO();
            if (iBPToConvert != null)
            {
                iBPDatareadDTOToReturn = new IBPDatareadDTO(iBPToConvert.Systolic, iBPToConvert.Diastolic, iBPToConvert.MeanArterialPressure, iBPToConvert.TimeOfDataCreation);
            }
            return iBPDatareadDTOToReturn;
        }
    }
}