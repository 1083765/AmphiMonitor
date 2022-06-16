using AmphiSys.AmphiMonitor.Service.DTO;
using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class TemperatureDatareadDTOConvert
    {

        // Returns a TemperatureDatareadDTO
        /// <summary>
        /// Returns a TemperatureDatareadDTO from temperature monitor data
        /// </summary>
        /// <returns>
        /// A TemperatureDatareadDTO
        /// </returns>
        /// <param name="temperatureToConvert">Temperature to convert
        /// </param>
        public static TemperatureDatareadDTO FromTemperature(Temperature temperatureToConvert)
        {
            TemperatureDatareadDTO temperatureDatareadDTOToReturn = new TemperatureDatareadDTO();
            if (temperatureToConvert != null)
            {
                temperatureDatareadDTOToReturn = new TemperatureDatareadDTO(temperatureToConvert.Degrees, temperatureToConvert.TimeOfDataCreation);
            }
            return temperatureDatareadDTOToReturn;
        }
    }
}