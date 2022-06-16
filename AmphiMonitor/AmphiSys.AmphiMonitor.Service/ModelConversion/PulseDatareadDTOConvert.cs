using AmphiSys.AmphiMonitor.Service.DTO;
using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class PulseDatareadDTOConvert
    {

        // Returns a PulseDatareadDTO
        /// <summary>
        /// Returns a PulseDatareadDTO from pulse monitor data
        /// </summary>
        /// <returns>
        /// A PulseDatareadDTO
        /// </returns>
        /// <param name="pulseToConvert">Pulse to convert
        /// </param>
        public static PulseDatareadDTO FromPulse(Pulse pulseToConvert)
        {
            PulseDatareadDTO pulseDatareadDTOToReturn = new PulseDatareadDTO();
            if (pulseToConvert != null)
            {
                pulseDatareadDTOToReturn = new PulseDatareadDTO(pulseToConvert.BeatsPerMinute, pulseToConvert.TimeOfDataCreation);
            }
            return pulseDatareadDTOToReturn;
        }
    }
}