using SPPA.Models.AreaModels;
using SPPA.Models.Enumurations;
using System;
using System.Windows.Forms;

namespace WinApp_GraphicInterface.Forms.DrawAreaPlan
{
    public partial class frmAreaProperites : Form
    {
        public AreaProperitesModel AreaProperites{ get; set; }
        public frmAreaProperites()
        {
            InitializeComponent();
            AreaProperites = new AreaProperitesModel();
        }

        private void btnStartDrow_Click(object sender, EventArgs e)
        {
            try
            {
                AreaProperites.VSR = int.Parse(txtVSR.Text);
                this.Hide();
                Form frm = new FlowSharpUI(AreaProperites);
                frm.MdiParent = this.ParentForm;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmAreaProperites_Load(object sender, EventArgs e)
        {
            foreach (UnitAreaSize u in Enum.GetValues(typeof(UnitAreaSize)))
            {
                cmbUnitsAreaSize.Items.Add(u);
            }
            cmbUnitsAreaSize.SelectedIndex = 0;
            foreach (AreaFigureShape s in Enum.GetValues(typeof(AreaFigureShape)))
            {
                cmbAreaShape.Items.Add(s);
            }
            cmbAreaShape.SelectedIndex = 0;
        }

        private void btnCalculateCellSize_Click(object sender, EventArgs e)
        {
            try
            {
           
                calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void txtWidthArea_TextChanged(object sender, EventArgs e)
        {
            try
            {
            AreaProperites.Width = double.Parse(txtWidthArea.Text);
            AreaProperites.Height = double.Parse(txtheightArea.Text);
            lblAreaSize.Text = AreaProperites.AreaSquarSize.ToString()+" M";
            calculate();
            }
            catch  
            {
 
            }               
        }

        void calculate()
        {
            AreaProperites.CountCellHeght = Convert.ToInt32( AreaProperites.Height *100/ int.Parse(txtVSR.Text));
            AreaProperites.CountCellWidth = Convert.ToInt32(AreaProperites.Width *100/ int.Parse(txtVSR.Text));
            txtCellHeight.Text = AreaProperites.CountCellHeght.ToString();
            txtCellWidth.Text = AreaProperites.CountCellWidth.ToString();        
        }
    }
}
