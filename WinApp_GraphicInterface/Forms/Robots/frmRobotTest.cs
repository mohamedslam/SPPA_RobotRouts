using Chilkat;
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
  namespace WinApp_GraphicInterface.Forms.Robots
{
    public partial class frmRobotTest : Form
    {
        public frmRobotTest()
        {
            InitializeComponent();
        }


        string data = "";
        string date = "";

        string[] data_str = new string[25];
        bool  status = false;

        [Obsolete]
        void myIP()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            txthostName.Text = hostName;
            foreach (var  ip in Dns.GetHostByName(hostName).AddressList) { 
               cmbtxtServerIps.Items.Add(ip.ToString());
            }
            cmbtxtServerIps.SelectedIndex = 1;
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
        RecivedDataRobotModel recivedDataModel;
        void AnalyzingDataRecivedFromRobots(string msgdata)
        {
            msgdata =
                  "RealdateTime:11:21:53:777;" +
                  "RobotName:Sallam1;" +
                  "Batary:100volt;" +
                  "Wifi:50dBm;" +
                  "Sensor:FM30,FR10,FL20,R40,L50,B60;" +
                  "Movment:X1200,Y1400,S155,F9999,R1234,RS10,L10,LS20,B600,H0;" +
                  "Cam:Pic_imageName,Pix600,800;" +
                  "Status:Home;" +
                  "5997;1909.873";

            recivedDataModel = ReadLine(msgdata, ';');
            
        }
         public   RecivedDataRobotModel ReadLine(string dataline,char sperated) {            
                    var values = dataline.Split(sperated);
                    var model = new RecivedDataRobotModel
                    {
                        RealServerDateTime = values[0],
                        RobotName = values[1],
                        Battary = values[2],
                        Wifi = values[3],
                        Sensor = values[4],
                        Movment = values[5],
                        Camera = values[6],
                        Status = values[7],
                        RealRobotDateTime = values[8],
                    };

                  return model;
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
      
        private void SendCommand(string command)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(txtRobotIP.Text, Convert.ToInt16(txtPort.Text));
            Byte[] senddata = Encoding.ASCII.GetBytes(command);
            udpClient.Send(senddata, senddata.Length);
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
            SendCommand(txtMsg.Text);
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
            SendCommand("speed " + trackSpeed.Value.ToString());
        }

        [Obsolete]
        private void frmRobotTest_Load_1(object sender, EventArgs e)
        {
            myIP();
        }

        
        private void btnOriantation_Click(object sender, EventArgs e)
        {
            var btnOriantation= (System.Windows.Forms.Button)sender;
            string command = btnOriantation.Name.ToLower().Replace("btn","");            
            SendCommand(command);
        }

        private void btnCam_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnRout_Click(object sender, EventArgs e)
        {

        }
    }
}
