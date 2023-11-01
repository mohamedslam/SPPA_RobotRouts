
namespace WinApp_GraphicInterface.Forms
{
    partial class frmMainApp
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drowAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drowAreaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.robotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRobotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.rulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abotAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drowAreaToolStripMenuItem,
            this.robotToolStripMenuItem,
            this.routeToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.menuSetting,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drowAreaToolStripMenuItem
            // 
            this.drowAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drowAreaToolStripMenuItem1});
            this.drowAreaToolStripMenuItem.Name = "drowAreaToolStripMenuItem";
            this.drowAreaToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.drowAreaToolStripMenuItem.Text = "Area";
            // 
            // drowAreaToolStripMenuItem1
            // 
            this.drowAreaToolStripMenuItem1.Name = "drowAreaToolStripMenuItem1";
            this.drowAreaToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.drowAreaToolStripMenuItem1.Text = "Draw Area";
            this.drowAreaToolStripMenuItem1.Click += new System.EventHandler(this.drowAreaToolStripMenuItem1_Click);
            // 
            // robotToolStripMenuItem
            // 
            this.robotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robotDataToolStripMenuItem,
            this.addRobotToolStripMenuItem,
            this.robotTestToolStripMenuItem});
            this.robotToolStripMenuItem.Name = "robotToolStripMenuItem";
            this.robotToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.robotToolStripMenuItem.Text = "Robot";
            // 
            // robotDataToolStripMenuItem
            // 
            this.robotDataToolStripMenuItem.Name = "robotDataToolStripMenuItem";
            this.robotDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.robotDataToolStripMenuItem.Text = "Robot Data";
            this.robotDataToolStripMenuItem.Click += new System.EventHandler(this.robotDataToolStripMenuItem_Click);
            // 
            // addRobotToolStripMenuItem
            // 
            this.addRobotToolStripMenuItem.Name = "addRobotToolStripMenuItem";
            this.addRobotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addRobotToolStripMenuItem.Text = "Add Robot";
            this.addRobotToolStripMenuItem.Click += new System.EventHandler(this.addRobotToolStripMenuItem_Click);
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandToolStripMenuItem});
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            this.routeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.routeToolStripMenuItem.Text = "Route";
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.commandToolStripMenuItem.Text = "Command";
            this.commandToolStripMenuItem.Click += new System.EventHandler(this.commandToolStripMenuItem_Click);
            // 
            // menuSetting
            // 
            this.menuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulerToolStripMenuItem});
            this.menuSetting.Name = "menuSetting";
            this.menuSetting.Size = new System.Drawing.Size(70, 24);
            this.menuSetting.Text = "Setting";
            // 
            // rulerToolStripMenuItem
            // 
            this.rulerToolStripMenuItem.Name = "rulerToolStripMenuItem";
            this.rulerToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.rulerToolStripMenuItem.Text = "Ruler";
            this.rulerToolStripMenuItem.Click += new System.EventHandler(this.rulerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abotAppToolStripMenuItem,
            this.heelpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // abotAppToolStripMenuItem
            // 
            this.abotAppToolStripMenuItem.Name = "abotAppToolStripMenuItem";
            this.abotAppToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.abotAppToolStripMenuItem.Text = "About App";
            this.abotAppToolStripMenuItem.Click += new System.EventHandler(this.abotAppToolStripMenuItem_Click);
            // 
            // heelpToolStripMenuItem
            // 
            this.heelpToolStripMenuItem.Name = "heelpToolStripMenuItem";
            this.heelpToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.heelpToolStripMenuItem.Text = "Help";
            this.heelpToolStripMenuItem.Click += new System.EventHandler(this.heelpToolStripMenuItem_Click);
            // 
            // robotTestToolStripMenuItem
            // 
            this.robotTestToolStripMenuItem.Name = "robotTestToolStripMenuItem";
            this.robotTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.robotTestToolStripMenuItem.Text = "Robot Test";
            this.robotTestToolStripMenuItem.Click += new System.EventHandler(this.robotTestToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.rolesToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // frmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainApp";
            this.Text = "SPPA Rout Robot System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drowAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drowAreaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem robotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abotAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSetting;
        private System.Windows.Forms.ToolStripMenuItem rulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRobotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
    }
}