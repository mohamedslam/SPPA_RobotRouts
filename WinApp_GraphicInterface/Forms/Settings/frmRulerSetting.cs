using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_GraphicInterface.Forms.Settings
{
    public partial class frmRulerSetting : Form
    {
        public frmRulerSetting()
        {
            InitializeComponent();
          

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.propertyGrid.SelectedObject = this.hrulerControl;
            this.propertyGrid.CollapseAllGridItems();
        }
    }
}
