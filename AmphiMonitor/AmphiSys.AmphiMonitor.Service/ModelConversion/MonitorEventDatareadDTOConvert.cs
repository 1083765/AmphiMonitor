using AmphiSys.Monitor.MonitorDataModel;
using AmphiSys.AmphiMonitor.Service.DTO;

namespace AmphiSys.AmphiMonitor.Service.ModelConversion
{
    public class MonitorEventDatareadDTOConvert
    {

        // Returns an MonitorEventDatareadDTO
        /// <summary>
        /// Returns an MonitorEventDatareadDTO from MonitorEvent monitor data
        /// </summary>
        /// <returns>
        /// An MonitorEventDatareadDTO
        /// </returns>
        /// <param name="monitorEventToConvert">MonitorEvent to convert
        /// </param>
        public static MonitorEventDatareadDTO FromMonitorEvent(MonitorEvent monitorEventToConvert)
        {
            MonitorEventDatareadDTO monitorEventDatareadDTOToReturn = new MonitorEventDatareadDTO();
            if (monitorEventToConvert != null)
            {
                monitorEventDatareadDTOToReturn = new MonitorEventDatareadDTO(monitorEventToConvert.TimeOfDataCreation);
            }
            return monitorEventDatareadDTOToReturn;
        }

        // Returns a List of MonitorEventDatareadDTO
        /// <summary>
        /// Returns a List MonitorEventDatareadDTO from a List of MonitorEvent monitor data
        /// </summary>
        /// <returns>
        /// A List of MonitorEventDatareadDTO
        /// </returns>
        /// <param name="monitorEvents">A List of MonitorEvent to convert
        /// </param>
        public static List<MonitorEventDatareadDTO> FromMonitorEventsList(List<MonitorEvent> monitorEvents)
        {
            List<MonitorEventDatareadDTO> monitorEventDatareadDTOList = null;
            if (monitorEvents != null)
            {
                monitorEventDatareadDTOList = new List<MonitorEventDatareadDTO>();
                MonitorEventDatareadDTO tempDto;
                foreach (MonitorEvent monitorEvent in monitorEvents)
                {
                    tempDto = FromMonitorEvent(monitorEvent);
                    monitorEventDatareadDTOList.Add(tempDto);
                }
            }
            return monitorEventDatareadDTOList;
        }
    }
}