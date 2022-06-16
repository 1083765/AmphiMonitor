using AmphiSys.Monitor.WCFService;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace AmphiSys.Monitor.WCFServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8733/AmphiSys.Monitor.WCFService/");

            ServiceHost selfHost = new ServiceHost(typeof(MonitorAccess), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IMonitorAccess), new WSHttpBinding(), "Service1");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("The service is ready.");

                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                selfHost.Abort();
            }
        }
    }
}