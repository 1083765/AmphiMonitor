using AmphiSys.Monitor.MonitorDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmphiSys.Monitor.WCFService.BusinessLogic
{
    public interface IMonitorDataLogic
    {

        // Returns a List of monitor data
        /// <summary>
        /// Returns a List of monitor data from AmphiMonitor
        /// </summary>
        /// <returns>
        /// A List of monitor data
        /// </returns>
        Task<List<MonitorData>> GetMonitorDataAmphiMonitor();

        // Returns a List of monitor data
        /// <summary>
        /// Returns a List of monitor data from Corpuls3
        /// </summary>
        /// <returns>
        /// A List of monitor data
        /// </returns>
        Task<List<MonitorData>> GetMonitorDataCorpuls3();

        //  Connects to Corpuls3
        /// <summary>
        /// Attempts to connect to Corpuls3 with bt
        /// </summary>
        void ConnectCorpuls3();

        //  Disconnects from Corpuls3
        /// <summary>
        /// Attempts to disconnect from Corpuls3
        /// </summary>
        void DisconnectCorpuls3();
    }
}