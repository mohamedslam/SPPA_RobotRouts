using CsvHelper;
using SPPA.Models.RobotModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WinApp_GraphicInterface.Forms.Robots.Camera;

namespace WinApp_GraphicInterface.Forms.Robots
{
    public partial class frmRobotTest : Form
    {
        public frmRobotTest()
        {
            InitializeComponent();
        }

        RecivedDataRobotModel recivedDataModel;
        string data = "";
        string date = "";

        string[] data_str = new string[25];
        bool  status = false;

        [Obsolete]
        void myIP()
        {
            try
            {
                string hostName = Dns.GetHostName(); // Retrive the Name of HOST
                txthostName.Text = hostName;
                foreach (var ip in Dns.GetHostByName(hostName).AddressList)
                {
                    cmbtxtServerIps.Items.Add(ip.ToString());
                }
                cmbtxtServerIps.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ther is problem in detecation Ip for robot you need to call support and say that msg: \n"+ex.Message);
            }

        }
        public void serverThread() //SERVER
        {
            UdpClient udpClient = new UdpClient(8080);
            while (status)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any,int.Parse( txtPort.Text));
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);


                this.Invoke(new MethodInvoker(delegate ()
                {
                    date = DateTime.Now.ToString("hh:mm:ss:fff;");
                    data = date + returnData;
                    //toDo Analyzing String Msg
                   AnalyzingDataRecivedFromRobots(data);
                    textBoxSender.Text = RemoteIpEndPoint.Address.ToString();

                    richTextBoxDataReceived.AppendText(data + "\n");
                    richTextBoxDataReceived.ScrollToCaret();
                }

                ));
            }
        }
      
        void AnalyzingDataRecivedFromRobots(string msgdata)
        {
            //msgdata =
            //      "RealdateTime:11:21:53:777;" +
            //      "RobotName:Sallam1;" +
            //      "Batary:100volt;" +
            //      "Wifi:50dBm;" +
            //      "Sensor:FM30,FR10,FL20,R40,L50,B60;" +
            //      "Movment:X1200,Y1400,S155,F9999,R1234,RS10,L10,LS20,B600,H0;" +
            //      "Camera:Pic_imageName,600,800;" +
            //      "Status:Home;" +
            //      "5997;1909.873";

            recivedDataModel = new RecivedDataRobotModel(msgdata);
            txtRobotName.Text = recivedDataModel.NameModel.Name;
            lblBataryStrength.Text = recivedDataModel.BattaryModel.BattaryHealthy;
            lblWifiStrength.Text = recivedDataModel.WifiModel.Stringth;
           // lblSpeedValue.Text = recivedDataModel.MovmentModel.Speed.ToString();
           // trackSpeed.Value = recivedDataModel.MovmentModel.Speed;
            lblSensorF.Text = recivedDataModel.SensorModel.SensorForwardMidel;
            lblSensorFR.Text = recivedDataModel.SensorModel.SensorForwardRight;
            lblSensorFL.Text = recivedDataModel.SensorModel.SensorForwardLeft;
            lblSensorR.Text = recivedDataModel.SensorModel.SensorRight;
            lblSensorL.Text = recivedDataModel.SensorModel.SensorLeft;
            lblSensorB.Text = recivedDataModel.SensorModel.SensorBehindMidel;
        }
  

        public static List<RecivedDataRobotModel> ReadCSVDataFromFile(string filePath)
        {
            List<RecivedDataRobotModel> records;
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                   // csv.Configuration.HasHeaderRecord = true;
                    records = csv.GetRecords<RecivedDataRobotModel>().ToList();
                }
            }
            return records;
        }
      public enum CommandType
        {
            SMC,//System Motor   Control
            SSC,//       Sensor  Control
            SCC,//       Camera  Control
            SDC,//       Display Control
            SCW,//       WiFi    Control
            SDS,//       Data    Serial 
            SDR,//       Data    Route
            RMC,
            RSC,
        }
        public  void SendCommand(string command, CommandType commandType)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(txtRobotIP.Text, Convert.ToInt16(txtPort.Text));
            Byte[] senddata = Encoding.ASCII.GetBytes(commandType.ToString()+">"+command);
            udpClient.Send(senddata, senddata.Length);

            richTextBoxDataSent.AppendText(DateTime.Now.ToString("hh:mm:ss.fff")+": "+ commandType.ToString() + ">" + command + "\n");

            if (checkBox1.Checked == true)
            {
                richTextBoxDataSent.ScrollToCaret();
            }
            else
            {
                richTextBoxDataSent.ScrollBars = RichTextBoxScrollBars.None;
            }
        }

      
        [Obsolete]
        private void frmRobotTest_Load(object sender, EventArgs e)
        {
            myIP();
        }

        [Obsolete]
        private void btnRefreshServerIp_Click(object sender, EventArgs e)
        {
            myIP();
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            SendCommand(txtMsg.Text, CommandType.SDS);
        }       

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbtxtServerIps.SelectedIndex == -1)
                return;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));

            thdUDPServer.IsBackground = true; //<-- Set the thread to work in background
            thdUDPServer.Start();
            
            status = true;
            btnConnect.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxDataReceived.Clear();
        }

        private void trackSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeedValue.Text = trackSpeed.Value.ToString();
            SendCommand("speed " + trackSpeed.Value.ToString(), CommandType.SMC);
        }

        [Obsolete]
        private void frmRobotTest_Load_1(object sender, EventArgs e)
        {
            myIP();
        }
         
        private void btnClearRecived_Click(object sender, EventArgs e)
        {
            richTextBoxDataReceived.Clear();
        }

        private void btnClearSent_Click(object sender, EventArgs e)
        {
            richTextBoxDataSent.Clear();
        } 
        private void btnCam_Click(object sender, EventArgs e)
        {
            SendCommand("StartCam", CommandType.SCC);
            new frmCamRobotTest("192.168.43.41",81).ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                richTextBoxDataSent.ScrollToCaret();
            }
            else
            {
                richTextBoxDataSent.ScrollBars= RichTextBoxScrollBars.None;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                richTextBoxDataReceived.ScrollToCaret();
            }
            else
            {
                richTextBoxDataReceived.ScrollBars = RichTextBoxScrollBars.None;
            }
        }

        private void btnsControl_MouseDown(object sender, MouseEventArgs e)
        {
            var btnOriantation = (Button)sender;
            string command = btnOriantation.Name.ToLower().Replace("btn", "")+";Step:"+txtSteps.Text+";Angle:"+cmbAngle.Text;
            if (trackSpeed.Value == 0)
            {
                trackSpeed.Value = 100;
                SendCommand("speed " + trackSpeed.Value.ToString(), CommandType.SMC);

            }
            SendCommand(command, CommandType.SMC);
        }

        private void btnsControl_MouseUp(object sender, MouseEventArgs e)
        {
            SendCommand("stop", CommandType.SMC);
        }

        private void trackSensorServoMotor_Scroll(object sender, EventArgs e)
        {
            SendCommand("Servo " + trackSensorServoMotor.Value.ToString(), CommandType.SSC);
        }

        private void btnWiFi_Click(object sender, EventArgs e)
        {
            SendCommand("WiFiData", CommandType.SCW);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SendCommand("Home", CommandType.SDR);
        }

        private void btnRout_Click(object sender, EventArgs e)
        {
            string dataRoute = "";
            SendCommand(dataRoute, CommandType.SDR);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SendCommand("stop", CommandType.SMC);
        }

        private void btnRMS_Click(object sender, EventArgs e)
        {
            SendCommand("", CommandType.RMC);
        }

        private void btnRSC_Click(object sender, EventArgs e)
        {
            SendCommand("", CommandType.RSC);
        }
    }
}
