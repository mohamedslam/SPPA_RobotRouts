using System;
using System.Windows.Forms;
using WinApp_GraphicInterface.Forms;
using WinApp_GraphicInterface.Forms.Robots;

namespace WinApp_GraphicInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainApp());
        }
    }
}
