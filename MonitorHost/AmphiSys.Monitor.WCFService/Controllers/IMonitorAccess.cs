using AmphiSys.Monitor.MonitorDataModel;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace AmphiSys.Monitor.WCFService
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IMonitorAccess
    {

        // Returns a List of monitor data
        /// <summary>
        /// Returns a List of monitor data from a selected monitor
        /// </summary>
        /// <returns>
        /// A List of monitor data
        /// </returns>
        /// <param name="selectedMonitor">Selected monitor
        /// </param>
        [OperationContract]
        Task<List<MonitorData>> GetMonitorData(int selectedMonitor);

        //  Connect to selected monitor
        /// <summary>
        /// Attempts to connect to selected monitor
        /// </summary>
        /// <param name="selectedMonitor">Selected monitor
        /// </param>
        [OperationContract]
        void ConnectMonitor(int selectedMonitor);

        //  Disconnect from selected monitor
        /// <summary>
        /// Attempts to disconnect from selected monitor
        /// </summary>
        /// <param name="selectedMonitor">Selected monitor
        /// </param>
        [OperationContract]
        void DisconnectMonitor(int selectedMonitor);
    }
}