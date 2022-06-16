using AmphiSys.Monitor.AmphiMonitor.BusinessLogic;
using AmphiSys.Monitor.AmphiMonitor.Controller;
using AmphiSys.Monitor.AmphiMonitor.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmphiSys.Monitor.AmphiMonitor
{
    internal class Client
    {
        static void Main(string[] args)
        {

            IMonitorDataLogic measurementController = new MonitorDataLogic();
            
            IMonitorEventLogic monitorEventLogic = new MonitorEventLogic();
            

            async void TestGetMeasurements()
            {
                var results = await measurementController.GetMeasurements();
                Console.WriteLine(results.Count);
                //var monitorresults = await monitorEventLogic.GetMonitorEvents();
                //Console.WriteLine(monitorresults.Count);
            }
            TestGetMeasurements();
            Console.ReadLine();
        }
    }
}
