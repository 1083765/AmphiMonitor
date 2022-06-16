using AmphiSys.Monitor.Client.Service;
using AmphiSys.Monitor.MonitorDataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AmphiSys.Monitor.AmphiMonitor.Service
{
    public class MonitorDataServiceAccess
    {
        static readonly string restUrl = "http://localhost:5268/monitordata/";
        readonly HttpClient _httpClient;

        // Constuct a MonitorDataServiceAccess object
        /// <summary>
        /// Constuct a MonitorDataServiceAccess object
        /// </summary>
        public MonitorDataServiceAccess()
        {
            _httpClient = new HttpClient();
        }


        // Returns a List of monitor data
        /// <summary>
        /// Returns a List of monitor data after deserializing a response from http client
        /// </summary>
        /// <returns>
        /// A List of monitor data
        /// </returns>
        public async Task<List<MonitorData>> GetMonitorData()
        {
            KnownTypesBinder knownTypesBinder = new KnownTypesBinder
            {
                KnownTypes = new List<Type> {
                    typeof(CO2),
                    typeof(HeartRate),
                    typeof(IBP),
                    typeof(NIBP),
                    typeof(Pulse),
                    typeof(RespiratoryRate),
                    typeof(SpO2),
                    typeof(Temperature),
                    typeof(MonitorEvent)
                }
            };

            List<MonitorData> monitorData = null;
            string useRestUrl = restUrl;
            useRestUrl += "get-monitor-data";
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                monitorData = JsonConvert.DeserializeObject<List<MonitorData>>(content, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects,
                    SerializationBinder = knownTypesBinder
                });
            }
            return monitorData;
        }
    }
}