using AmphiSys.AmphiMonitor.WinApp.Service;
using AmphiSys.Monitor.MonitorDataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmphiSys.AmphiMonitor.WinApp.Controller
{
    public class MonitorDataController
    {
        MonitorDataAccess _monitorDataServiceAccess;

        // Constuct a MonitorDataController object
        /// <summary>
        /// Constuct a MonitorDataController object
        /// </summary>
        public MonitorDataController()
        {
            _monitorDataServiceAccess = new MonitorDataAccess();
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
            HeartRate heartRate = await _monitorDataServiceAccess.GenerateHeartRate(patientType);

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
            NIBP nIBPRate = await _monitorDataServiceAccess.GenerateNIBP(patientType);

            return nIBPRate;
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
            IBP iBP = await _monitorDataServiceAccess.GenerateIBP(patientType);

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
            SpO2 spO2 = await _monitorDataServiceAccess.GenerateSpO2(patientType);

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
            Pulse pulse = await _monitorDataServiceAccess.GeneratePulse(patientType);

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
            CO2 cO2 = await _monitorDataServiceAccess.GenerateCO2(patientType);

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
            RespiratoryRate respiratoryRate = await _monitorDataServiceAccess.GenerateRespiratoryRate(patientType);

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
            Temperature temperature = await _monitorDataServiceAccess.GenerateTemperature(patientType);

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
            MonitorEvent monitorEvent = await _monitorDataServiceAccess.GenerateMonitorEvent();

            return monitorEvent;
        }
    }
}