using System;
using System.Windows.Forms;
using WinApp_GraphicInterface.Forms.DrawAreaPlan;

namespace WinApp_GraphicInterface.Forms
{
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
            Form frm = new frmAreaProperites();
             frm.MdiParent=this ;
            frm.Show ();
        }

        private void rulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Settings.frmRulerSetting();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
