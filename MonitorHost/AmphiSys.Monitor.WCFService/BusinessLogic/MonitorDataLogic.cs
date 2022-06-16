using AmphiSys.Monitor.MonitorDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmphiSys.Monitor.AmphiMonitor.Service;
using AmphiSys.Monitor.Corpuls3.MonitorAccess;

namespace AmphiSys.Monitor.WCFService.BusinessLogic
{
    public class MonitorDataLogic : IMonitorDataLogic
    {
        MonitorDataServiceAccess _monitorDataServiceAccess;
        Corpuls3Access _corpuls3Access;

        // Constuct a MonitorDataLogic object
        /// <summary>
        /// Constuct a MonitorDataLogic object
        /// </summary>
        public MonitorDataLogic()
        {
            _monitorDataServiceAccess = new MonitorDataServiceAccess();
            _corpuls3Access = new Corpuls3Access();
        }

        // Returns a List of monitor data
        /// <inheritdoc/>
        public async Task<List<MonitorData>> GetMonitorDataAmphiMonitor()
        {
            List<MonitorData> monitorData = new List<MonitorData>();
            monitorData = await _monitorDataServiceAccess.GetMonitorData();
            return monitorData;
        }

        // Returns a List of monitor data
        /// <inheritdoc/>
        public async Task<List<MonitorData>> GetMonitorDataCorpuls3()
        { 
            List<MonitorData> monitorData = new List<MonitorData>();
            monitorData = await _corpuls3Access.GetMonitorData();
            return monitorData;
        }

        //  Connects to Corpuls3
        /// <inheritdoc/>
        public void ConnectCorpuls3()
        {
            _corpuls3Access.Connect();
        }

        //  Disconnects from Corpuls3
        /// <inheritdoc/>
        public void DisconnectCorpuls3()
        {
            _corpuls3Access.Disconnect();
        }
    }
}