namespace ASCOM.PentaxKR
{
    partial class SetupDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDialogForm));
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.comboBoxCamera = new System.Windows.Forms.ComboBox();
            this.selectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxCameraBatteryLevel = new System.Windows.Forms.TextBox();
            this.labelCameraBatteryLevel = new System.Windows.Forms.Label();
            this.textBoxCameraISO = new System.Windows.Forms.TextBox();
            this.labelCameraISO = new System.Windows.Forms.Label();
            this.textBoxCameraExposureTime = new System.Windows.Forms.TextBox();
            this.textBoxCameraCompressionMode = new System.Windows.Forms.TextBox();
            this.textBoxCameraMode = new System.Windows.Forms.TextBox();
            this.textBoxCameraConnected = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOutputFormat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPersonality = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.selectCameraTab = new System.Windows.Forms.TabPage();
            this.cameraPersonalityTab = new System.Windows.Forms.TabPage();
            this.driverSettingsTab = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxSerialRelay = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxKeepInterimFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxBulbMode = new System.Windows.Forms.CheckBox();
            this.extrasTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.modeWarning = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picASCOM = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.selectCameraTab.SuspendLayout();
            this.cameraPersonalityTab.SuspendLayout();
            this.driverSettingsTab.SuspendLayout();
            this.extrasTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(629, 482);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(78, 30);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(542, 482);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(78, 30);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the camera you\'d like to work with. (Only devices currently connect" +
    "ed and recognized by Windows are listed)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera";
            // 
            // chkTrace
            // 
            this.chkTrace.AutoSize = true;
            this.chkTrace.Location = new System.Drawing.Point(11, 137);
            this.chkTrace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(220, 20);
            this.chkTrace.TabIndex = 4;
            this.chkTrace.Text = "Driver Trace on (Write to log file)";
            this.chkTrace.UseVisualStyleBackColor = true;
            // 
            // comboBoxCamera
            // 
            this.comboBoxCamera.AccessibleName = "Pentax KR/K5II Camera Selection";
            this.comboBoxCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCamera.FormattingEnabled = true;
            this.comboBoxCamera.Location = new System.Drawing.Point(98, 86);
            this.comboBoxCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCamera.Name = "comboBoxCamera";
            this.comboBoxCamera.Size = new System.Drawing.Size(379, 24);
            this.comboBoxCamera.TabIndex = 1;
            // 
            // selectFolderDialog
            // 
            this.selectFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // textBoxCameraBatteryLevel
            // 
            this.textBoxCameraBatteryLevel.Location = new System.Drawing.Point(256, 68);
            this.textBoxCameraBatteryLevel.Name = "textBoxCameraBatteryLevel";
            this.textBoxCameraBatteryLevel.ReadOnly = true;
            this.textBoxCameraBatteryLevel.Size = new System.Drawing.Size(209, 22);
            this.textBoxCameraBatteryLevel.TabIndex = 11;
            // 
            // labelCameraBatteryLevel
            // 
            this.labelCameraBatteryLevel.AutoSize = true;
            this.labelCameraBatteryLevel.Location = new System.Drawing.Point(16, 71);
            this.labelCameraBatteryLevel.Name = "labelCameraBatteryLevel";
            this.labelCameraBatteryLevel.Size = new System.Drawing.Size(138, 25);
            this.labelCameraBatteryLevel.TabIndex = 10;
            this.labelCameraBatteryLevel.Text = "Battery Level";
            // 
            // textBoxCameraISO
            // 
            this.textBoxCameraISO.Location = new System.Drawing.Point(256, 246);
            this.textBoxCameraISO.Name = "textBoxCameraISO";
            this.textBoxCameraISO.ReadOnly = true;
            this.textBoxCameraISO.Size = new System.Drawing.Size(209, 22);
            this.textBoxCameraISO.TabIndex = 9;
            // 
            // labelCameraISO
            // 
            this.labelCameraISO.AutoSize = true;
            this.labelCameraISO.Location = new System.Drawing.Point(16, 249);
            this.labelCameraISO.Name = "labelCameraISO";
            this.labelCameraISO.Size = new System.Drawing.Size(47, 25);
            this.labelCameraISO.TabIndex = 8;
            this.labelCameraISO.Text = "ISO";
            // 
            // textBoxCameraExposureTime
            // 
            this.textBoxCameraExposureTime.Location = new System.Drawing.Point(256, 202);
            this.textBoxCameraExposureTime.Name = "textBoxCameraExposureTime";
            this.textBoxCameraExposureTime.ReadOnly = true;
            this.textBoxCameraExposureTime.Size = new System.Drawing.Size(209, 22);
            this.textBoxCameraExposureTime.TabIndex = 7;
            // 
            // textBoxCameraCompressionMode
            // 
            this.textBoxCameraCompressionMode.Location = new System.Drawing.Point(256, 156);
            this.textBoxCameraCompressionMode.Name = "textBoxCameraCompressionMode";
            this.textBoxCameraCompressionMode.ReadOnly = true;
            this.textBoxCameraCompressionMode.Size = new System.Drawing.Size(209, 22);
            this.textBoxCameraCompressionMode.TabIndex = 6;
            // 
            // textBoxCameraMode
            // 
            this.textBoxCameraMode.Location = new System.Drawing.Point(256, 112);
            this.textBoxCameraMode.Name = "textBoxCameraMode";
            this.textBoxCameraMode.ReadOnly = true;
            this.textBoxCameraMode.Size = new System.Drawing.Size(209, 22);
            this.textBoxCameraMode.TabIndex = 5;
            // 
            // textBoxCameraConnected
            // 
            this.textBoxCameraConnected.Location = new System.Drawing.Point(256, 24);
            this.textBoxCameraConnected.Name = "textBoxCameraConnected";
            this.textBoxCameraConnected.ReadOnly = true;
            this.textBoxCameraConnected.Size = new System.Drawing.Size(209, 22);
            this.textBoxCameraConnected.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Exposure Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Save Images As";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Connected";
            // 
            // comboBoxOutputFormat
            // 
            this.comboBoxOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputFormat.FormattingEnabled = true;
            this.comboBoxOutputFormat.Items.AddRange(new object[] {
            "RAW/Color (Processed)",
            "JPG/Color (Processed)",
            "RAW/RGGB (Unprocessed)"});
            this.comboBoxOutputFormat.Location = new System.Drawing.Point(174, 46);
            this.comboBoxOutputFormat.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOutputFormat.Name = "comboBoxOutputFormat";
            this.comboBoxOutputFormat.Size = new System.Drawing.Size(178, 24);
            this.comboBoxOutputFormat.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Image Output Format";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Target Application";
            // 
            // comboBoxPersonality
            // 
            this.comboBoxPersonality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonality.FormattingEnabled = true;
            this.comboBoxPersonality.Location = new System.Drawing.Point(174, 14);
            this.comboBoxPersonality.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPersonality.Name = "comboBoxPersonality";
            this.comboBoxPersonality.Size = new System.Drawing.Size(178, 24);
            this.comboBoxPersonality.TabIndex = 0;
            this.comboBoxPersonality.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonality_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.selectCameraTab);
            this.tabControl1.Controls.Add(this.cameraPersonalityTab);
            this.tabControl1.Controls.Add(this.driverSettingsTab);
            this.tabControl1.Controls.Add(this.extrasTab);
            this.tabControl1.Location = new System.Drawing.Point(16, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 268);
            this.tabControl1.TabIndex = 21;
            // 
            // selectCameraTab
            // 
            this.selectCameraTab.Controls.Add(this.comboBoxCamera);
            this.selectCameraTab.Controls.Add(this.label1);
            this.selectCameraTab.Controls.Add(this.label2);
            this.selectCameraTab.Location = new System.Drawing.Point(4, 25);
            this.selectCameraTab.Margin = new System.Windows.Forms.Padding(2);
            this.selectCameraTab.Name = "selectCameraTab";
            this.selectCameraTab.Padding = new System.Windows.Forms.Padding(2);
            this.selectCameraTab.Size = new System.Drawing.Size(692, 239);
            this.selectCameraTab.TabIndex = 0;
            this.selectCameraTab.Text = "Select Camera";
            this.selectCameraTab.UseVisualStyleBackColor = true;
            // 
            // cameraPersonalityTab
            // 
            this.cameraPersonalityTab.Controls.Add(this.comboBoxOutputFormat);
            this.cameraPersonalityTab.Controls.Add(this.label9);
            this.cameraPersonalityTab.Controls.Add(this.comboBoxPersonality);
            this.cameraPersonalityTab.Controls.Add(this.label8);
            this.cameraPersonalityTab.Location = new System.Drawing.Point(4, 25);
            this.cameraPersonalityTab.Margin = new System.Windows.Forms.Padding(2);
            this.cameraPersonalityTab.Name = "cameraPersonalityTab";
            this.cameraPersonalityTab.Padding = new System.Windows.Forms.Padding(2);
            this.cameraPersonalityTab.Size = new System.Drawing.Size(692, 239);
            this.cameraPersonalityTab.TabIndex = 1;
            this.cameraPersonalityTab.Text = "App Settings";
            this.cameraPersonalityTab.UseVisualStyleBackColor = true;
            // 
            // driverSettingsTab
            // 
            this.driverSettingsTab.Controls.Add(this.label15);
            this.driverSettingsTab.Controls.Add(this.comboBoxSerialRelay);
            this.driverSettingsTab.Controls.Add(this.linkLabel1);
            this.driverSettingsTab.Controls.Add(this.label13);
            this.driverSettingsTab.Controls.Add(this.label12);
            this.driverSettingsTab.Controls.Add(this.checkBoxKeepInterimFiles);
            this.driverSettingsTab.Controls.Add(this.checkBoxBulbMode);
            this.driverSettingsTab.Location = new System.Drawing.Point(4, 25);
            this.driverSettingsTab.Margin = new System.Windows.Forms.Padding(2);
            this.driverSettingsTab.Name = "driverSettingsTab";
            this.driverSettingsTab.Size = new System.Drawing.Size(692, 239);
            this.driverSettingsTab.TabIndex = 4;
            this.driverSettingsTab.Text = "Driver Settings";
            this.driverSettingsTab.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Serial Relay COM Port";
            // 
            // comboBoxSerialRelay
            // 
            this.comboBoxSerialRelay.FormattingEnabled = true;
            this.comboBoxSerialRelay.Location = new System.Drawing.Point(172, 55);
            this.comboBoxSerialRelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSerialRelay.Name = "comboBoxSerialRelay";
            this.comboBoxSerialRelay.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSerialRelay.TabIndex = 26;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(52, 114);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 16);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "N.I.N.A. Shutter Cable";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(68, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(550, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = " or Bulb mode if you have a separate Serial Relay shutter cable connected";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(566, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "NOTE: You must set Manual Mode on Camera before connecting to computer";
            // 
            // checkBoxKeepInterimFiles
            // 
            this.checkBoxKeepInterimFiles.AutoSize = true;
            this.checkBoxKeepInterimFiles.Location = new System.Drawing.Point(16, 139);
            this.checkBoxKeepInterimFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxKeepInterimFiles.Name = "checkBoxKeepInterimFiles";
            this.checkBoxKeepInterimFiles.Size = new System.Drawing.Size(291, 20);
            this.checkBoxKeepInterimFiles.TabIndex = 4;
            this.checkBoxKeepInterimFiles.Text = "Keep DNG and JPG Files in the Temp folder";
            this.checkBoxKeepInterimFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxBulbMode
            // 
            this.checkBoxBulbMode.AutoSize = true;
            this.checkBoxBulbMode.Location = new System.Drawing.Point(16, 89);
            this.checkBoxBulbMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBulbMode.Name = "checkBoxBulbMode";
            this.checkBoxBulbMode.Size = new System.Drawing.Size(443, 20);
            this.checkBoxBulbMode.TabIndex = 1;
            this.checkBoxBulbMode.Text = "Use BULB mode (must use Serial Relay with a separate shutter cable)";
            this.checkBoxBulbMode.UseVisualStyleBackColor = true;
            // 
            // extrasTab
            // 
            this.extrasTab.Controls.Add(this.label10);
            this.extrasTab.Controls.Add(this.numericUpDown1);
            this.extrasTab.Controls.Add(this.chkTrace);
            this.extrasTab.Location = new System.Drawing.Point(4, 25);
            this.extrasTab.Margin = new System.Windows.Forms.Padding(2);
            this.extrasTab.Name = "extrasTab";
            this.extrasTab.Size = new System.Drawing.Size(692, 239);
            this.extrasTab.TabIndex = 2;
            this.extrasTab.Text = "Extras";
            this.extrasTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Debug Level (0 min - 5 max)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 165);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(877, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "* The information above is only populated when the application is connected to th" +
    "e camera";
            // 
            // modeWarning
            // 
            this.modeWarning.Image = ((System.Drawing.Image)(resources.GetObject("modeWarning.Image")));
            this.modeWarning.Location = new System.Drawing.Point(484, 108);
            this.modeWarning.Name = "modeWarning";
            this.modeWarning.Size = new System.Drawing.Size(40, 40);
            this.modeWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modeWarning.TabIndex = 12;
            this.modeWarning.TabStop = false;
            this.modeWarning.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 457);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(276, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "NOTE: Stop Exposure Not Supported";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 489);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Version 10/9/2025";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(163, 378);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(300, 378);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(424, 378);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(568, 377);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // picASCOM
            // 
            this.picASCOM.Image = global::ASCOM.PentaxKR.Properties.Resources.ASCOM;
            this.picASCOM.Location = new System.Drawing.Point(20, 285);
            this.picASCOM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picASCOM.Name = "picASCOM";
            this.picASCOM.Size = new System.Drawing.Size(85, 85);
            this.picASCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picASCOM.TabIndex = 30;
            this.picASCOM.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(13, 378);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(149, 73);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // SetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(722, 519);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picASCOM);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pentax KR/K5ii Setup Version 10/9/2025";
            this.tabControl1.ResumeLayout(false);
            this.selectCameraTab.ResumeLayout(false);
            this.selectCameraTab.PerformLayout();
            this.cameraPersonalityTab.ResumeLayout(false);
            this.cameraPersonalityTab.PerformLayout();
            this.driverSettingsTab.ResumeLayout(false);
            this.driverSettingsTab.PerformLayout();
            this.extrasTab.ResumeLayout(false);
            this.extrasTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.ComboBox comboBoxCamera;
        private System.Windows.Forms.FolderBrowserDialog selectFolderDialog;
        private System.Windows.Forms.TextBox textBoxCameraExposureTime;
        private System.Windows.Forms.TextBox textBoxCameraCompressionMode;
        private System.Windows.Forms.TextBox textBoxCameraMode;
        private System.Windows.Forms.TextBox textBoxCameraConnected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxOutputFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPersonality;
        private System.Windows.Forms.Label labelCameraISO;
        private System.Windows.Forms.TextBox textBoxCameraISO;
        private System.Windows.Forms.TextBox textBoxCameraBatteryLevel;
        private System.Windows.Forms.Label labelCameraBatteryLevel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage selectCameraTab;
        private System.Windows.Forms.TabPage cameraPersonalityTab;
//        private System.Windows.Forms.TabPage cameraInfoTab;
        private System.Windows.Forms.TabPage extrasTab;
        private System.Windows.Forms.PictureBox modeWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage driverSettingsTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxBulbMode;
        private System.Windows.Forms.CheckBox checkBoxKeepInterimFiles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picASCOM;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxSerialRelay;
    }
}