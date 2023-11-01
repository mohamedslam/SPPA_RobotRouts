using System;
using System.Windows.Forms;
using WinApp_GraphicInterface.Forms.Auth;
using WinApp_GraphicInterface.Forms.DrawAreaPlan;
using WinApp_GraphicInterface.Forms.Robots;
using WinApp_GraphicInterface.Forms.Routes;

namespace WinApp_GraphicInterface.Forms
{//
    public partial class frmMainApp : Form
    {
        public frmMainApp()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void drowAreaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFormChild( new frmAreaProperites());        
        }

        private void rulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new Settings.frmRulerSetting());            
        }

        private void abotAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new frmAbout ());
        }
        void openFormChild(Form frm) {             
            frm.MdiParent = this;
            frm.Show();
        }

        private void heelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new frmHelp());
        }

        private void robotDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new frmRobotData());
        }

        private void addRobotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new frmAddRobot());
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new frmRouteCommand()); 
        }

        private void robotTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new frmRobotTest());

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new frmUsers());
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormChild(new frmAuthUsers());
        }
    }
}
