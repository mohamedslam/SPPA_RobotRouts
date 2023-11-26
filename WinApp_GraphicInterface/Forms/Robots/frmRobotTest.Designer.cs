
namespace WinApp_GraphicInterface.Forms.Robots
{
    partial class frmRobotTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRobotTest));
            this.btnSendData = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbRobotList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRobotIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRobotName = new System.Windows.Forms.TextBox();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.richTextBoxDataReceived = new System.Windows.Forms.RichTextBox();
            this.btnClearRecived = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearSent = new System.Windows.Forms.Button();
            this.richTextBoxDataSent = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshServerIp = new System.Windows.Forms.Button();
            this.cmbtxtServerIps = new System.Windows.Forms.ComboBox();
            this.txthostName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelfLeft = new System.Windows.Forms.Button();
            this.btnforward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelfRight = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackSensorServoMotor = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSensorF = new System.Windows.Forms.Label();
            this.lblSensorFL = new System.Windows.Forms.Label();
            this.lblSensorFR = new System.Windows.Forms.Label();
            this.lblSensorR = new System.Windows.Forms.Label();
            this.lblSensorL = new System.Windows.Forms.Label();
            this.lblSensorB = new System.Windows.Forms.Label();
            this.btnRout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.lblWifiStrength = new System.Windows.Forms.Label();
            this.btnWiFi = new System.Windows.Forms.Button();
            this.lblBataryStrength = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAngle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSensorServoMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendData
            // 
            this.btnSendData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSendData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendData.ImageKey = "connect.png";
            this.btnSendData.ImageList = this.imageList1;
            this.btnSendData.Location = new System.Drawing.Point(4, 312);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(852, 41);
            this.btnSendData.TabIndex = 0;
            this.btnSendData.Text = "Send";
            this.btnSendData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Back.png");
            this.imageList1.Images.SetKeyName(1, "forward.png");
            this.imageList1.Images.SetKeyName(2, "left.png");
            this.imageList1.Images.SetKeyName(3, "right.png");
            this.imageList1.Images.SetKeyName(4, "SelfLeft.png");
            this.imageList1.Images.SetKeyName(5, "SelfRight.png");
            this.imageList1.Images.SetKeyName(6, "Stop.png");
            this.imageList1.Images.SetKeyName(7, "WiFi.png");
            this.imageList1.Images.SetKeyName(8, "target.png");
            this.imageList1.Images.SetKeyName(9, "refresh.png");
            this.imageList1.Images.SetKeyName(10, "Route.png");
            this.imageList1.Images.SetKeyName(11, "edit.png");
            this.imageList1.Images.SetKeyName(12, "cardinators.png");
            this.imageList1.Images.SetKeyName(13, "disconnect.png");
            this.imageList1.Images.SetKeyName(14, "save.png");
            this.imageList1.Images.SetKeyName(15, "delete.png");
            this.imageList1.Images.SetKeyName(16, "connect.png");
            this.imageList1.Images.SetKeyName(17, "cam.png");
            this.imageList1.Images.SetKeyName(18, "home.png");
            // 
            // cmbRobotList
            // 
            this.cmbRobotList.FormattingEnabled = true;
            this.cmbRobotList.Location = new System.Drawing.Point(63, 15);
            this.cmbRobotList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRobotList.Name = "cmbRobotList";
            this.cmbRobotList.Size = new System.Drawing.Size(296, 24);
            this.cmbRobotList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Robot:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Robot IP:";
            // 
            // txtRobotIP
            // 
            this.txtRobotIP.Location = new System.Drawing.Point(481, 16);
            this.txtRobotIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtRobotIP.Name = "txtRobotIP";
            this.txtRobotIP.Size = new System.Drawing.Size(157, 22);
            this.txtRobotIP.TabIndex = 3;
            this.txtRobotIP.Text = "192.168.43.3";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(548, 24);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(37, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "8080";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 795);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1444, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMsg.Location = new System.Drawing.Point(4, 290);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(852, 22);
            this.txtMsg.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRobotName);
            this.groupBox2.Controls.Add(this.textBoxSender);
            this.groupBox2.Controls.Add(this.richTextBoxDataReceived);
            this.groupBox2.Controls.Add(this.btnClearRecived);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(0, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1444, 358);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recived Data";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(1305, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 20);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Scrol";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "From:";
            // 
            // txtRobotName
            // 
            this.txtRobotName.Location = new System.Drawing.Point(161, 29);
            this.txtRobotName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRobotName.Name = "txtRobotName";
            this.txtRobotName.ReadOnly = true;
            this.txtRobotName.Size = new System.Drawing.Size(188, 22);
            this.txtRobotName.TabIndex = 24;
            this.txtRobotName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(53, 28);
            this.textBoxSender.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.ReadOnly = true;
            this.textBoxSender.Size = new System.Drawing.Size(104, 22);
            this.textBoxSender.TabIndex = 24;
            this.textBoxSender.Text = "192.168.43.62";
            // 
            // richTextBoxDataReceived
            // 
            this.richTextBoxDataReceived.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBoxDataReceived.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxDataReceived.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDataReceived.Location = new System.Drawing.Point(4, 60);
            this.richTextBoxDataReceived.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDataReceived.MaxLength = 2;
            this.richTextBoxDataReceived.Name = "richTextBoxDataReceived";
            this.richTextBoxDataReceived.ReadOnly = true;
            this.richTextBoxDataReceived.Size = new System.Drawing.Size(1436, 294);
            this.richTextBoxDataReceived.TabIndex = 23;
            this.richTextBoxDataReceived.Text = "";
            // 
            // btnClearRecived
            // 
            this.btnClearRecived.BackColor = System.Drawing.Color.Transparent;
            this.btnClearRecived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRecived.ImageKey = "delete.png";
            this.btnClearRecived.ImageList = this.imageList1;
            this.btnClearRecived.Location = new System.Drawing.Point(1380, 12);
            this.btnClearRecived.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearRecived.Name = "btnClearRecived";
            this.btnClearRecived.Size = new System.Drawing.Size(51, 45);
            this.btnClearRecived.TabIndex = 0;
            this.btnClearRecived.UseVisualStyleBackColor = false;
            this.btnClearRecived.Click += new System.EventHandler(this.btnClearRecived_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(738, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Scrol";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.btnClearSent);
            this.groupBox3.Controls.Add(this.richTextBoxDataSent);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbRobotList);
            this.groupBox3.Controls.Add(this.txtRobotIP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMsg);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 80);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(860, 357);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Data";
            // 
            // btnClearSent
            // 
            this.btnClearSent.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSent.ImageKey = "delete.png";
            this.btnClearSent.ImageList = this.imageList1;
            this.btnClearSent.Location = new System.Drawing.Point(804, 10);
            this.btnClearSent.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSent.Name = "btnClearSent";
            this.btnClearSent.Size = new System.Drawing.Size(51, 41);
            this.btnClearSent.TabIndex = 25;
            this.btnClearSent.UseVisualStyleBackColor = false;
            this.btnClearSent.Click += new System.EventHandler(this.btnClearSent_Click);
            // 
            // richTextBoxDataSent
            // 
            this.richTextBoxDataSent.BackColor = System.Drawing.Color.MidnightBlue;
            this.richTextBoxDataSent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxDataSent.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDataSent.Location = new System.Drawing.Point(4, 59);
            this.richTextBoxDataSent.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDataSent.MaxLength = 2;
            this.richTextBoxDataSent.Name = "richTextBoxDataSent";
            this.richTextBoxDataSent.ReadOnly = true;
            this.richTextBoxDataSent.Size = new System.Drawing.Size(852, 231);
            this.richTextBoxDataSent.TabIndex = 24;
            this.richTextBoxDataSent.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Host IP:";
            // 
            // btnRefreshServerIp
            // 
            this.btnRefreshServerIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshServerIp.ImageKey = "refresh.png";
            this.btnRefreshServerIp.ImageList = this.imageList1;
            this.btnRefreshServerIp.Location = new System.Drawing.Point(596, 23);
            this.btnRefreshServerIp.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshServerIp.Name = "btnRefreshServerIp";
            this.btnRefreshServerIp.Size = new System.Drawing.Size(42, 45);
            this.btnRefreshServerIp.TabIndex = 5;
            this.btnRefreshServerIp.UseVisualStyleBackColor = true;
            // 
            // cmbtxtServerIps
            // 
            this.cmbtxtServerIps.FormattingEnabled = true;
            this.cmbtxtServerIps.Location = new System.Drawing.Point(391, 21);
            this.cmbtxtServerIps.Name = "cmbtxtServerIps";
            this.cmbtxtServerIps.Size = new System.Drawing.Size(154, 24);
            this.cmbtxtServerIps.TabIndex = 7;
            // 
            // txthostName
            // 
            this.txthostName.Location = new System.Drawing.Point(391, 46);
            this.txthostName.Margin = new System.Windows.Forms.Padding(4);
            this.txthostName.Name = "txthostName";
            this.txthostName.ReadOnly = true;
            this.txthostName.Size = new System.Drawing.Size(194, 22);
            this.txthostName.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnRout);
            this.groupBox4.Controls.Add(this.btnHome);
            this.groupBox4.Controls.Add(this.btnCam);
            this.groupBox4.Controls.Add(this.lblWifiStrength);
            this.groupBox4.Controls.Add(this.btnWiFi);
            this.groupBox4.Controls.Add(this.lblBataryStrength);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(860, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 437);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send Control";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.cmbAngle);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtSteps);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btnSelfLeft);
            this.groupBox5.Controls.Add(this.btnforward);
            this.groupBox5.Controls.Add(this.btnLeft);
            this.groupBox5.Controls.Add(this.btnBack);
            this.groupBox5.Controls.Add(this.btnSelfRight);
            this.groupBox5.Controls.Add(this.btnRight);
            this.groupBox5.Controls.Add(this.btnStop);
            this.groupBox5.Location = new System.Drawing.Point(347, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 332);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Movment";
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(57, 24);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(55, 22);
            this.txtSteps.TabIndex = 6;
            this.txtSteps.Text = "1";
            this.txtSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Steps:";
            // 
            // btnSelfLeft
            // 
            this.btnSelfLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelfLeft.ImageKey = "SelfLeft.png";
            this.btnSelfLeft.ImageList = this.imageList1;
            this.btnSelfLeft.Location = new System.Drawing.Point(30, 92);
            this.btnSelfLeft.Name = "btnSelfLeft";
            this.btnSelfLeft.Size = new System.Drawing.Size(40, 40);
            this.btnSelfLeft.TabIndex = 4;
            this.btnSelfLeft.UseVisualStyleBackColor = true;
            this.btnSelfLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnSelfLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // btnforward
            // 
            this.btnforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforward.ImageKey = "forward.png";
            this.btnforward.ImageList = this.imageList1;
            this.btnforward.Location = new System.Drawing.Point(85, 87);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(55, 50);
            this.btnforward.TabIndex = 4;
            this.btnforward.UseVisualStyleBackColor = true;
            this.btnforward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnforward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ImageKey = "left.png";
            this.btnLeft.ImageList = this.imageList1;
            this.btnLeft.Location = new System.Drawing.Point(30, 137);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 50);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ImageKey = "Back.png";
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(86, 189);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // btnSelfRight
            // 
            this.btnSelfRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelfRight.ImageKey = "SelfRight.png";
            this.btnSelfRight.ImageList = this.imageList1;
            this.btnSelfRight.Location = new System.Drawing.Point(155, 91);
            this.btnSelfRight.Name = "btnSelfRight";
            this.btnSelfRight.Size = new System.Drawing.Size(40, 40);
            this.btnSelfRight.TabIndex = 4;
            this.btnSelfRight.UseVisualStyleBackColor = true;
            this.btnSelfRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnSelfRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ImageKey = "right.png";
            this.btnRight.ImageList = this.imageList1;
            this.btnRight.Location = new System.Drawing.Point(142, 137);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 50);
            this.btnRight.TabIndex = 4;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ImageKey = "Stop.png";
            this.btnStop.ImageList = this.imageList1;
            this.btnStop.Location = new System.Drawing.Point(86, 138);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(55, 50);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.trackSensorServoMotor);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblSensorF);
            this.groupBox1.Controls.Add(this.lblSensorFL);
            this.groupBox1.Controls.Add(this.lblSensorFR);
            this.groupBox1.Controls.Add(this.lblSensorR);
            this.groupBox1.Controls.Add(this.lblSensorL);
            this.groupBox1.Controls.Add(this.lblSensorB);
            this.groupBox1.Location = new System.Drawing.Point(3, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 341);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors";
            // 
            // trackSensorServoMotor
            // 
            this.trackSensorServoMotor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackSensorServoMotor.Location = new System.Drawing.Point(3, 282);
            this.trackSensorServoMotor.Maximum = 180;
            this.trackSensorServoMotor.Name = "trackSensorServoMotor";
            this.trackSensorServoMotor.Size = new System.Drawing.Size(334, 56);
            this.trackSensorServoMotor.SmallChange = 5;
            this.trackSensorServoMotor.TabIndex = 19;
            this.trackSensorServoMotor.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackSensorServoMotor.Value = 90;
            this.trackSensorServoMotor.Scroll += new System.EventHandler(this.trackSensorServoMotor_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WinApp_GraphicInterface.Properties.Resources.png_transparent_maine_drone_society_robot_unmanned_aerial_vehicle_autonomous_car_odometry_robot_angle_electronics_vehicle_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(110, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblSensorF
            // 
            this.lblSensorF.AutoSize = true;
            this.lblSensorF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorF.Location = new System.Drawing.Point(118, 15);
            this.lblSensorF.Name = "lblSensorF";
            this.lblSensorF.Size = new System.Drawing.Size(63, 16);
            this.lblSensorF.TabIndex = 11;
            this.lblSensorF.Text = "+100 cm";
            // 
            // lblSensorFL
            // 
            this.lblSensorFL.AutoSize = true;
            this.lblSensorFL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorFL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorFL.Location = new System.Drawing.Point(32, 36);
            this.lblSensorFL.Name = "lblSensorFL";
            this.lblSensorFL.Size = new System.Drawing.Size(63, 16);
            this.lblSensorFL.TabIndex = 11;
            this.lblSensorFL.Text = "+100 cm";
            // 
            // lblSensorFR
            // 
            this.lblSensorFR.AutoSize = true;
            this.lblSensorFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorFR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorFR.Location = new System.Drawing.Point(224, 33);
            this.lblSensorFR.Name = "lblSensorFR";
            this.lblSensorFR.Size = new System.Drawing.Size(63, 16);
            this.lblSensorFR.TabIndex = 11;
            this.lblSensorFR.Text = "+100 cm";
            // 
            // lblSensorR
            // 
            this.lblSensorR.AutoSize = true;
            this.lblSensorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorR.Location = new System.Drawing.Point(224, 104);
            this.lblSensorR.Name = "lblSensorR";
            this.lblSensorR.Size = new System.Drawing.Size(63, 16);
            this.lblSensorR.TabIndex = 11;
            this.lblSensorR.Text = "+100 cm";
            // 
            // lblSensorL
            // 
            this.lblSensorL.AutoSize = true;
            this.lblSensorL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorL.Location = new System.Drawing.Point(32, 102);
            this.lblSensorL.Name = "lblSensorL";
            this.lblSensorL.Size = new System.Drawing.Size(63, 16);
            this.lblSensorL.TabIndex = 11;
            this.lblSensorL.Text = "+100 cm";
            // 
            // lblSensorB
            // 
            this.lblSensorB.AutoSize = true;
            this.lblSensorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorB.Location = new System.Drawing.Point(124, 134);
            this.lblSensorB.Name = "lblSensorB";
            this.lblSensorB.Size = new System.Drawing.Size(63, 16);
            this.lblSensorB.TabIndex = 11;
            this.lblSensorB.Text = "+100 cm";
            // 
            // btnRout
            // 
            this.btnRout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRout.ImageKey = "Route.png";
            this.btnRout.ImageList = this.imageList1;
            this.btnRout.Location = new System.Drawing.Point(436, 15);
            this.btnRout.Name = "btnRout";
            this.btnRout.Size = new System.Drawing.Size(61, 45);
            this.btnRout.TabIndex = 13;
            this.btnRout.UseVisualStyleBackColor = true;
            this.btnRout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnRout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ImageKey = "home.png";
            this.btnHome.ImageList = this.imageList1;
            this.btnHome.Location = new System.Drawing.Point(510, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(61, 45);
            this.btnHome.TabIndex = 13;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseDown);
            this.btnHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsControl_MouseUp);
            // 
            // btnCam
            // 
            this.btnCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCam.ImageKey = "cam.png";
            this.btnCam.ImageList = this.imageList1;
            this.btnCam.Location = new System.Drawing.Point(362, 14);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(61, 46);
            this.btnCam.TabIndex = 12;
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // lblWifiStrength
            // 
            this.lblWifiStrength.AutoSize = true;
            this.lblWifiStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblWifiStrength.ForeColor = System.Drawing.Color.IndianRed;
            this.lblWifiStrength.Location = new System.Drawing.Point(138, 30);
            this.lblWifiStrength.Name = "lblWifiStrength";
            this.lblWifiStrength.Size = new System.Drawing.Size(36, 16);
            this.lblWifiStrength.TabIndex = 11;
            this.lblWifiStrength.Text = "7/10";
            // 
            // btnWiFi
            // 
            this.btnWiFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiFi.ImageKey = "refresh.png";
            this.btnWiFi.Location = new System.Drawing.Point(14, 27);
            this.btnWiFi.Margin = new System.Windows.Forms.Padding(4);
            this.btnWiFi.Name = "btnWiFi";
            this.btnWiFi.Size = new System.Drawing.Size(92, 27);
            this.btnWiFi.TabIndex = 5;
            this.btnWiFi.Text = "Wifi Data";
            this.btnWiFi.UseVisualStyleBackColor = true;
            this.btnWiFi.Click += new System.EventHandler(this.btnWiFi_Click);
            // 
            // lblBataryStrength
            // 
            this.lblBataryStrength.AutoSize = true;
            this.lblBataryStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblBataryStrength.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBataryStrength.Location = new System.Drawing.Point(138, 60);
            this.lblBataryStrength.Name = "lblBataryStrength";
            this.lblBataryStrength.Size = new System.Drawing.Size(36, 16);
            this.lblBataryStrength.TabIndex = 11;
            this.lblBataryStrength.Text = "90%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(20, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Batary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "HostName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(92, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "Robot Tests";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WinApp_GraphicInterface.Properties.Resources.png_transparent_robotics_computer_technology_robotics_3d_computer_graphics_computer_engineering_thumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ImageKey = "WiFi.png";
            this.btnConnect.ImageList = this.imageList1;
            this.btnConnect.Location = new System.Drawing.Point(784, 8);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 64);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(16, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gyroscope:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(115, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Angle:";
            // 
            // cmbAngle
            // 
            this.cmbAngle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAngle.FormatString = "N2";
            this.cmbAngle.FormattingEnabled = true;
            this.cmbAngle.Items.AddRange(new object[] {
            "115",
            "125",
            "135",
            "145",
            "15",
            "160",
            "175",
            "180",
            "25",
            "35",
            "45",
            "55",
            "90"});
            this.cmbAngle.Location = new System.Drawing.Point(170, 24);
            this.cmbAngle.Name = "cmbAngle";
            this.cmbAngle.Size = new System.Drawing.Size(55, 24);
            this.cmbAngle.Sorted = true;
            this.cmbAngle.TabIndex = 7;
            this.cmbAngle.Text = "45";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(16, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Accelerator:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "X:0 Y:0 Z:0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "X:0 Y:0 Z:0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.trackSpeed);
            this.groupBox6.Controls.Add(this.lblSpeedValue);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 271);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 58);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Speed";
            // 
            // trackSpeed
            // 
            this.trackSpeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackSpeed.Location = new System.Drawing.Point(3, 18);
            this.trackSpeed.Maximum = 255;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(540, 37);
            this.trackSpeed.TabIndex = 5;
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.AutoSize = true;
            this.lblSpeedValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSpeedValue.Location = new System.Drawing.Point(206, 18);
            this.lblSpeedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(18, 20);
            this.lblSpeedValue.TabIndex = 2;
            this.lblSpeedValue.Text = "1";
            this.lblSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label14.Location = new System.Drawing.Point(16, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Temperature:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(124, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label16.Location = new System.Drawing.Point(157, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "C";
            // 
            // frmRobotTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1444, 817);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txthostName);
            this.Controls.Add(this.cmbtxtServerIps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnRefreshServerIp);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRobotTest";
            this.Text = "Robot Test Send and Recived Data";
            this.Load += new System.EventHandler(this.frmRobotTest_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSensorServoMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.ComboBox cmbRobotList;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtRobotIP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearRecived;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefreshServerIp;
        private System.Windows.Forms.RichTextBox richTextBoxDataReceived;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.ComboBox cmbtxtServerIps;
        private System.Windows.Forms.TextBox txthostName;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnforward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnSelfLeft;
        private System.Windows.Forms.Button btnSelfRight;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSensorR;
        private System.Windows.Forms.Label lblSensorB;
        private System.Windows.Forms.Label lblSensorL;
        private System.Windows.Forms.Label lblSensorF;
        private System.Windows.Forms.Label lblBataryStrength;
        private System.Windows.Forms.Label lblWifiStrength;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.TextBox txtRobotName;
        private System.Windows.Forms.Label lblSensorFR;
        private System.Windows.Forms.Label lblSensorFL;
        private System.Windows.Forms.RichTextBox richTextBoxDataSent;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRout;
        private System.Windows.Forms.Button btnClearSent;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TrackBar trackSensorServoMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Button btnWiFi;
        private System.Windows.Forms.ComboBox cmbAngle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}