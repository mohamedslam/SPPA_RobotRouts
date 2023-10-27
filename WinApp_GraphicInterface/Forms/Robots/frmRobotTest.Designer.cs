
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
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.richTextBoxDataReceived = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshServerIp = new System.Windows.Forms.Button();
            this.cmbtxtServerIps = new System.Windows.Forms.ComboBox();
            this.txthostName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelfLeft = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnSelfRight = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnforward = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBataryStrength = new System.Windows.Forms.Label();
            this.lblWifiStrength = new System.Windows.Forms.Label();
            this.lblSensorF = new System.Windows.Forms.Label();
            this.lblSensorL = new System.Windows.Forms.Label();
            this.lblSensorB = new System.Windows.Forms.Label();
            this.lblSensorR = new System.Windows.Forms.Label();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBoxDataSent = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRout = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendData
            // 
            this.btnSendData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSendData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendData.ImageKey = "connect.png";
            this.btnSendData.ImageList = this.imageList1;
            this.btnSendData.Location = new System.Drawing.Point(4, 211);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(657, 41);
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
            this.txtRobotIP.Text = "192.168.43.62";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(447, 23);
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
            this.statusStrip1.Size = new System.Drawing.Size(1250, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtMsg
            // 
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMsg.Location = new System.Drawing.Point(4, 189);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(657, 22);
            this.txtMsg.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBoxSender);
            this.groupBox2.Controls.Add(this.richTextBoxDataReceived);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(0, 343);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1250, 452);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recived Data";
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
            this.richTextBoxDataReceived.Location = new System.Drawing.Point(4, 65);
            this.richTextBoxDataReceived.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDataReceived.MaxLength = 2;
            this.richTextBoxDataReceived.Name = "richTextBoxDataReceived";
            this.richTextBoxDataReceived.ReadOnly = true;
            this.richTextBoxDataReceived.Size = new System.Drawing.Size(1242, 383);
            this.richTextBoxDataReceived.TabIndex = 23;
            this.richTextBoxDataReceived.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "delete.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(1191, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.richTextBoxDataSent);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbRobotList);
            this.groupBox3.Controls.Add(this.txtRobotIP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMsg);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Location = new System.Drawing.Point(0, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(665, 256);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 24);
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
            this.btnRefreshServerIp.Location = new System.Drawing.Point(492, 24);
            this.btnRefreshServerIp.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshServerIp.Name = "btnRefreshServerIp";
            this.btnRefreshServerIp.Size = new System.Drawing.Size(42, 45);
            this.btnRefreshServerIp.TabIndex = 5;
            this.btnRefreshServerIp.UseVisualStyleBackColor = true;
            this.btnRefreshServerIp.Click += new System.EventHandler(this.btnRefreshServerIp_Click);
            // 
            // cmbtxtServerIps
            // 
            this.cmbtxtServerIps.FormattingEnabled = true;
            this.cmbtxtServerIps.Location = new System.Drawing.Point(331, 21);
            this.cmbtxtServerIps.Name = "cmbtxtServerIps";
            this.cmbtxtServerIps.Size = new System.Drawing.Size(109, 24);
            this.cmbtxtServerIps.TabIndex = 7;
            // 
            // txthostName
            // 
            this.txthostName.Location = new System.Drawing.Point(331, 46);
            this.txthostName.Margin = new System.Windows.Forms.Padding(4);
            this.txthostName.Name = "txthostName";
            this.txthostName.ReadOnly = true;
            this.txthostName.Size = new System.Drawing.Size(157, 22);
            this.txthostName.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnRout);
            this.groupBox4.Controls.Add(this.btnHome);
            this.groupBox4.Controls.Add(this.btnCam);
            this.groupBox4.Controls.Add(this.lblWifiStrength);
            this.groupBox4.Controls.Add(this.lblBataryStrength);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(666, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 343);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send Control";
            // 
            // trackSpeed
            // 
            this.trackSpeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackSpeed.Location = new System.Drawing.Point(3, 18);
            this.trackSpeed.Maximum = 255;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(540, 37);
            this.trackSpeed.TabIndex = 5;
            this.trackSpeed.Scroll += new System.EventHandler(this.trackSpeed_Scroll);
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.AutoSize = true;
            this.lblSpeedValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSpeedValue.Location = new System.Drawing.Point(539, 18);
            this.lblSpeedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(36, 20);
            this.lblSpeedValue.TabIndex = 2;
            this.lblSpeedValue.Text = "255";
            this.lblSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 52);
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
            this.label6.Location = new System.Drawing.Point(81, 22);
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
            // btnSelfLeft
            // 
            this.btnSelfLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelfLeft.ImageKey = "SelfLeft.png";
            this.btnSelfLeft.ImageList = this.imageList1;
            this.btnSelfLeft.Location = new System.Drawing.Point(18, 30);
            this.btnSelfLeft.Name = "btnSelfLeft";
            this.btnSelfLeft.Size = new System.Drawing.Size(40, 40);
            this.btnSelfLeft.TabIndex = 4;
            this.btnSelfLeft.UseVisualStyleBackColor = true;
            this.btnSelfLeft.Click += new System.EventHandler(this.btnOriantation_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ImageKey = "Stop.png";
            this.btnStop.ImageList = this.imageList1;
            this.btnStop.Location = new System.Drawing.Point(86, 77);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(55, 50);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnOriantation_Click);
            // 
            // btnRight
            // 
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ImageKey = "right.png";
            this.btnRight.ImageList = this.imageList1;
            this.btnRight.Location = new System.Drawing.Point(154, 74);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 50);
            this.btnRight.TabIndex = 4;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnOriantation_Click);
            // 
            // btnSelfRight
            // 
            this.btnSelfRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelfRight.ImageKey = "SelfRight.png";
            this.btnSelfRight.ImageList = this.imageList1;
            this.btnSelfRight.Location = new System.Drawing.Point(169, 28);
            this.btnSelfRight.Name = "btnSelfRight";
            this.btnSelfRight.Size = new System.Drawing.Size(40, 40);
            this.btnSelfRight.TabIndex = 4;
            this.btnSelfRight.UseVisualStyleBackColor = true;
            this.btnSelfRight.Click += new System.EventHandler(this.btnOriantation_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ImageKey = "Back.png";
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(86, 133);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnOriantation_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ImageKey = "left.png";
            this.btnLeft.ImageList = this.imageList1;
            this.btnLeft.Location = new System.Drawing.Point(18, 78);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 50);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnOriantation_Click);
            // 
            // btnforward
            // 
            this.btnforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforward.ImageKey = "forward.png";
            this.btnforward.ImageList = this.imageList1;
            this.btnforward.Location = new System.Drawing.Point(86, 23);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(55, 50);
            this.btnforward.TabIndex = 4;
            this.btnforward.UseVisualStyleBackColor = true;
            this.btnforward.Click += new System.EventHandler(this.btnOriantation_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ImageKey = "WiFi.png";
            this.btnConnect.ImageList = this.imageList1;
            this.btnConnect.Location = new System.Drawing.Point(585, 24);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(53, 48);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WinApp_GraphicInterface.Properties.Resources.png_transparent_maine_drone_society_robot_unmanned_aerial_vehicle_autonomous_car_odometry_robot_angle_electronics_vehicle_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(81, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(15, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Wifi Strength";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(190, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Batary";
            // 
            // lblBataryStrength
            // 
            this.lblBataryStrength.AutoSize = true;
            this.lblBataryStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblBataryStrength.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBataryStrength.Location = new System.Drawing.Point(315, 39);
            this.lblBataryStrength.Name = "lblBataryStrength";
            this.lblBataryStrength.Size = new System.Drawing.Size(36, 16);
            this.lblBataryStrength.TabIndex = 11;
            this.lblBataryStrength.Text = "90%";
            // 
            // lblWifiStrength
            // 
            this.lblWifiStrength.AutoSize = true;
            this.lblWifiStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblWifiStrength.ForeColor = System.Drawing.Color.IndianRed;
            this.lblWifiStrength.Location = new System.Drawing.Point(140, 40);
            this.lblWifiStrength.Name = "lblWifiStrength";
            this.lblWifiStrength.Size = new System.Drawing.Size(36, 16);
            this.lblWifiStrength.TabIndex = 11;
            this.lblWifiStrength.Text = "7/10";
            // 
            // lblSensorF
            // 
            this.lblSensorF.AutoSize = true;
            this.lblSensorF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorF.Location = new System.Drawing.Point(95, 17);
            this.lblSensorF.Name = "lblSensorF";
            this.lblSensorF.Size = new System.Drawing.Size(63, 16);
            this.lblSensorF.TabIndex = 11;
            this.lblSensorF.Text = "+100 cm";
            // 
            // lblSensorL
            // 
            this.lblSensorL.AutoSize = true;
            this.lblSensorL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorL.Location = new System.Drawing.Point(11, 96);
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
            this.lblSensorB.Location = new System.Drawing.Point(96, 154);
            this.lblSensorB.Name = "lblSensorB";
            this.lblSensorB.Size = new System.Drawing.Size(63, 16);
            this.lblSensorB.TabIndex = 11;
            this.lblSensorB.Text = "+100 cm";
            // 
            // lblSensorR
            // 
            this.lblSensorR.AutoSize = true;
            this.lblSensorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSensorR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSensorR.Location = new System.Drawing.Point(177, 97);
            this.lblSensorR.Name = "lblSensorR";
            this.lblSensorR.Size = new System.Drawing.Size(63, 16);
            this.lblSensorR.TabIndex = 11;
            this.lblSensorR.Text = "+100 cm";
            // 
            // btnCam
            // 
            this.btnCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCam.ImageKey = "cam.png";
            this.btnCam.ImageList = this.imageList1;
            this.btnCam.Location = new System.Drawing.Point(499, 21);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(75, 56);
            this.btnCam.TabIndex = 12;
            this.btnCam.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ImageKey = "home.png";
            this.btnHome.ImageList = this.imageList1;
            this.btnHome.Location = new System.Drawing.Point(274, 93);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(61, 53);
            this.btnHome.TabIndex = 13;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Sallam1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(42, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "+100 cm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(145, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "+100 cm";
            // 
            // richTextBoxDataSent
            // 
            this.richTextBoxDataSent.BackColor = System.Drawing.Color.MidnightBlue;
            this.richTextBoxDataSent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxDataSent.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDataSent.Location = new System.Drawing.Point(4, 45);
            this.richTextBoxDataSent.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDataSent.MaxLength = 2;
            this.richTextBoxDataSent.Name = "richTextBoxDataSent";
            this.richTextBoxDataSent.ReadOnly = true;
            this.richTextBoxDataSent.Size = new System.Drawing.Size(657, 144);
            this.richTextBoxDataSent.TabIndex = 24;
            this.richTextBoxDataSent.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(1107, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Scrol";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblSensorF);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblSensorR);
            this.groupBox1.Controls.Add(this.lblSensorL);
            this.groupBox1.Controls.Add(this.lblSensorB);
            this.groupBox1.Location = new System.Drawing.Point(19, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 188);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSelfLeft);
            this.groupBox5.Controls.Add(this.btnforward);
            this.groupBox5.Controls.Add(this.btnLeft);
            this.groupBox5.Controls.Add(this.btnBack);
            this.groupBox5.Controls.Add(this.btnSelfRight);
            this.groupBox5.Controls.Add(this.btnRight);
            this.groupBox5.Controls.Add(this.btnStop);
            this.groupBox5.Location = new System.Drawing.Point(344, 87);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 190);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Movment";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.trackSpeed);
            this.groupBox6.Controls.Add(this.lblSpeedValue);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 282);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(578, 58);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Speed";
            // 
            // btnRout
            // 
            this.btnRout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRout.ImageKey = "Route.png";
            this.btnRout.ImageList = this.imageList1;
            this.btnRout.Location = new System.Drawing.Point(274, 224);
            this.btnRout.Name = "btnRout";
            this.btnRout.Size = new System.Drawing.Size(61, 53);
            this.btnRout.TabIndex = 13;
            this.btnRout.UseVisualStyleBackColor = true;
            // 
            // frmRobotTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1250, 817);
            this.Controls.Add(this.txthostName);
            this.Controls.Add(this.cmbtxtServerIps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnRefreshServerIp);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRobotTest";
            this.Text = "Robot test";
            this.Load += new System.EventHandler(this.frmRobotTest_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSensorR;
        private System.Windows.Forms.Label lblSensorB;
        private System.Windows.Forms.Label lblSensorL;
        private System.Windows.Forms.Label lblSensorF;
        private System.Windows.Forms.Label lblBataryStrength;
        private System.Windows.Forms.Label lblWifiStrength;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxDataSent;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRout;
    }
}