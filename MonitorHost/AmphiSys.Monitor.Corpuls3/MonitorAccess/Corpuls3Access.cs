using System;
using System.Collections.Generic;
using Corpuls.Bluetooth.Domain;
using AmphiSys.Monitor.MonitorDataModel;
using System.Threading.Tasks;

namespace AmphiSys.Monitor.Corpuls3.MonitorAccess
{
    public class Corpuls3Access
    {
        private Corpuls3Connection _c3conn;
        public bool _connected;

        // Constuct a Corpuls3Access object
        /// <summary>
        /// Constuct a Corpuls3Access object
        /// </summary>
        public Corpuls3Access()
        {
            _c3conn = Corpuls3Connection.GetInstance();
            _connected = false;
        }

        //  Connect to Corpuls3
        /// <summary>
        /// Attempts to connect to Corpuls3 with bt
        /// </summary>
        public void Connect()
        {
            if (!_connected)
            {
                if (_c3conn.Connect())
                {
                    _connected = true;
                }
            }
        }

        //  Disconnect from Corpuls3
        /// <summary>
        /// Attempts to disconnect from Corpuls3
        /// </summary>
        public void Disconnect()
        {
            _c3conn.Disconnect();
        }

        // Returns a List of monitor data
        /// <summary>
        /// Returns a List of monitor data after recieving it from Corpuls3
        /// </summary>
        /// <returns>
        /// A List of monitor data
        /// </returns>
        public Task<List<MonitorData>> GetMonitorData()
        {
            List<MonitorData> monitorData = new List<MonitorData>();
            C3Time c3Time = _c3conn._connectedC3Device.GetTime();
            long fromTimestamp = c3Time.MonotonicTimestamp - 16000;
            Trend[] trends = _c3conn._connectedC3Device.ReadTrends(-1, 15, fromTimestamp);
            Event[] events = _c3conn._connectedC3Device.GetEvents(-1, fromTimestamp);
            if (trends != null)
            {
                try
                {
                    for (int i = 0; i < trends.Length; i++)
                    {
                        int NIBP_SYS = 0;
                        int NIBP_DIA = 0;
                        int NIBP_MAP = 0;
                        int P1_SYS = 0;
                        int P1_DIA = 0;
                        int P1_MAP = 0;
                        int HR_PAM = 0;
                        int PP = 0;
                        int RR = 0;
                        int SPO2 = 0;
                        int CO2_ENS = 0;
                        double T1 = 0;
                        DateTime timeForTrend;

                        timeForTrend = trends[i].DateTime;

                        foreach (Vitalparameter vp in trends[i].Vitalparameters)
                        {

                            switch (vp.VitalparameterType)
                            {
                                case VitalparameterType.CO2_ENS:
                                    CO2_ENS = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.HR_PAM:
                                    HR_PAM = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.P1_SYS:
                                    P1_SYS = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.P1_DIA:
                                    P1_DIA = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.P1_MAP:
                                    P1_MAP = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.NIBP_SYS:
                                    NIBP_SYS = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.NIBP_DIA:
                                    NIBP_DIA = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.NIBP_MAP:
                                    NIBP_MAP = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.PP:
                                    PP = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.RR:
                                    RR = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.SPO2:
                                    SPO2 = Convert.ToInt16(vp.Value);
                                    break;
                                case VitalparameterType.T1:
                                    T1 = vp.Value;
                                    break;
                            }
                        }
                        if (CO2_ENS != 0)
                        {
                            CO2 cO2 = new CO2(CO2_ENS, timeForTrend);
                            monitorData.Add(cO2);
                            CO2_ENS = 0;
                        }
                        if (HR_PAM != 0)
                        {
                            HeartRate heartRate = new HeartRate(HR_PAM, timeForTrend);
                            monitorData.Add(heartRate);
                            HR_PAM = 0;
                        }
                        if (P1_SYS != 0 && P1_DIA != 0 && P1_MAP != 0)
                        {
                            IBP iBP = new IBP(P1_SYS, P1_DIA, P1_MAP, timeForTrend);
                            monitorData.Add(iBP);
                        }
                        if (NIBP_SYS != 0 && NIBP_DIA != 0 && NIBP_MAP != 0)
                        {
                            NIBP nIBP = new NIBP(NIBP_SYS, NIBP_DIA, NIBP_MAP, timeForTrend);
                            monitorData.Add(nIBP);
                        }
                        if (PP != 0)
                        {
                            Pulse pulse = new Pulse(PP, timeForTrend);
                            monitorData.Add(pulse);
                        }
                        if (RR != 0)
                        {
                            RespiratoryRate respiratoryRate = new RespiratoryRate(RR, timeForTrend);
                            monitorData.Add(respiratoryRate);
                        }
                        if (SPO2 != 0)
                        {
                            SpO2 sPO2 = new SpO2(SPO2, timeForTrend);
                            monitorData.Add(sPO2);
                        }
                        if (T1 != 0)
                        {
                            Temperature temperature = new Temperature(T1, timeForTrend);
                            monitorData.Add(temperature);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return Task.FromResult(monitorData);
        }
    }
}