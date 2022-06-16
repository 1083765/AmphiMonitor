using System.Collections.Generic;
using System.Threading.Tasks;
using AmphiSys.Monitor.WCFService.BusinessLogic;
using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.Monitor.WCFService
{
    public class MonitorAccess : IMonitorAccess
    {

        IMonitorDataLogic _monitorDataLogic;

        // Constuct a MonitorAccess object
        /// <summary>
        /// Constuct a MonitorAccess object
        /// </summary>
        public MonitorAccess()
        {
            _monitorDataLogic = new MonitorDataLogic();
        }

        //  Returns a List of monitor data
        /// <inheritdoc/>
        public async Task<List<MonitorData>> GetMonitorData(int selectedMonitor)
        {
            //List<IMonitor> monitors = new List<IMonitor>();
            //monitors.FirstOrDefault(s => s.Name == selectedMonitor);
            List<MonitorData> monitorData = new List<MonitorData>();
            switch (selectedMonitor)
            {
                case 0:
                    monitorData = await _monitorDataLogic.GetMonitorDataAmphiMonitor();
                    break;
                case 1:
                    monitorData = await _monitorDataLogic.GetMonitorDataCorpuls3();
                    break;
                default:
                    break;
            }
            return monitorData;
        }

        //  Connects to selected monitor
        /// <inheritdoc/>
        public void ConnectMonitor(int selectedMonitor)
        {
            switch (selectedMonitor)
            {
                case 1:
                    _monitorDataLogic.ConnectCorpuls3();
                    break;
                default:
                    break;
            }
        }

        //  Disconnects from selected monitor
        /// <inheritdoc/>
        public void DisconnectMonitor(int selectedMonitor)
        {
            switch (selectedMonitor)
            {
                case 1:
                    _monitorDataLogic.DisconnectCorpuls3();
                    break;
                default:
                    break;
            }
        }
    }
}