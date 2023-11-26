namespace WinApp_GraphicInterface.Forms.Robots.Camera
{
    partial class frmCamRobotTest
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStopStream = new System.Windows.Forms.Button();
            this.btnStartStream = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.picLiveStream = new System.Windows.Forms.PictureBox();
            this.grpCamera = new System.Windows.Forms.GroupBox();
            this.grpCameraControl = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackCameraServoMotor = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveStream)).BeginInit();
            this.grpCamera.SuspendLayout();
            this.grpCameraControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCameraServoMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 88);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStopStream
            // 
            this.btnStopStream.Enabled = false;
            this.btnStopStream.Location = new System.Drawing.Point(151, 501);
            this.btnStopStream.Name = "btnStopStream";
            this.btnStopStream.Size = new System.Drawing.Size(81, 41);
            this.btnStopStream.TabIndex = 10;
            this.btnStopStream.Text = "Stop";
            this.btnStopStream.UseVisualStyleBackColor = true;
            this.btnStopStream.Click += new System.EventHandler(this.btnStopStream_Click);
            // 
            // btnStartStream
            // 
            this.btnStartStream.Location = new System.Drawing.Point(151, 548);
            this.btnStartStream.Name = "btnStartStream";
            this.btnStartStream.Size = new System.Drawing.Size(81, 41);
            this.btnStartStream.TabIndex = 11;
            this.btnStartStream.Text = "Start";
            this.btnStartStream.UseVisualStyleBackColor = true;
            this.btnStartStream.Click += new System.EventHandler(this.btnStartStream_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(84, 51);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(142, 56);
            this.trackBar1.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox1.Location = new System.Drawing.Point(84, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Face Recognation";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // picLiveStream
            // 
            this.picLiveStream.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picLiveStream.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLiveStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLiveStream.Location = new System.Drawing.Point(3, 18);
            this.picLiveStream.Name = "picLiveStream";
            this.picLiveStream.Size = new System.Drawing.Size(702, 518);
            this.picLiveStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLiveStream.TabIndex = 15;
            this.picLiveStream.TabStop = false;
            // 
            // grpCamera
            // 
            this.grpCamera.Controls.Add(this.picLiveStream);
            this.grpCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCamera.Location = new System.Drawing.Point(0, 0);
            this.grpCamera.Name = "grpCamera";
            this.grpCamera.Size = new System.Drawing.Size(708, 539);
            this.grpCamera.TabIndex = 16;
            this.grpCamera.TabStop = false;
            this.grpCamera.Text = "Camera Live Streaming";
            // 
            // grpCameraControl
            // 
            this.grpCameraControl.Controls.Add(this.label2);
            this.grpCameraControl.Controls.Add(this.label3);
            this.grpCameraControl.Controls.Add(this.label1);
            this.grpCameraControl.Controls.Add(this.comboBox1);
            this.grpCameraControl.Controls.Add(this.checkBox1);
            this.grpCameraControl.Controls.Add(this.btnSave);
            this.grpCameraControl.Controls.Add(this.trackBar2);
            this.grpCameraControl.Controls.Add(this.trackBar1);
            this.grpCameraControl.Controls.Add(this.btnStopStream);
            this.grpCameraControl.Controls.Add(this.btnStartStream);
            this.grpCameraControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpCameraControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCameraControl.Location = new System.Drawing.Point(708, 0);
            this.grpCameraControl.Name = "grpCameraControl";
            this.grpCameraControl.Size = new System.Drawing.Size(238, 595);
            this.grpCameraControl.TabIndex = 17;
            this.grpCameraControl.TabStop = false;
            this.grpCameraControl.Text = "CameraSetting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Reselution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Flash Light";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Britnees";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(84, 91);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(142, 56);
            this.trackBar2.TabIndex = 13;
            // 
            // trackCameraServoMotor
            // 
            this.trackCameraServoMotor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackCameraServoMotor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackCameraServoMotor.Location = new System.Drawing.Point(0, 539);
            this.trackCameraServoMotor.Maximum = 180;
            this.trackCameraServoMotor.Name = "trackCameraServoMotor";
            this.trackCameraServoMotor.Size = new System.Drawing.Size(708, 56);
            this.trackCameraServoMotor.SmallChange = 5;
            this.trackCameraServoMotor.TabIndex = 18;
            this.trackCameraServoMotor.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackCameraServoMotor.Value = 90;
            // 
            // frmCamRobotTest
            // 
            this.ClientSize = new System.Drawing.Size(946, 617);
            this.Controls.Add(this.grpCamera);
            this.Controls.Add(this.trackCameraServoMotor);
            this.Controls.Add(this.grpCameraControl);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCamRobotTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCamRobotTest_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveStream)).EndInit();
            this.grpCamera.ResumeLayout(false);
            this.grpCameraControl.ResumeLayout(false);
            this.grpCameraControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCameraServoMotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStopStream;
        private System.Windows.Forms.Button btnStartStream;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox picLiveStream;
        private System.Windows.Forms.GroupBox grpCamera;
        private System.Windows.Forms.GroupBox grpCameraControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackCameraServoMotor;
    }
}
