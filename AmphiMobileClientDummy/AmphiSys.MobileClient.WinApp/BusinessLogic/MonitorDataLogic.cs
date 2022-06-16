using AmphiSys.MobileClient.WinApp.Service;
using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.MobileClient.WinApp.BusinessLogic
{
    internal class MonitorDataLogic
    {

        MonitorDataServiceAccess _monitorDataServiceAccess;

        public MonitorDataLogic()
        {
            _monitorDataServiceAccess = new MonitorDataServiceAccess();
        }

        public async Task<List<MonitorData>> GetMonitorData(int selectedMonitor)
        {
            List<MonitorData> monitorData = new List<MonitorData>();

            monitorData = await _monitorDataServiceAccess.GetMonitorData(selectedMonitor);

            return monitorData;
        }
        public void ConnectMonitor(int selectedMonitor)
        {
            _monitorDataServiceAccess.ConnectMonitor(selectedMonitor);
        }

        public void DisconnectMonitor(int selectedMonitor)
        {
            _monitorDataServiceAccess.DisconnectMonitor(selectedMonitor);
        }
    }
}