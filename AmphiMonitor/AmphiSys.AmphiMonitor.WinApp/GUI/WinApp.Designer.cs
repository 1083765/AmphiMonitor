namespace AmphiSys.AmphiMonitor.WinApp.GUI
{
    partial class WinApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oNButton = new System.Windows.Forms.Button();
            this.oFFButton = new System.Windows.Forms.Button();
            this.electrocardiographyBox = new System.Windows.Forms.GroupBox();
            this.generateECGButton = new System.Windows.Forms.Button();
            this.generateHeartRateButton = new System.Windows.Forms.Button();
            this.eCGPanel = new System.Windows.Forms.Panel();
            this.eCGGeneratedLabel = new System.Windows.Forms.Label();
            this.eCGLabel = new System.Windows.Forms.Label();
            this.heartRatePanel = new System.Windows.Forms.Panel();
            this.heartRateMeasurementLabel = new System.Windows.Forms.Label();
            this.heartRateUnitLabel = new System.Windows.Forms.Label();
            this.heartRateLabel = new System.Windows.Forms.Label();
            this.patientTypeComboBox = new System.Windows.Forms.ComboBox();
            this.generateMonitorEventButton = new System.Windows.Forms.Button();
            this.patientTypeLabel = new System.Windows.Forms.Label();
            this.monitorEventGeneratedLabel = new System.Windows.Forms.Label();
            this.oximetryBox = new System.Windows.Forms.GroupBox();
            this.generateSp02Button = new System.Windows.Forms.Button();
            this.generatePulseButton = new System.Windows.Forms.Button();
            this.spO2Panel = new System.Windows.Forms.Panel();
            this.spO2MeasurementLabel = new System.Windows.Forms.Label();
            this.spO2UnitLabel = new System.Windows.Forms.Label();
            this.spO2Label = new System.Windows.Forms.Label();
            this.pulsePanel = new System.Windows.Forms.Panel();
            this.pulseMeasurementLabel = new System.Windows.Forms.Label();
            this.pulseUnitLabel = new System.Windows.Forms.Label();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.bloodPressureBox = new System.Windows.Forms.GroupBox();
            this.generateNIBPButton = new System.Windows.Forms.Button();
            this.generateIBPButton = new System.Windows.Forms.Button();
            this.iBPPanel = new System.Windows.Forms.Panel();
            this.iBPMeasurementLabel = new System.Windows.Forms.Label();
            this.iBPUnitLabel = new System.Windows.Forms.Label();
            this.iBPLabel = new System.Windows.Forms.Label();
            this.nIBPPanel = new System.Windows.Forms.Panel();
            this.nIBPMeasurementLabel = new System.Windows.Forms.Label();
            this.nIBPUnitLabel = new System.Windows.Forms.Label();
            this.nIBPLabel = new System.Windows.Forms.Label();
            this.capnormetryBox = new System.Windows.Forms.GroupBox();
            this.generateCO2Button = new System.Windows.Forms.Button();
            this.generateRespiratoryRateButton = new System.Windows.Forms.Button();
            this.cO2Panel = new System.Windows.Forms.Panel();
            this.cO2MeasurementLabel = new System.Windows.Forms.Label();
            this.cO2UnitLabel = new System.Windows.Forms.Label();
            this.cO2Label = new System.Windows.Forms.Label();
            this.respiratoryRatePanel = new System.Windows.Forms.Panel();
            this.respiratoryRateMeasurementLabel = new System.Windows.Forms.Label();
            this.respiratoryRateUnitLabel = new System.Windows.Forms.Label();
            this.respiratoryRateLabel = new System.Windows.Forms.Label();
            this.temperatureBox = new System.Windows.Forms.GroupBox();
            this.generateTemperatureButton = new System.Windows.Forms.Button();
            this.temperaturePanel = new System.Windows.Forms.Panel();
            this.temperatureMeasurementLabel = new System.Windows.Forms.Label();
            this.temperatureUnitLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.electrocardiographyBox.SuspendLayout();
            this.eCGPanel.SuspendLayout();
            this.heartRatePanel.SuspendLayout();
            this.oximetryBox.SuspendLayout();
            this.spO2Panel.SuspendLayout();
            this.pulsePanel.SuspendLayout();
            this.bloodPressureBox.SuspendLayout();
            this.iBPPanel.SuspendLayout();
            this.nIBPPanel.SuspendLayout();
            this.capnormetryBox.SuspendLayout();
            this.cO2Panel.SuspendLayout();
            this.respiratoryRatePanel.SuspendLayout();
            this.temperatureBox.SuspendLayout();
            this.temperaturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // oNButton
            // 
            this.oNButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.oNButton.FlatAppearance.BorderSize = 0;
            this.oNButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oNButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oNButton.ForeColor = System.Drawing.Color.White;
            this.oNButton.Location = new System.Drawing.Point(17, 23);
            this.oNButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.oNButton.Name = "oNButton";
            this.oNButton.Size = new System.Drawing.Size(64, 36);
            this.oNButton.TabIndex = 0;
            this.oNButton.Text = "ON";
            this.oNButton.UseVisualStyleBackColor = false;
            this.oNButton.Click += new System.EventHandler(this.Start);
            // 
            // oFFButton
            // 
            this.oFFButton.BackColor = System.Drawing.Color.Firebrick;
            this.oFFButton.FlatAppearance.BorderSize = 0;
            this.oFFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oFFButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oFFButton.ForeColor = System.Drawing.Color.White;
            this.oFFButton.Location = new System.Drawing.Point(89, 23);
            this.oFFButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.oFFButton.Name = "oFFButton";
            this.oFFButton.Size = new System.Drawing.Size(64, 36);
            this.oFFButton.TabIndex = 1;
            this.oFFButton.Text = "OFF";
            this.oFFButton.UseVisualStyleBackColor = false;
            this.oFFButton.Click += new System.EventHandler(this.Stop);
            // 
            // electrocardiographyBox
            // 
            this.electrocardiographyBox.Controls.Add(this.generateECGButton);
            this.electrocardiographyBox.Controls.Add(this.generateHeartRateButton);
            this.electrocardiographyBox.Controls.Add(this.eCGPanel);
            this.electrocardiographyBox.Controls.Add(this.heartRatePanel);
            this.electrocardiographyBox.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.electrocardiographyBox.Location = new System.Drawing.Point(15, 82);
            this.electrocardiographyBox.Margin = new System.Windows.Forms.Padding(4);
            this.electrocardiographyBox.Name = "electrocardiographyBox";
            this.electrocardiographyBox.Padding = new System.Windows.Forms.Padding(4);
            this.electrocardiographyBox.Size = new System.Drawing.Size(245, 175);
            this.electrocardiographyBox.TabIndex = 12;
            this.electrocardiographyBox.TabStop = false;
            this.electrocardiographyBox.Text = "Electrocardiography";
            // 
            // generateECGButton
            // 
            this.generateECGButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generateECGButton.FlatAppearance.BorderSize = 0;
            this.generateECGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateECGButton.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateECGButton.ForeColor = System.Drawing.Color.White;
            this.generateECGButton.Location = new System.Drawing.Point(196, 26);
            this.generateECGButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateECGButton.Name = "generateECGButton";
            this.generateECGButton.Size = new System.Drawing.Size(39, 36);
            this.generateECGButton.TabIndex = 1;
            this.generateECGButton.Text = "P";
            this.generateECGButton.UseVisualStyleBackColor = false;
            this.generateECGButton.Click += new System.EventHandler(this.GenerateECG);
            // 
            // generateHeartRateButton
            // 
            this.generateHeartRateButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generateHeartRateButton.FlatAppearance.BorderSize = 0;
            this.generateHeartRateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateHeartRateButton.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateHeartRateButton.ForeColor = System.Drawing.Color.White;
            this.generateHeartRateButton.Location = new System.Drawing.Point(196, 97);
            this.generateHeartRateButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateHeartRateButton.Name = "generateHeartRateButton";
            this.generateHeartRateButton.Size = new System.Drawing.Size(39, 36);
            this.generateHeartRateButton.TabIndex = 2;
            this.generateHeartRateButton.Text = "P";
            this.generateHeartRateButton.UseVisualStyleBackColor = false;
            this.generateHeartRateButton.Click += new System.EventHandler(this.GenerateHeartRate);
            // 
            // eCGPanel
            // 
            this.eCGPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eCGPanel.Controls.Add(this.eCGGeneratedLabel);
            this.eCGPanel.Controls.Add(this.eCGLabel);
            this.eCGPanel.Location = new System.Drawing.Point(8, 26);
            this.eCGPanel.Margin = new System.Windows.Forms.Padding(4);
            this.eCGPanel.Name = "eCGPanel";
            this.eCGPanel.Size = new System.Drawing.Size(180, 63);
            this.eCGPanel.TabIndex = 17;
            // 
            // eCGGeneratedLabel
            // 
            this.eCGGeneratedLabel.AutoSize = true;
            this.eCGGeneratedLabel.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eCGGeneratedLabel.ForeColor = System.Drawing.Color.Green;
            this.eCGGeneratedLabel.Location = new System.Drawing.Point(5, 28);
            this.eCGGeneratedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eCGGeneratedLabel.Name = "eCGGeneratedLabel";
            this.eCGGeneratedLabel.Size = new System.Drawing.Size(172, 21);
            this.eCGGeneratedLabel.TabIndex = 18;
            this.eCGGeneratedLabel.Text = "ECG-12 Generated";
            this.eCGGeneratedLabel.Visible = false;
            // 
            // eCGLabel
            // 
            this.eCGLabel.AutoSize = true;
            this.eCGLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eCGLabel.Location = new System.Drawing.Point(1, 1);
            this.eCGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eCGLabel.Name = "eCGLabel";
            this.eCGLabel.Size = new System.Drawing.Size(69, 19);
            this.eCGLabel.TabIndex = 0;
            this.eCGLabel.Text = "ECG-12";
            // 
            // heartRatePanel
            // 
            this.heartRatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heartRatePanel.Controls.Add(this.heartRateMeasurementLabel);
            this.heartRatePanel.Controls.Add(this.heartRateUnitLabel);
            this.heartRatePanel.Controls.Add(this.heartRateLabel);
            this.heartRatePanel.Location = new System.Drawing.Point(8, 97);
            this.heartRatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.heartRatePanel.Name = "heartRatePanel";
            this.heartRatePanel.Size = new System.Drawing.Size(180, 63);
            this.heartRatePanel.TabIndex = 17;
            // 
            // heartRateMeasurementLabel
            // 
            this.heartRateMeasurementLabel.AutoSize = true;
            this.heartRateMeasurementLabel.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heartRateMeasurementLabel.Location = new System.Drawing.Point(77, 3);
            this.heartRateMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heartRateMeasurementLabel.Name = "heartRateMeasurementLabel";
            this.heartRateMeasurementLabel.Size = new System.Drawing.Size(72, 55);
            this.heartRateMeasurementLabel.TabIndex = 18;
            this.heartRateMeasurementLabel.Text = "---";
            // 
            // heartRateUnitLabel
            // 
            this.heartRateUnitLabel.AutoSize = true;
            this.heartRateUnitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heartRateUnitLabel.Location = new System.Drawing.Point(1, 41);
            this.heartRateUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heartRateUnitLabel.Name = "heartRateUnitLabel";
            this.heartRateUnitLabel.Size = new System.Drawing.Size(51, 19);
            this.heartRateUnitLabel.TabIndex = 1;
            this.heartRateUnitLabel.Text = "1/min";
            // 
            // heartRateLabel
            // 
            this.heartRateLabel.AutoSize = true;
            this.heartRateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heartRateLabel.Location = new System.Drawing.Point(1, 1);
            this.heartRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heartRateLabel.Name = "heartRateLabel";
            this.heartRateLabel.Size = new System.Drawing.Size(57, 19);
            this.heartRateLabel.TabIndex = 0;
            this.heartRateLabel.Text = "Heart.";
            // 
            // patientTypeComboBox
            // 
            this.patientTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientTypeComboBox.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientTypeComboBox.FormattingEnabled = true;
            this.patientTypeComboBox.Items.AddRange(new object[] {
            "Healthy",
            "Stroke",
            "COPD",
            "COVID-19"});
            this.patientTypeComboBox.Location = new System.Drawing.Point(210, 34);
            this.patientTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.patientTypeComboBox.Name = "patientTypeComboBox";
            this.patientTypeComboBox.Size = new System.Drawing.Size(127, 27);
            this.patientTypeComboBox.TabIndex = 13;
            this.patientTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // generateMonitorEventButton
            // 
            this.generateMonitorEventButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.generateMonitorEventButton.FlatAppearance.BorderSize = 0;
            this.generateMonitorEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateMonitorEventButton.Font = new System.Drawing.Font("Wingdings", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateMonitorEventButton.ForeColor = System.Drawing.Color.White;
            this.generateMonitorEventButton.Location = new System.Drawing.Point(473, 14);
            this.generateMonitorEventButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateMonitorEventButton.Name = "generateMonitorEventButton";
            this.generateMonitorEventButton.Size = new System.Drawing.Size(51, 48);
            this.generateMonitorEventButton.TabIndex = 14;
            this.generateMonitorEventButton.Text = "O";
            this.generateMonitorEventButton.UseVisualStyleBackColor = false;
            this.generateMonitorEventButton.Click += new System.EventHandler(this.GenerateMonitorEvent);
            // 
            // patientTypeLabel
            // 
            this.patientTypeLabel.AutoSize = true;
            this.patientTypeLabel.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientTypeLabel.Location = new System.Drawing.Point(210, 12);
            this.patientTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientTypeLabel.Name = "patientTypeLabel";
            this.patientTypeLabel.Size = new System.Drawing.Size(115, 21);
            this.patientTypeLabel.TabIndex = 15;
            this.patientTypeLabel.Text = "Patient type";
            // 
            // monitorEventGeneratedLabel
            // 
            this.monitorEventGeneratedLabel.AutoSize = true;
            this.monitorEventGeneratedLabel.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monitorEventGeneratedLabel.ForeColor = System.Drawing.Color.Green;
            this.monitorEventGeneratedLabel.Location = new System.Drawing.Point(365, 19);
            this.monitorEventGeneratedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monitorEventGeneratedLabel.Name = "monitorEventGeneratedLabel";
            this.monitorEventGeneratedLabel.Size = new System.Drawing.Size(102, 42);
            this.monitorEventGeneratedLabel.TabIndex = 18;
            this.monitorEventGeneratedLabel.Text = "Event\nGenerated";
            this.monitorEventGeneratedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monitorEventGeneratedLabel.Visible = false;
            // 
            // oximetryBox
            // 
            this.oximetryBox.Controls.Add(this.generateSp02Button);
            this.oximetryBox.Controls.Add(this.generatePulseButton);
            this.oximetryBox.Controls.Add(this.spO2Panel);
            this.oximetryBox.Controls.Add(this.pulsePanel);
            this.oximetryBox.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oximetryBox.Location = new System.Drawing.Point(15, 265);
            this.oximetryBox.Margin = new System.Windows.Forms.Padding(4);
            this.oximetryBox.Name = "oximetryBox";
            this.oximetryBox.Padding = new System.Windows.Forms.Padding(4);
            this.oximetryBox.Size = new System.Drawing.Size(245, 175);
            this.oximetryBox.TabIndex = 12;
            this.oximetryBox.TabStop = false;
            this.oximetryBox.Text = "Oximetry";
            // 
            // generateSp02Button
            // 
            this.generateSp02Button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generateSp02Button.FlatAppearance.BorderSize = 0;
            this.generateSp02Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateSp02Button.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateSp02Button.ForeColor = System.Drawing.Color.White;
            this.generateSp02Button.Location = new System.Drawing.Point(196, 26);
            this.generateSp02Button.Margin = new System.Windows.Forms.Padding(4);
            this.generateSp02Button.Name = "generateSp02Button";
            this.generateSp02Button.Size = new System.Drawing.Size(39, 36);
            this.generateSp02Button.TabIndex = 5;
            this.generateSp02Button.Text = "P";
            this.generateSp02Button.UseVisualStyleBackColor = false;
            this.generateSp02Button.Click += new System.EventHandler(this.GenerateSpO2);
            // 
            // generatePulseButton
            // 
            this.generatePulseButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generatePulseButton.FlatAppearance.BorderSize = 0;
            this.generatePulseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePulseButton.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generatePulseButton.ForeColor = System.Drawing.Color.White;
            this.generatePulseButton.Location = new System.Drawing.Point(196, 97);
            this.generatePulseButton.Margin = new System.Windows.Forms.Padding(4);
            this.generatePulseButton.Name = "generatePulseButton";
            this.generatePulseButton.Size = new System.Drawing.Size(39, 36);
            this.generatePulseButton.TabIndex = 6;
            this.generatePulseButton.Text = "P";
            this.generatePulseButton.UseVisualStyleBackColor = false;
            this.generatePulseButton.Click += new System.EventHandler(this.GeneratePulse);
            // 
            // spO2Panel
            // 
            this.spO2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spO2Panel.Controls.Add(this.spO2MeasurementLabel);
            this.spO2Panel.Controls.Add(this.spO2UnitLabel);
            this.spO2Panel.Controls.Add(this.spO2Label);
            this.spO2Panel.Location = new System.Drawing.Point(8, 26);
            this.spO2Panel.Margin = new System.Windows.Forms.Padding(4);
            this.spO2Panel.Name = "spO2Panel";
            this.spO2Panel.Size = new System.Drawing.Size(180, 63);
            this.spO2Panel.TabIndex = 17;
            // 
            // spO2MeasurementLabel
            // 
            this.spO2MeasurementLabel.AutoSize = true;
            this.spO2MeasurementLabel.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spO2MeasurementLabel.Location = new System.Drawing.Point(77, 3);
            this.spO2MeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spO2MeasurementLabel.Name = "spO2MeasurementLabel";
            this.spO2MeasurementLabel.Size = new System.Drawing.Size(72, 55);
            this.spO2MeasurementLabel.TabIndex = 18;
            this.spO2MeasurementLabel.Text = "---";
            // 
            // spO2UnitLabel
            // 
            this.spO2UnitLabel.AutoSize = true;
            this.spO2UnitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spO2UnitLabel.Location = new System.Drawing.Point(1, 41);
            this.spO2UnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spO2UnitLabel.Name = "spO2UnitLabel";
            this.spO2UnitLabel.Size = new System.Drawing.Size(25, 19);
            this.spO2UnitLabel.TabIndex = 1;
            this.spO2UnitLabel.Text = "%";
            // 
            // spO2Label
            // 
            this.spO2Label.AutoSize = true;
            this.spO2Label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spO2Label.Location = new System.Drawing.Point(1, 1);
            this.spO2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spO2Label.Name = "spO2Label";
            this.spO2Label.Size = new System.Drawing.Size(48, 19);
            this.spO2Label.TabIndex = 0;
            this.spO2Label.Text = "Sp02";
            // 
            // pulsePanel
            // 
            this.pulsePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pulsePanel.Controls.Add(this.pulseMeasurementLabel);
            this.pulsePanel.Controls.Add(this.pulseUnitLabel);
            this.pulsePanel.Controls.Add(this.pulseLabel);
            this.pulsePanel.Location = new System.Drawing.Point(8, 97);
            this.pulsePanel.Margin = new System.Windows.Forms.Padding(4);
            this.pulsePanel.Name = "pulsePanel";
            this.pulsePanel.Size = new System.Drawing.Size(180, 63);
            this.pulsePanel.TabIndex = 17;
            // 
            // pulseMeasurementLabel
            // 
            this.pulseMeasurementLabel.AutoSize = true;
            this.pulseMeasurementLabel.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pulseMeasurementLabel.Location = new System.Drawing.Point(77, 3);
            this.pulseMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pulseMeasurementLabel.Name = "pulseMeasurementLabel";
            this.pulseMeasurementLabel.Size = new System.Drawing.Size(72, 55);
            this.pulseMeasurementLabel.TabIndex = 18;
            this.pulseMeasurementLabel.Text = "---";
            // 
            // pulseUnitLabel
            // 
            this.pulseUnitLabel.AutoSize = true;
            this.pulseUnitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pulseUnitLabel.Location = new System.Drawing.Point(1, 41);
            this.pulseUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pulseUnitLabel.Name = "pulseUnitLabel";
            this.pulseUnitLabel.Size = new System.Drawing.Size(51, 19);
            this.pulseUnitLabel.TabIndex = 1;
            this.pulseUnitLabel.Text = "1/min";
            // 
            // pulseLabel
            // 
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pulseLabel.Location = new System.Drawing.Point(1, 1);
            this.pulseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(52, 19);
            this.pulseLabel.TabIndex = 0;
            this.pulseLabel.Text = "Pulse";
            // 
            // bloodPressureBox
            // 
            this.bloodPressureBox.Controls.Add(this.generateNIBPButton);
            this.bloodPressureBox.Controls.Add(this.generateIBPButton);
            this.bloodPressureBox.Controls.Add(this.iBPPanel);
            this.bloodPressureBox.Controls.Add(this.nIBPPanel);
            this.bloodPressureBox.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodPressureBox.Location = new System.Drawing.Point(279, 82);
            this.bloodPressureBox.Margin = new System.Windows.Forms.Padding(4);
            this.bloodPressureBox.Name = "bloodPressureBox";
            this.bloodPressureBox.Padding = new System.Windows.Forms.Padding(4);
            this.bloodPressureBox.Size = new System.Drawing.Size(245, 175);
            this.bloodPressureBox.TabIndex = 12;
            this.bloodPressureBox.TabStop = false;
            this.bloodPressureBox.Text = "Blood Pressure";
            // 
            // generateNIBPButton
            // 
            this.generateNIBPButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generateNIBPButton.FlatAppearance.BorderSize = 0;
            this.generateNIBPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateNIBPButton.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateNIBPButton.ForeColor = System.Drawing.Color.White;
            this.generateNIBPButton.Location = new System.Drawing.Point(196, 26);
            this.generateNIBPButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateNIBPButton.Name = "generateNIBPButton";
            this.generateNIBPButton.Size = new System.Drawing.Size(39, 36);
            this.generateNIBPButton.TabIndex = 3;
            this.generateNIBPButton.Text = "P";
            this.generateNIBPButton.UseVisualStyleBackColor = false;
            this.generateNIBPButton.Click += new System.EventHandler(this.GenerateNIBP);
            // 
            // generateIBPButton
            // 
            this.generateIBPButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generateIBPButton.FlatAppearance.BorderSize = 0;
            this.generateIBPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateIBPButton.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateIBPButton.ForeColor = System.Drawing.Color.White;
            this.generateIBPButton.Location = new System.Drawing.Point(196, 97);
            this.generateIBPButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateIBPButton.Name = "generateIBPButton";
            this.generateIBPButton.Size = new System.Drawing.Size(39, 36);
            this.generateIBPButton.TabIndex = 4;
            this.generateIBPButton.Text = "P";
            this.generateIBPButton.UseVisualStyleBackColor = false;
            this.generateIBPButton.Click += new System.EventHandler(this.GenerateIBP);
            // 
            // iBPPanel
            // 
            this.iBPPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iBPPanel.Controls.Add(this.iBPMeasurementLabel);
            this.iBPPanel.Controls.Add(this.iBPUnitLabel);
            this.iBPPanel.Controls.Add(this.iBPLabel);
            this.iBPPanel.Location = new System.Drawing.Point(8, 97);
            this.iBPPanel.Margin = new System.Windows.Forms.Padding(4);
            this.iBPPanel.Name = "iBPPanel";
            this.iBPPanel.Size = new System.Drawing.Size(180, 63);
            this.iBPPanel.TabIndex = 17;
            // 
            // iBPMeasurementLabel
            // 
            this.iBPMeasurementLabel.AutoSize = true;
            this.iBPMeasurementLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iBPMeasurementLabel.Location = new System.Drawing.Point(75, 1);
            this.iBPMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iBPMeasurementLabel.Name = "iBPMeasurementLabel";
            this.iBPMeasurementLabel.Size = new System.Drawing.Size(68, 58);
            this.iBPMeasurementLabel.TabIndex = 18;
            this.iBPMeasurementLabel.Text = "---/---\n (---)";
            // 
            // iBPUnitLabel
            // 
            this.iBPUnitLabel.AutoSize = true;
            this.iBPUnitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iBPUnitLabel.Location = new System.Drawing.Point(1, 41);
            this.iBPUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iBPUnitLabel.Name = "iBPUnitLabel";
            this.iBPUnitLabel.Size = new System.Drawing.Size(59, 19);
            this.iBPUnitLabel.TabIndex = 1;
            this.iBPUnitLabel.Text = "mmHg";
            // 
            // iBPLabel
            // 
            this.iBPLabel.AutoSize = true;
            this.iBPLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iBPLabel.Location = new System.Drawing.Point(1, 1);
            this.iBPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iBPLabel.Name = "iBPLabel";
            this.iBPLabel.Size = new System.Drawing.Size(36, 19);
            this.iBPLabel.TabIndex = 0;
            this.iBPLabel.Text = "IBP";
            // 
            // nIBPPanel
            // 
            this.nIBPPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nIBPPanel.Controls.Add(this.nIBPMeasurementLabel);
            this.nIBPPanel.Controls.Add(this.nIBPUnitLabel);
            this.nIBPPanel.Controls.Add(this.nIBPLabel);
            this.nIBPPanel.Location = new System.Drawing.Point(8, 26);
            this.nIBPPanel.Margin = new System.Windows.Forms.Padding(4);
            this.nIBPPanel.Name = "nIBPPanel";
            this.nIBPPanel.Size = new System.Drawing.Size(180, 63);
            this.nIBPPanel.TabIndex = 17;
            // 
            // nIBPMeasurementLabel
            // 
            this.nIBPMeasurementLabel.AutoSize = true;
            this.nIBPMeasurementLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nIBPMeasurementLabel.Location = new System.Drawing.Point(75, 1);
            this.nIBPMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nIBPMeasurementLabel.Name = "nIBPMeasurementLabel";
            this.nIBPMeasurementLabel.Size = new System.Drawing.Size(68, 58);
            this.nIBPMeasurementLabel.TabIndex = 18;
            this.nIBPMeasurementLabel.Text = "---/---\n (---)";
            // 
            // nIBPUnitLabel
            // 
            this.nIBPUnitLabel.AutoSize = true;
            this.nIBPUnitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nIBPUnitLabel.Location = new System.Drawing.Point(1, 41);
            this.nIBPUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nIBPUnitLabel.Name = "nIBPUnitLabel";
            this.nIBPUnitLabel.Size = new System.Drawing.Size(59, 19);
            this.nIBPUnitLabel.TabIndex = 1;
            this.nIBPUnitLabel.Text = "mmHg";
            // 
            // nIBPLabel
            // 
            this.nIBPLabel.AutoSize = true;
            this.nIBPLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nIBPLabel.Location = new System.Drawing.Point(1, 1);
            this.nIBPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nIBPLabel.Name = "nIBPLabel";
            this.nIBPLabel.Size = new System.Drawing.Size(48, 19);
            this.nIBPLabel.TabIndex = 0;
            this.nIBPLabel.Text = "NIBP";
            // 
            // capnormetryBox
            // 
            this.capnormetryBox.Controls.Add(this.generateCO2Button);
            this.capnormetryBox.Controls.Add(this.generateRespiratoryRateButton);
            this.capnormetryBox.Controls.Add(this.cO2Panel);
            this.capnormetryBox.Controls.Add(this.respiratoryRatePanel);
            this.capnormetryBox.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.capnormetryBox.Location = new System.Drawing.Point(279, 265);
            this.capnormetryBox.Margin = new System.Windows.Forms.Padding(4);
            this.capnormetryBox.Name = "capnormetryBox";
            this.capnormetryBox.Padding = new System.Windows.Forms.Padding(4);
            this.capnormetryBox.Size = new System.Drawing.Size(245, 175);
            this.capnormetryBox.TabIndex = 12;
            this.capnormetryBox.TabStop = false;
            this.capnormetryBox.Text = "Capnometry";
            // 
            // generateCO2Button
            // 
            this.generateCO2Button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generateCO2Button.FlatAppearance.BorderSize = 0;
            this.generateCO2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateCO2Button.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateCO2Button.ForeColor = System.Drawing.Color.White;
            this.generateCO2Button.Location = new System.Drawing.Point(196, 26);
            this.generateCO2Button.Margin = new System.Windows.Forms.Padding(4);
            this.generateCO2Button.Name = "generateCO2Button";
            this.generateCO2Button.Size = new System.Drawing.Size(39, 36);
            this.generateCO2Button.TabIndex = 7;
            this.generateCO2Button.Text = "P";
            this.generateCO2Button.UseVisualStyleBackColor = false;
            this.generateCO2Button.Click += new System.EventHandler(this.GenerateCO2);
            // 
            // generateRespiratoryRateButton
            // 
            this.generateRespiratoryRateButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generateRespiratoryRateButton.FlatAppearance.BorderSize = 0;
            this.generateRespiratoryRateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateRespiratoryRateButton.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateRespiratoryRateButton.ForeColor = System.Drawing.Color.White;
            this.generateRespiratoryRateButton.Location = new System.Drawing.Point(196, 97);
            this.generateRespiratoryRateButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateRespiratoryRateButton.Name = "generateRespiratoryRateButton";
            this.generateRespiratoryRateButton.Size = new System.Drawing.Size(39, 36);
            this.generateRespiratoryRateButton.TabIndex = 8;
            this.generateRespiratoryRateButton.Text = "P";
            this.generateRespiratoryRateButton.UseVisualStyleBackColor = false;
            this.generateRespiratoryRateButton.Click += new System.EventHandler(this.GenerateRespiratoryRate);
            // 
            // cO2Panel
            // 
            this.cO2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cO2Panel.Controls.Add(this.cO2MeasurementLabel);
            this.cO2Panel.Controls.Add(this.cO2UnitLabel);
            this.cO2Panel.Controls.Add(this.cO2Label);
            this.cO2Panel.Location = new System.Drawing.Point(8, 26);
            this.cO2Panel.Margin = new System.Windows.Forms.Padding(4);
            this.cO2Panel.Name = "cO2Panel";
            this.cO2Panel.Size = new System.Drawing.Size(180, 63);
            this.cO2Panel.TabIndex = 17;
            // 
            // cO2MeasurementLabel
            // 
            this.cO2MeasurementLabel.AutoSize = true;
            this.cO2MeasurementLabel.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cO2MeasurementLabel.Location = new System.Drawing.Point(77, 3);
            this.cO2MeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cO2MeasurementLabel.Name = "cO2MeasurementLabel";
            this.cO2MeasurementLabel.Size = new System.Drawing.Size(72, 55);
            this.cO2MeasurementLabel.TabIndex = 18;
            this.cO2MeasurementLabel.Text = "---";
            // 
            // cO2UnitLabel
            // 
            this.cO2UnitLabel.AutoSize = true;
            this.cO2UnitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cO2UnitLabel.Location = new System.Drawing.Point(1, 41);
            this.cO2UnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cO2UnitLabel.Name = "cO2UnitLabel";
            this.cO2UnitLabel.Size = new System.Drawing.Size(59, 19);
            this.cO2UnitLabel.TabIndex = 1;
            this.cO2UnitLabel.Text = "mmHg";
            // 
            // cO2Label
            // 
            this.cO2Label.AutoSize = true;
            this.cO2Label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cO2Label.Location = new System.Drawing.Point(1, 1);
            this.cO2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cO2Label.Name = "cO2Label";
            this.cO2Label.Size = new System.Drawing.Size(43, 19);
            this.cO2Label.TabIndex = 0;
            this.cO2Label.Text = "CO2";
            // 
            // respiratoryRatePanel
            // 
            this.respiratoryRatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.respiratoryRatePanel.Controls.Add(this.respiratoryRateMeasurementLabel);
            this.respiratoryRatePanel.Controls.Add(this.respiratoryRateUnitLabel);
            this.respiratoryRatePanel.Controls.Add(this.respiratoryRateLabel);
            this.respiratoryRatePanel.Location = new System.Drawing.Point(8, 97);
            this.respiratoryRatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.respiratoryRatePanel.Name = "respiratoryRatePanel";
            this.respiratoryRatePanel.Size = new System.Drawing.Size(180, 63);
            this.respiratoryRatePanel.TabIndex = 17;
            // 
            // respiratoryRateMeasurementLabel
            // 
            this.respiratoryRateMeasurementLabel.AutoSize = true;
            this.respiratoryRateMeasurementLabel.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.respiratoryRateMeasurementLabel.Location = new System.Drawing.Point(77, 3);
            this.respiratoryRateMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.respiratoryRateMeasurementLabel.Name = "respiratoryRateMeasurementLabel";
            this.respiratoryRateMeasurementLabel.Size = new System.Drawing.Size(72, 55);
            this.respiratoryRateMeasurementLabel.TabIndex = 18;
            this.respiratoryRateMeasurementLabel.Text = "---";
            // 
            // respiratoryRateUnitLabel
            // 
            this.respiratoryRateUnitLabel.AutoSize = true;
            this.respiratoryRateUnitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.respiratoryRateUnitLabel.Location = new System.Drawing.Point(1, 41);
            this.respiratoryRateUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.respiratoryRateUnitLabel.Name = "respiratoryRateUnitLabel";
            this.respiratoryRateUnitLabel.Size = new System.Drawing.Size(51, 19);
            this.respiratoryRateUnitLabel.TabIndex = 1;
            this.respiratoryRateUnitLabel.Text = "1/min";
            // 
            // respiratoryRateLabel
            // 
            this.respiratoryRateLabel.AutoSize = true;
            this.respiratoryRateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.respiratoryRateLabel.Location = new System.Drawing.Point(1, 1);
            this.respiratoryRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.respiratoryRateLabel.Name = "respiratoryRateLabel";
            this.respiratoryRateLabel.Size = new System.Drawing.Size(54, 19);
            this.respiratoryRateLabel.TabIndex = 0;
            this.respiratoryRateLabel.Text = "Resp.";
            // 
            // temperatureBox
            // 
            this.temperatureBox.Controls.Add(this.generateTemperatureButton);
            this.temperatureBox.Controls.Add(this.temperaturePanel);
            this.temperatureBox.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperatureBox.Location = new System.Drawing.Point(15, 448);
            this.temperatureBox.Margin = new System.Windows.Forms.Padding(4);
            this.temperatureBox.Name = "temperatureBox";
            this.temperatureBox.Padding = new System.Windows.Forms.Padding(4);
            this.temperatureBox.Size = new System.Drawing.Size(245, 103);
            this.temperatureBox.TabIndex = 12;
            this.temperatureBox.TabStop = false;
            this.temperatureBox.Text = "Temperature";
            // 
            // generateTemperatureButton
            // 
            this.generateTemperatureButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generateTemperatureButton.FlatAppearance.BorderSize = 0;
            this.generateTemperatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateTemperatureButton.Font = new System.Drawing.Font("Wingdings 3", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateTemperatureButton.ForeColor = System.Drawing.Color.White;
            this.generateTemperatureButton.Location = new System.Drawing.Point(196, 26);
            this.generateTemperatureButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateTemperatureButton.Name = "generateTemperatureButton";
            this.generateTemperatureButton.Size = new System.Drawing.Size(39, 36);
            this.generateTemperatureButton.TabIndex = 9;
            this.generateTemperatureButton.Text = "P";
            this.generateTemperatureButton.UseVisualStyleBackColor = false;
            this.generateTemperatureButton.Click += new System.EventHandler(this.GenerateTemperature);
            // 
            // temperaturePanel
            // 
            this.temperaturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperaturePanel.Controls.Add(this.temperatureMeasurementLabel);
            this.temperaturePanel.Controls.Add(this.temperatureUnitLabel);
            this.temperaturePanel.Controls.Add(this.temperatureLabel);
            this.temperaturePanel.Location = new System.Drawing.Point(8, 26);
            this.temperaturePanel.Margin = new System.Windows.Forms.Padding(4);
            this.temperaturePanel.Name = "temperaturePanel";
            this.temperaturePanel.Size = new System.Drawing.Size(180, 63);
            this.temperaturePanel.TabIndex = 17;
            // 
            // temperatureMeasurementLabel
            // 
            this.temperatureMeasurementLabel.AutoSize = true;
            this.temperatureMeasurementLabel.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperatureMeasurementLabel.Location = new System.Drawing.Point(64, 3);
            this.temperatureMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureMeasurementLabel.Name = "temperatureMeasurementLabel";
            this.temperatureMeasurementLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.temperatureMeasurementLabel.Size = new System.Drawing.Size(98, 55);
            this.temperatureMeasurementLabel.TabIndex = 18;
            this.temperatureMeasurementLabel.Text = " --- ";
            this.temperatureMeasurementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperatureUnitLabel
            // 
            this.temperatureUnitLabel.AutoSize = true;
            this.temperatureUnitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperatureUnitLabel.Location = new System.Drawing.Point(1, 41);
            this.temperatureUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureUnitLabel.Name = "temperatureUnitLabel";
            this.temperatureUnitLabel.Size = new System.Drawing.Size(28, 19);
            this.temperatureUnitLabel.TabIndex = 1;
            this.temperatureUnitLabel.Text = "°C";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperatureLabel.Location = new System.Drawing.Point(1, 1);
            this.temperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(56, 19);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "Temp.";
            // 
            // WinApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 567);
            this.Controls.Add(this.monitorEventGeneratedLabel);
            this.Controls.Add(this.patientTypeLabel);
            this.Controls.Add(this.generateMonitorEventButton);
            this.Controls.Add(this.patientTypeComboBox);
            this.Controls.Add(this.temperatureBox);
            this.Controls.Add(this.bloodPressureBox);
            this.Controls.Add(this.capnormetryBox);
            this.Controls.Add(this.oximetryBox);
            this.Controls.Add(this.electrocardiographyBox);
            this.Controls.Add(this.oFFButton);
            this.Controls.Add(this.oNButton);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WinApp";
            this.Text = "Amphi Monitor";
            this.Load += new System.EventHandler(this.AmphiMonitorUI_Load);
            this.electrocardiographyBox.ResumeLayout(false);
            this.eCGPanel.ResumeLayout(false);
            this.eCGPanel.PerformLayout();
            this.heartRatePanel.ResumeLayout(false);
            this.heartRatePanel.PerformLayout();
            this.oximetryBox.ResumeLayout(false);
            this.spO2Panel.ResumeLayout(false);
            this.spO2Panel.PerformLayout();
            this.pulsePanel.ResumeLayout(false);
            this.pulsePanel.PerformLayout();
            this.bloodPressureBox.ResumeLayout(false);
            this.iBPPanel.ResumeLayout(false);
            this.iBPPanel.PerformLayout();
            this.nIBPPanel.ResumeLayout(false);
            this.nIBPPanel.PerformLayout();
            this.capnormetryBox.ResumeLayout(false);
            this.cO2Panel.ResumeLayout(false);
            this.cO2Panel.PerformLayout();
            this.respiratoryRatePanel.ResumeLayout(false);
            this.respiratoryRatePanel.PerformLayout();
            this.temperatureBox.ResumeLayout(false);
            this.temperaturePanel.ResumeLayout(false);
            this.temperaturePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button oNButton;
        private Button oFFButton;
        private GroupBox electrocardiographyBox;
        private ComboBox patientTypeComboBox;
        private Button generateMonitorEventButton;
        private Label patientTypeLabel;
        private Button generateHeartRateButton;
        private Panel heartRatePanel;
        private Label heartRateMeasurementLabel;
        private Label heartRateUnitLabel;
        private Label heartRateLabel;
        private Button generateECGButton;
        private Panel eCGPanel;
        private Label eCGGeneratedLabel;
        private Label eCGLabel;
        private Label monitorEventGeneratedLabel;
        private GroupBox oximetryBox;
        private Button generateSp02Button;
        private Button generatePulseButton;
        private Panel spO2Panel;
        private Label spO2MeasurementLabel;
        private Label spO2UnitLabel;
        private Label spO2Label;
        private Panel pulsePanel;
        private Label pulseMeasurementLabel;
        private Label pulseUnitLabel;
        private Label pulseLabel;
        private GroupBox bloodPressureBox;
        private Button generateNIBPButton;
        private Button generateIBPButton;
        private Panel nIBPPanel;
        private Label nIBPMeasurementLabel;
        private Label nIBPUnitLabel;
        private Label nIBPLabel;
        private GroupBox capnormetryBox;
        private Button generateCO2Button;
        private Button generateRespiratoryRateButton;
        private Panel cO2Panel;
        private Label cO2MeasurementLabel;
        private Label cO2UnitLabel;
        private Label cO2Label;
        private Panel respiratoryRatePanel;
        private Label respiratoryRateMeasurementLabel;
        private Label respiratoryRateUnitLabel;
        private Label respiratoryRateLabel;
        private GroupBox temperatureBox;
        private Button generateTemperatureButton;
        private Panel temperaturePanel;
        private Label temperatureMeasurementLabel;
        private Label temperatureUnitLabel;
        private Label temperatureLabel;
        private Panel iBPPanel;
        private Label iBPMeasurementLabel;
        private Label iBPUnitLabel;
        private Label iBPLabel;
    }
}