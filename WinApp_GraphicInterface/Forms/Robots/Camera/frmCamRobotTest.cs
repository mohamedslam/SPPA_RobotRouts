using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace WinApp_GraphicInterface.Forms.Robots.Camera
{
    public partial class frmCamRobotTest : WinApp_GraphicInterface.Forms.frmBase
    {
      
        MJPEGStream stream;
        string IpCam = "";
        public frmCamRobotTest(string ipCam,int port)
        {
            InitializeComponent();
            IpCam = ipCam;
            // stream = new MJPEGStream("http://50.197.223.170:80/mjpg/video.mjpg"); 
            stream = new MJPEGStream("http://" + ipCam+ ":"+ port.ToString()+ "/stream");
            // set event handlers
            stream.NewFrame +=  video_NewFrame;
            StartStream();
         }
        void StartStream() { 
         // start the video source
            stream.Start();      
            btnStopStream.Enabled = true;
            btnSave.Enabled = true;
            btnStartStream.Enabled = false;

        }
        void StopStream()
        {
            // Stop the video source
            stream.Stop();
            btnStopStream.Enabled = false;
            btnSave.Enabled = false;
            btnStartStream.Enabled = true;
        }

        void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap FrameData =  (Bitmap)eventArgs.Frame.Clone();            
            picLiveStream.Image = FrameData;
        }
        private void btnStartStream_Click(object sender, EventArgs e)
        {
            StartStream();
            }

        private void btnStopStream_Click(object sender, EventArgs e)
        {
             StopStream();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmCamRobotTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream.Stop();
        }
    }
}
