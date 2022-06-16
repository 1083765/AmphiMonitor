using AmphiSys.Monitor.MonitorDataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmphiSys.AmphiMonitor.WinApp.Service
{
    internal class MonitorDataAccess
    {
        static readonly string restUrl = "http://localhost:5268/monitordata/";
        readonly HttpClient _httpClient;

        // Constuct a MonitorDataAccess object
        /// <summary>
        /// Constuct a MonitorDataAccess object
        /// </summary>
        public MonitorDataAccess()
        {
            _httpClient = new HttpClient();
        }

        // Returns a heart rate
        /// <summary>
        /// Returns a heart rate depending on the type of patient
        /// </summary>
        /// <returns>
        /// A heart rate
        /// </returns>
        /// <param name="patientType">Type of patient
        /// </param>
        public async Task<HeartRate> GenerateHeartRate(int patientType)
        {
            HeartRate? heartRate = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-heart-rate/" + patientType;
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                heartRate = JsonConvert.DeserializeObject<HeartRate>(content);
            }
            return heartRate;
        }

        // Returns an NIBP
        /// <summary>
        /// Returns an NIBP depending on the type of patient
        /// </summary>
        /// <returns>
        /// A NIBP
        /// </returns>
        /// <param name="patientType">Type of patient
        /// </param>
        public async Task<NIBP> GenerateNIBP(int patientType)
        {
            NIBP? nIBP = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-nibp/" + patientType;
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                nIBP = JsonConvert.DeserializeObject<NIBP>(content);
            }
            return nIBP;
        }

        // Returns an IBP
        /// <summary>
        /// Returns an IBP depending on the type of patient
        /// </summary>
        /// <returns>
        /// A IBP
        /// </returns>
        /// <param name="patientType">Type of patient
        /// </param>
        public async Task<IBP> GenerateIBP(int patientType)
        {
            IBP? iBP = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-ibp/" + patientType;
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                iBP = JsonConvert.DeserializeObject<IBP>(content);
            }
            return iBP;
        }

        // Returns an SpO2
        /// <summary>
        /// Returns an SpO2 depending on the type of patient
        /// </summary>
        /// <returns>
        /// A SpO2
        /// </returns>
        /// <param name="patientType">Type of patient
        /// </param>
        public async Task<SpO2> GenerateSpO2(int patientType)
        {
            SpO2? spO2 = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-spo2/" + patientType;
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                spO2 = JsonConvert.DeserializeObject<SpO2>(content);
            }
            return spO2;
        }

        // Returns a Pulse
        /// <summary>
        /// Returns a Pulse depending on the type of patient
        /// </summary>
        /// <returns>
        /// A Pulse
        /// </returns>
        /// <param name="patientType">Type of patient
        /// </param>
        public async Task<Pulse> GeneratePulse(int patientType)
        {
            Pulse? pulse = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-pulse/" + patientType;
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                pulse = JsonConvert.DeserializeObject<Pulse>(content);
            }
            return pulse;
        }

        // Returns a CO2
        /// <summary>
        /// Returns a CO2 depending on the type of patient
        /// </summary>
        /// <returns>
        /// A CO2
        /// </returns>
        /// <param name="patientType">Type of patient
        /// </param>
        public async Task<CO2> GenerateCO2(int patientType)
        {
            CO2? cO2 = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-co2/" + patientType;
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                cO2 = JsonConvert.DeserializeObject<CO2>(content);
            }
            return cO2;
        }

        // Returns a RespiratoryRate
        /// <summary>
        /// Returns a RespiratoryRate depending on the type of patient
        /// </summary>
        /// <returns>
        /// A RespiratoryRate
        /// </returns>
        /// <param name="patientType">Type of patient
        /// </param>
        public async Task<RespiratoryRate> GenerateRespiratoryRate(int patientType)
        {
            RespiratoryRate? respiratoryRate = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-respiratory-rate/" + patientType;
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                respiratoryRate = JsonConvert.DeserializeObject<RespiratoryRate>(content);
            }
            return respiratoryRate;
        }

        // Returns a Temperature
        /// <summary>
        /// Returns a Temperature depending on the type of patient
        /// </summary>
        /// <returns>
        /// A Temperature
        /// </returns>
        /// <param name="patientType">Type of patient
        /// </param>
        public async Task<Temperature> GenerateTemperature(int patientType)
        {
            Temperature? temperature = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-temperature/" + patientType;
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                temperature = JsonConvert.DeserializeObject<Temperature>(content);
            }
            return temperature;
        }

        // Returns a MonitorEvent
        /// <summary>
        /// Returns a MonitorEvent
        /// </summary>
        /// <returns>
        /// A MonitorEvent
        /// </returns>
        public async Task<MonitorEvent> GenerateMonitorEvent()
        {
            MonitorEvent? monitorEvent = null;

            string useRestUrl = restUrl;
            useRestUrl += "generate-monitor-event";
            Uri uri = new Uri(String.Format(useRestUrl));

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                monitorEvent = JsonConvert.DeserializeObject<MonitorEvent>(content);
            }
            return monitorEvent;
        }
    }
}