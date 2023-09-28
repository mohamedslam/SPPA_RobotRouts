
namespace WinApp_GraphicInterface.Forms.DrawAreaPlan
{
    partial class frmAreaProperites
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartDrow = new System.Windows.Forms.Button();
            this.txtWidthArea = new System.Windows.Forms.TextBox();
            this.txtheightArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCellWidth = new System.Windows.Forms.TextBox();
            this.txtCellHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAreaShape = new System.Windows.Forms.ComboBox();
            this.cmbUnitsAreaSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateCellSize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RobotInfo = new System.Windows.Forms.GroupBox();
            this.txtVSR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAreaSize = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.RobotInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(117, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // btnStartDrow
            // 
            this.btnStartDrow.Location = new System.Drawing.Point(7, 345);
            this.btnStartDrow.Name = "btnStartDrow";
            this.btnStartDrow.Size = new System.Drawing.Size(180, 47);
            this.btnStartDrow.TabIndex = 1;
            this.btnStartDrow.Text = "Start Drow";
            this.btnStartDrow.UseVisualStyleBackColor = true;
            this.btnStartDrow.Click += new System.EventHandler(this.btnStartDrow_Click);
            // 
            // txtWidthArea
            // 
            this.txtWidthArea.Location = new System.Drawing.Point(162, 52);
            this.txtWidthArea.Name = "txtWidthArea";
            this.txtWidthArea.Size = new System.Drawing.Size(48, 20);
            this.txtWidthArea.TabIndex = 2;
            this.txtWidthArea.Text = "5.75";
            this.txtWidthArea.TextChanged += new System.EventHandler(this.txtWidthArea_TextChanged);
            // 
            // txtheightArea
            // 
            this.txtheightArea.Location = new System.Drawing.Point(17, 209);
            this.txtheightArea.Name = "txtheightArea";
            this.txtheightArea.Size = new System.Drawing.Size(39, 20);
            this.txtheightArea.TabIndex = 3;
            this.txtheightArea.Text = "5.7";
            this.txtheightArea.TextChanged += new System.EventHandler(this.txtWidthArea_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cell Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cell Height:";
            // 
            // txtCellWidth
            // 
            this.txtCellWidth.Location = new System.Drawing.Point(96, 21);
            this.txtCellWidth.Name = "txtCellWidth";
            this.txtCellWidth.Size = new System.Drawing.Size(55, 20);
            this.txtCellWidth.TabIndex = 2;
            this.txtCellWidth.TextChanged += new System.EventHandler(this.txtWidthArea_TextChanged);
            // 
            // txtCellHeight
            // 
            this.txtCellHeight.Location = new System.Drawing.Point(96, 41);
            this.txtCellHeight.Name = "txtCellHeight";
            this.txtCellHeight.Size = new System.Drawing.Size(55, 20);
            this.txtCellHeight.TabIndex = 3;
            this.txtCellHeight.TextChanged += new System.EventHandler(this.txtWidthArea_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.RobotInfo);
            this.groupBox1.Controls.Add(this.btnStartDrow);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmbAreaShape);
            this.groupBox1.Controls.Add(this.cmbUnitsAreaSize);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 398);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Max Area Width and Height";
            // 
            // cmbAreaShape
            // 
            this.cmbAreaShape.FormattingEnabled = true;
            this.cmbAreaShape.Location = new System.Drawing.Point(72, 17);
            this.cmbAreaShape.Name = "cmbAreaShape";
            this.cmbAreaShape.Size = new System.Drawing.Size(114, 21);
            this.cmbAreaShape.TabIndex = 7;
            // 
            // cmbUnitsAreaSize
            // 
            this.cmbUnitsAreaSize.FormattingEnabled = true;
            this.cmbUnitsAreaSize.Location = new System.Drawing.Point(72, 40);
            this.cmbUnitsAreaSize.Name = "cmbUnitsAreaSize";
            this.cmbUnitsAreaSize.Size = new System.Drawing.Size(114, 21);
            this.cmbUnitsAreaSize.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Area Shape:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Unit Size:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.txtCellHeight);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnCalculateCellSize);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCellWidth);
            this.groupBox2.Location = new System.Drawing.Point(6, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 143);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid cell Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "cm";
            // 
            // btnCalculateCellSize
            // 
            this.btnCalculateCellSize.Location = new System.Drawing.Point(96, 113);
            this.btnCalculateCellSize.Name = "btnCalculateCellSize";
            this.btnCalculateCellSize.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateCellSize.TabIndex = 1;
            this.btnCalculateCellSize.Text = "Calc";
            this.btnCalculateCellSize.UseVisualStyleBackColor = true;
            this.btnCalculateCellSize.Click += new System.EventHandler(this.btnCalculateCellSize_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "cm";
            // 
            // RobotInfo
            // 
            this.RobotInfo.Controls.Add(this.comboBox1);
            this.RobotInfo.Controls.Add(this.txtVSR);
            this.RobotInfo.Controls.Add(this.label10);
            this.RobotInfo.Controls.Add(this.label9);
            this.RobotInfo.Location = new System.Drawing.Point(0, 123);
            this.RobotInfo.Name = "RobotInfo";
            this.RobotInfo.Size = new System.Drawing.Size(189, 67);
            this.RobotInfo.TabIndex = 7;
            this.RobotInfo.TabStop = false;
            this.RobotInfo.Text = "Robot Info";
            // 
            // txtVSR
            // 
            this.txtVSR.Location = new System.Drawing.Point(72, 41);
            this.txtVSR.Name = "txtVSR";
            this.txtVSR.Size = new System.Drawing.Size(114, 20);
            this.txtVSR.TabIndex = 2;
            this.txtVSR.Text = "5";
            this.txtVSR.TextChanged += new System.EventHandler(this.txtWidthArea_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "VSR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Select Robot:";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblAreaSize);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtheightArea);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtWidthArea);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(198, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 379);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "AreaSize:";
            // 
            // lblAreaSize
            // 
            this.lblAreaSize.AutoSize = true;
            this.lblAreaSize.BackColor = System.Drawing.Color.Transparent;
            this.lblAreaSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaSize.Location = new System.Drawing.Point(172, 347);
            this.lblAreaSize.Name = "lblAreaSize";
            this.lblAreaSize.Size = new System.Drawing.Size(18, 19);
            this.lblAreaSize.TabIndex = 4;
            this.lblAreaSize.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WinApp_GraphicInterface.Properties.Resources.Area;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Cell X Count:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Cell Y Count:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "AreaName";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 9;
            // 
            // frmAreaProperites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAreaProperites";
            this.Text = "AreaProperites";
            this.Load += new System.EventHandler(this.frmAreaProperites_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.RobotInfo.ResumeLayout(false);
            this.RobotInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartDrow;
        private System.Windows.Forms.TextBox txtWidthArea;
        private System.Windows.Forms.TextBox txtheightArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCellWidth;
        private System.Windows.Forms.TextBox txtCellHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUnitsAreaSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAreaShape;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculateCellSize;
        private System.Windows.Forms.GroupBox RobotInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtVSR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAreaSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
    }
}