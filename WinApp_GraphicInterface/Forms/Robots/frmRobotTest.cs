using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

                    textBoxSender.Text = RemoteIpEndPoint.Address.ToString();

                    richTextBoxDataReceived.AppendText(data + "\n");
                    richTextBoxDataReceived.ScrollToCaret();
                }

                ));
            }



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
    }
}
