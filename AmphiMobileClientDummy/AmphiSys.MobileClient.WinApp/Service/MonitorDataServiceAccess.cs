using MonitorHostServiceReference;

namespace AmphiSys.MobileClient.WinApp.Service
{
    internal class MonitorDataServiceAccess
    {
        MonitorAccessClient _monitorAccessClient;

        public MonitorDataServiceAccess()
        {
            _monitorAccessClient = new MonitorAccessClient();
        }

        // Get Monitor Data
        /// <summary>
        /// Gets data from monitor based on selected monitor.
        /// </summary>
        /// <returns>
        /// A list of MonitorData objects,
        /// </returns>
        public async Task<List<Monitor.MonitorDataModel.MonitorData>> GetMonitorData(int selectedMonitor)
        {
            List<Monitor.MonitorDataModel.MonitorData> monitorData = new List<Monitor.MonitorDataModel.MonitorData>();

            monitorData = await _monitorAccessClient.GetMonitorDataAsync(selectedMonitor);

            return monitorData;
        }

        // Connect Monitor.
        /// <summary>
        /// Establishes connection to selected monitor.
        /// </summary>
        public async void ConnectMonitor(int selectedMonitor)
        {
            await _monitorAccessClient.ConnectMonitorAsync(selectedMonitor);
        }

        // Disconnect Monitor.
        /// <summary>
        /// Closes connection to selected monitor if selected monitor.
        /// </summary>
        public async void DisconnectMonitor(int selectedMonitor)
        {
            await _monitorAccessClient.DisconnectMonitorAsync(selectedMonitor);
        }
    }
}