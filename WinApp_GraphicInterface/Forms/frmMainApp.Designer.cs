
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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abotAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.rulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drowAreaToolStripMenuItem,
            this.robotToolStripMenuItem,
            this.routeToolStripMenuItem,
            this.menuSetting,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drowAreaToolStripMenuItem
            // 
            this.drowAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drowAreaToolStripMenuItem1});
            this.drowAreaToolStripMenuItem.Name = "drowAreaToolStripMenuItem";
            this.drowAreaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.drowAreaToolStripMenuItem.Text = "Area";
            // 
            // drowAreaToolStripMenuItem1
            // 
            this.drowAreaToolStripMenuItem1.Name = "drowAreaToolStripMenuItem1";
            this.drowAreaToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.drowAreaToolStripMenuItem1.Text = "DrowArea";
            this.drowAreaToolStripMenuItem1.Click += new System.EventHandler(this.drowAreaToolStripMenuItem1_Click);
            // 
            // robotToolStripMenuItem
            // 
            this.robotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robotDataToolStripMenuItem});
            this.robotToolStripMenuItem.Name = "robotToolStripMenuItem";
            this.robotToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.robotToolStripMenuItem.Text = "Robot";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abotAppToolStripMenuItem,
            this.heelpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandToolStripMenuItem});
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            this.routeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.routeToolStripMenuItem.Text = "Route";
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.commandToolStripMenuItem.Text = "Command";
            // 
            // robotDataToolStripMenuItem
            // 
            this.robotDataToolStripMenuItem.Name = "robotDataToolStripMenuItem";
            this.robotDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.robotDataToolStripMenuItem.Text = "Robot Data";
            // 
            // abotAppToolStripMenuItem
            // 
            this.abotAppToolStripMenuItem.Name = "abotAppToolStripMenuItem";
            this.abotAppToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.abotAppToolStripMenuItem.Text = "AboutApp";
            // 
            // heelpToolStripMenuItem
            // 
            this.heelpToolStripMenuItem.Name = "heelpToolStripMenuItem";
            this.heelpToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.heelpToolStripMenuItem.Text = "Heelp";
            // 
            // menuSetting
            // 
            this.menuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulerToolStripMenuItem});
            this.menuSetting.Name = "menuSetting";
            this.menuSetting.Size = new System.Drawing.Size(56, 20);
            this.menuSetting.Text = "Setting";
            // 
            // rulerToolStripMenuItem
            // 
            this.rulerToolStripMenuItem.Name = "rulerToolStripMenuItem";
            this.rulerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rulerToolStripMenuItem.Text = "Ruler";
            this.rulerToolStripMenuItem.Click += new System.EventHandler(this.rulerToolStripMenuItem_Click);
            // 
            // frmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
    }
}