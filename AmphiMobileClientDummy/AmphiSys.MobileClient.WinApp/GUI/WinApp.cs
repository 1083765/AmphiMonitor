using AmphiSys.MobileClient.WinApp.BusinessLogic;
using AmphiSys.Monitor.MonitorDataModel;

namespace AmphiSys.MobileClient.WinApp
{
    public partial class WinApp : Form
    {
        private MonitorDataLogic _monitorDataLogic;
        private static System.Timers.Timer? monitorTimer;
        private int selectedMonitor;


        public WinApp()
        {
            InitializeComponent();
            _monitorDataLogic = new MonitorDataLogic();
            monitorSelectionComboBox.SelectedIndex = 0;
            selectedMonitor = 0;
        }

        // Timer setup
        /// <summary>
        /// Sets up timer for executing method to retrieve data from monitor.
        /// </summary>
        private void SetTimer()
        {
            if (monitorTimer == null)
            {
                monitorTimer = new System.Timers.Timer(15000);
                monitorTimer.Elapsed += GetMonitorData;
                monitorTimer.AutoReset = true;
                monitorTimer.Enabled = true;
            }
        }

        // Start Timer
        /// <summary>
        /// Stars the timer
        /// </summary>
        private void StartTimer(object sender, EventArgs e)
        {
            SetTimer();
        }

        // Stop Timer.
        /// <summary>
        /// Stops the timer.
        /// </summary>
        private void StopTimer(object sender, EventArgs e)
        {
            if (monitorTimer != null)
            {
                monitorTimer.Stop();
                monitorTimer.Dispose();
                monitorTimer = null;
            }
        }

        // Set selectedmonitor based on comboBox.
        /// <summary>
        /// Sets selected monitor attribute based on selected index in monitorSelectionComboBox.
        /// </summary>
        private void monitorSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisconnectMonitor(sender, e);
            selectedMonitor = monitorSelectionComboBox.SelectedIndex;
        }

        // Connect Monitor.
        /// <summary>
        /// Establishes connection to selected monitor if selected monitor is not AmphiMonitor.
        /// </summary>
        private void ConnnectMonitor(object sender, EventArgs e)
        {
            if (selectedMonitor != 0)
            {
                _monitorDataLogic.ConnectMonitor(selectedMonitor);
            }
        }

        // Disconnect Monitor.
        /// <summary>
        /// Closes connection to selected monitor if selected monitor is not AmphiMonitor.
        /// </summary>
        private void DisconnectMonitor(object sender, EventArgs e)
        {
            if (selectedMonitor != 0)
            {
                _monitorDataLogic.DisconnectMonitor(selectedMonitor);
            }
        }

        // Get Monitor Data.
        /// <summary>
        /// Gets data from selected monitor and displays the data in listview.
        /// </summary>
        private async void GetMonitorData(object sender, EventArgs e)
        {
            List<MonitorData> monitorData = new List<MonitorData>();

            monitorData = await _monitorDataLogic.GetMonitorData(selectedMonitor);

            DisplayMonitorData(monitorData);
        }

        // Display Monitor Data.
        /// <summary>
        /// Displays data retrived from selected monitor by looping through list of monitordata, generating text strings for listView based on each data object in list.
        /// </summary>
        private async void DisplayMonitorData(List<MonitorData> monitorDataList)
        {
            ListViewItem item = new ListViewItem();

            DateTime timeOfDataCreation = new DateTime();
            int beatsPerMinute = 0;
            int saturation = 0;
            int systolic = 0;
            int diastolic = 0;
            int meanArterialPressure = 0;
            int breathsPerMinute = 0;
            int concentration = 0;
            double degrees = 0;

            //Loop through monitorData list.
            foreach (MonitorData monitorData in monitorDataList)
            {
                //Switch cases for displaying object data in listView as text strings.
                switch (monitorData)
                {
                    case HeartRate heartRate:

                        beatsPerMinute = heartRate.BeatsPerMinute;
                        timeOfDataCreation = heartRate.TimeOfDataCreation;

                        String heartRateText = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | HeartRate | " + beatsPerMinute + " /min";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(heartRateText)));

                        break;
                    case NIBP nIBP:

                        systolic = nIBP.Systolic;
                        diastolic = nIBP.Diastolic;
                        meanArterialPressure = nIBP.MeanArterialPressure;
                        timeOfDataCreation = nIBP.TimeOfDataCreation;

                        String nIBPText = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | NIBP | " + systolic + "/" + diastolic + " (" + meanArterialPressure + ")";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(nIBPText)));

                        break;
                    case IBP iBP:

                        systolic = iBP.Systolic;
                        diastolic = iBP.Diastolic;
                        meanArterialPressure = iBP.MeanArterialPressure;
                        timeOfDataCreation = iBP.TimeOfDataCreation;

                        String iBPText = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | IBP | " + systolic + "/" + diastolic + " (" + meanArterialPressure + ")";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(iBPText)));

                        break;
                    case SpO2 sPo2:

                        saturation = sPo2.Saturation;
                        timeOfDataCreation = sPo2.TimeOfDataCreation;

                        String sPo2Text = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | SpO2 | " + saturation + "%";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(sPo2Text)));

                        break;
                    case Pulse pulse:

                        beatsPerMinute = pulse.BeatsPerMinute;
                        timeOfDataCreation = pulse.TimeOfDataCreation;

                        String pulseText = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | Pulse | " + beatsPerMinute + " /min";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(pulseText)));

                        break;
                    case CO2 cO2:

                        concentration = cO2.Concentration;
                        timeOfDataCreation = cO2.TimeOfDataCreation;

                        String cO2Text = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | Co2 | " + concentration + " mmHg";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(cO2Text)));

                        break;
                    case RespiratoryRate respiratoryRate:

                        breathsPerMinute = respiratoryRate.BreathsPerMinute;
                        timeOfDataCreation = respiratoryRate.TimeOfDataCreation;

                        String respiratoryRateText = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | RespiratoryRate | " + breathsPerMinute + "  /min";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(respiratoryRateText)));

                        break;
                    case Temperature temperature:

                        degrees = temperature.Degrees;
                        timeOfDataCreation = temperature.TimeOfDataCreation;

                        String temperatureText = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | Temperature | " + degrees + "°";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(temperatureText)));

                        break;
                    case MonitorEvent monitorEvent:

                        timeOfDataCreation = monitorEvent.TimeOfDataCreation;

                        String monitorEventText = timeOfDataCreation.Hour + ":" + timeOfDataCreation.Minute + ":" + timeOfDataCreation.Second + " | Event Registered |";
                        monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items.Add(monitorEventText)));

                        break;

                }

                //Arranges listView to achieve autoscrolling.
                monitorDataListView.Invoke((MethodInvoker)(() => monitorDataListView.Items[monitorDataListView.Items.Count - 1].EnsureVisible()));
            }
        }
    }
}