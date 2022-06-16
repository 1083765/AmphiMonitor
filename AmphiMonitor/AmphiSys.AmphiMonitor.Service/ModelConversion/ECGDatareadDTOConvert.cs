using AmphiSys.Monitor.MonitorDataModel;
using AmphiSys.AmphiMonitor.Service.DTO;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class ECGDatareadDTOConvert
    {

        // Returns an ECGDatareadDTO
        /// <summary>
        /// Returns an ECGDatareadDTO from ECG monitor data
        /// </summary>
        /// <returns>
        /// An ECGDatareadDTO
        /// </returns>
        /// <param name="eCGToConvert">ECG to convert
        /// </param>
        public static ECGDatareadDTO FromECG(ECG eCGToConvert)
        {
            ECGDatareadDTO eCGDatareadDTOToReturn = new ECGDatareadDTO();
            if (eCGToConvert != null)
            {
                eCGDatareadDTOToReturn = new ECGDatareadDTO(eCGToConvert.TimeOfDataCreation);
            }
            return eCGDatareadDTOToReturn;
        }
    }
}