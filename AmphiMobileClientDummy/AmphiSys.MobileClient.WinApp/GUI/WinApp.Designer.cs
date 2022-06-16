namespace AmphiSys.MobileClient.WinApp
{
    partial class WinApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.monitorSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.monitorSelectionLabel = new System.Windows.Forms.Label();
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.monitorDataListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // monitorSelectionComboBox
            // 
            this.monitorSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorSelectionComboBox.FormattingEnabled = true;
            this.monitorSelectionComboBox.Items.AddRange(new object[] {
            "AmphiMonitor",
            "Corpuls3"});
            this.monitorSelectionComboBox.Location = new System.Drawing.Point(90, 36);
            this.monitorSelectionComboBox.Name = "monitorSelectionComboBox";
            this.monitorSelectionComboBox.Size = new System.Drawing.Size(134, 23);
            this.monitorSelectionComboBox.TabIndex = 0;
            this.monitorSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.monitorSelectionComboBox_SelectedIndexChanged);
            // 
            // monitorSelectionLabel
            // 
            this.monitorSelectionLabel.AutoSize = true;
            this.monitorSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monitorSelectionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monitorSelectionLabel.Location = new System.Drawing.Point(90, 14);
            this.monitorSelectionLabel.Name = "monitorSelectionLabel";
            this.monitorSelectionLabel.Size = new System.Drawing.Size(63, 19);
            this.monitorSelectionLabel.TabIndex = 1;
            this.monitorSelectionLabel.Text = "Monitor";
            // 
            // onButton
            // 
            this.onButton.Location = new System.Drawing.Point(12, 12);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(45, 23);
            this.onButton.TabIndex = 2;
            this.onButton.Text = "ON";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.ConnnectMonitor);
            this.onButton.Click += new System.EventHandler(this.StartTimer);
            // 
            // offButton
            // 
            this.offButton.Location = new System.Drawing.Point(13, 41);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(44, 23);
            this.offButton.TabIndex = 3;
            this.offButton.Text = "OFF";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.StopTimer);
            this.offButton.Click += new System.EventHandler(this.DisconnectMonitor);
            // 
            // monitorDataListView
            // 
            this.monitorDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.monitorDataListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.monitorDataListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.monitorDataListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.monitorDataListView.Location = new System.Drawing.Point(13, 70);
            this.monitorDataListView.Name = "monitorDataListView";
            this.monitorDataListView.Size = new System.Drawing.Size(419, 368);
            this.monitorDataListView.TabIndex = 4;
            this.monitorDataListView.UseCompatibleStateImageBehavior = false;
            this.monitorDataListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 350;
            // 
            // WinApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(444, 459);
            this.Controls.Add(this.monitorDataListView);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.onButton);
            this.Controls.Add(this.monitorSelectionLabel);
            this.Controls.Add(this.monitorSelectionComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WinApp";
            this.Text = "amPHI³";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox monitorSelectionComboBox;
        private Label monitorSelectionLabel;
        private Button onButton;
        private Button offButton;
        private ListView monitorDataListView;
        private ColumnHeader columnHeader1;
    }
}