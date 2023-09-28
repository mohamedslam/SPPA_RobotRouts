using System.Diagnostics;
using WinApp_GraphicInterface.Forms.DrawAreaPlan;

namespace Class.DrawArea
{
    public class TraceListener : ConsoleTraceListener
    {
        public DlgDebugWindow DebugWindow { get; set; }

        public override void WriteLine(string msg)
        {
            if (DebugWindow != null)
            {
                DebugWindow.Trace(msg + "\r\n");
            }
        }
    }
}
