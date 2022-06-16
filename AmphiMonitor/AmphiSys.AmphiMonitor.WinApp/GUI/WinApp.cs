using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using AmphiSys.AmphiMonitor.WinApp.Controller;
using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.AmphiMonitor.WinApp.GUI
{
    public partial class WinApp : Form
    {
        private static System.Timers.Timer? monitorTimer;
        private MonitorDataController _monitorDataController;
        private int patientType;

        public WinApp()
        {
            InitializeComponent();
            _monitorDataController = new MonitorDataController();
            patientType = 0;
            patientTypeComboBox.SelectedIndex = 0;
        }
        private void AmphiMonitorUI_Load(object sender, EventArgs e)
        {

        }
        private void Start(object sender, EventArgs e)
        {
            SetTimer();
        }
        private void Stop(object sender, EventArgs e)
        {
            if (monitorTimer != null)
            {
                monitorTimer.Stop();
                monitorTimer.Dispose();
                monitorTimer = null;
            }
        }
        private void SetTimer()
        {
            if (monitorTimer == null)
            {
                monitorTimer = new System.Timers.Timer(2000);
                monitorTimer.Elapsed += GenerateHeartRate;
                monitorTimer.Elapsed += GenerateIBP;
                monitorTimer.Elapsed += GeneratePulse;
                monitorTimer.Elapsed += GenerateSpO2;
                monitorTimer.Elapsed += GenerateCO2;
                monitorTimer.Elapsed += GenerateTemperature;
                monitorTimer.Elapsed += GenerateRespiratoryRate;
                monitorTimer.AutoReset = true;
                monitorTimer.Enabled = true;
            }
        }
        private async void GenerateMonitorEvent(object sender, EventArgs e)
        {
            MonitorEvent monitorEvent = await _monitorDataController.GenerateMonitorEvent();
            if (monitorEvent != null)
            {
                generateMonitorEventButton.Enabled = false;
                monitorEventGeneratedLabel.Visible = true;

                await Task.Delay(TimeSpan.FromSeconds(3));

                monitorEventGeneratedLabel.Visible = false;
                generateMonitorEventButton.Enabled = true;
            }
        }
        private async void GenerateECG(object sender, EventArgs e)
        {
            generateECGButton.Enabled = false;
            eCGGeneratedLabel.Visible = true;

            await Task.Delay(TimeSpan.FromSeconds(3));

            eCGGeneratedLabel.Visible = false;
            generateECGButton.Enabled = true;
        }
        private async void GenerateHeartRate(object sender, EventArgs e)
        {
            HeartRate heartRate = await _monitorDataController.GenerateHeartRate(patientType);
            heartRateMeasurementLabel.Invoke((MethodInvoker)(() => heartRateMeasurementLabel.Text = heartRate.BeatsPerMinute.ToString()));
        }
        private async void GenerateNIBP(object sender, EventArgs e)
        {
            NIBP nIBP = await _monitorDataController.GenerateNIBP(patientType);
            nIBPMeasurementLabel.Invoke((MethodInvoker)(() => nIBPMeasurementLabel.Text = nIBP.Systolic.ToString() + "/" + nIBP.Diastolic.ToString() + "\n (" + nIBP.MeanArterialPressure.ToString() + ")"));
        }
        private async void GenerateIBP(object sender, EventArgs e)
        {
            IBP iBP = await _monitorDataController.GenerateIBP(patientType);
            iBPMeasurementLabel.Invoke((MethodInvoker)(() => iBPMeasurementLabel.Text = iBP.Systolic.ToString() + "/" + iBP.Diastolic.ToString() + "\n (" + iBP.MeanArterialPressure.ToString() + ")"));
        }
        private async void GenerateSpO2(object sender, EventArgs e)
        {
            SpO2 spO2 = await _monitorDataController.GenerateSpO2(patientType);
            spO2MeasurementLabel.Invoke((MethodInvoker)(() => spO2MeasurementLabel.Text = spO2.Saturation.ToString()));
        }
        private async void GeneratePulse(object sender, EventArgs e)
        {
            Pulse pulse = await _monitorDataController.GeneratePulse(patientType);
            pulseMeasurementLabel.Invoke((MethodInvoker)(() => pulseMeasurementLabel.Text = pulse.BeatsPerMinute.ToString()));
        }
        private async void GenerateCO2(object sender, EventArgs e)
        {
            CO2 cO2 = await _monitorDataController.GenerateCO2(patientType);
            cO2MeasurementLabel.Invoke((MethodInvoker)(() => cO2MeasurementLabel.Text = cO2.Concentration.ToString()));
        }
        private async void GenerateRespiratoryRate(object sender, EventArgs e)
        {
            RespiratoryRate respiratoryRate = await _monitorDataController.GenerateRespiratoryRate(patientType);
            respiratoryRateMeasurementLabel.Invoke((MethodInvoker)(() => respiratoryRateMeasurementLabel.Text = respiratoryRate.BreathsPerMinute.ToString()));
        }
        private async void GenerateTemperature(object sender, EventArgs e)
        {
            Temperature temperature = await _monitorDataController.GenerateTemperature(patientType);
            temperatureMeasurementLabel.Invoke((MethodInvoker)(() => temperatureMeasurementLabel.Text = Math.Round(temperature.Degrees, 1).ToString()));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientType = patientTypeComboBox.SelectedIndex;
        }
    }
}
