using SPPA.Models.RobotModels.RobotProperitesModels;
using System;

namespace SPPA.Models.RobotModels
{
    public class RecivedDataRobotModel
    {
        private string RealServerDateTime;
        //private string RealRobotDateTime;
        private string Status;
        private string RobotName;
        private string Battary;
        private string Wifi;
        private string Sensor;
        private string Movment;
        private string Camera;
        public DateTime RealServerDateTimeModel { get; set; }
      //  public DateTime RealRobotDateTimeModel { get; set; }
        public string StatusModel;
        public RobotNameModel NameModel { get; set; }
        public RobotBattaryProperites BattaryModel { get; set; }
        public RobotWifiModel WifiModel { get; set; }
        public RobotSensorModel SensorModel { get; set; }
        public RobotMovmentModel MovmentModel { get; set; }
        public RobotCameraModel CameraModel { get; set; }
        public RecivedDataRobotModel(string data)
        { 
            ReadLine(data, ';');
            //RealServerDateTimeModel = SetAllMemberData<DateTime >(RealServerDateTime);
            NameModel= SetAllMemberData<RobotNameModel>(RobotName);
            BattaryModel=SetAllMemberData<RobotBattaryProperites>(Battary);
            WifiModel = SetAllMemberData<RobotWifiModel>(Wifi);
            SensorModel = SetAllMemberData<RobotSensorModel>(Sensor);
            MovmentModel = SetAllMemberData<RobotMovmentModel>(Movment);
            CameraModel = SetAllMemberData<RobotCameraModel>(Camera);
         
            //RealRobotDateTimeModel = SetAllMemberData<DateTime>(RealRobotDateTime);
            StatusModel = SetAllMemberData<string >(Status);
        }
        public T SetAllMemberData<T>(string data)
        {
             
            var Prefixdata = data.Substring(0, data.IndexOf(':'));
            var dataSplit= data.Replace(":","").Replace(Prefixdata,"").Split(',');
            object value=null ;
            if (Prefixdata == "RealdateTime") {
                DateTime  temp;
                temp = DateTime.Parse( dataSplit[0]);
                 
                value = temp;
            }
            else if (Prefixdata == "Status")
            {
                string temp;
                temp = dataSplit[0];

                value = temp;
            }
            else if (Prefixdata == "RobotName")
            {
                var temp = new RobotNameModel();
                temp.Name = dataSplit[0];
                // temp.Ip = dataSplit[1];

                value = temp;
            }
            else if (Prefixdata == "Batary") {
                var temp = new RobotBattaryProperites();
                temp.BattaryType = "LI";
                temp.BattaryHealthy = dataSplit[0];
                temp.Volt = 12;
                temp.Wat = 2600;

                value = temp;
            }
            else if (Prefixdata == "Wifi")
            {
                var temp = new RobotWifiModel();
                temp.Stringth = dataSplit[0];

                value = temp;
            }
            else if (Prefixdata == "Sensor")
            {
                var temp = new RobotSensorModel();
                temp.SensorForwardMidel = dataSplit[0].Remove(0, 2);
                temp.SensorForwardRight = dataSplit[1].Remove(0, 2); 
                temp.SensorForwardLeft = dataSplit[2].Remove(0, 2); 
                temp.SensorRight = dataSplit[3].Remove(0, 1); 
                temp.SensorLeft = dataSplit[4].Remove(0, 1); ;
                temp.SensorBehindMidel = dataSplit[5].Remove(0, 1); ;

                value = temp;
            }
            else if (Prefixdata == "Status")
            {
                Status = dataSplit[0];
            }
            else if (Prefixdata == "Movment")
            {
                var temp = new RobotMovmentModel();
                temp.x = long.Parse(dataSplit[0].Remove(0,1));
                temp.Y = long.Parse(dataSplit[1].Remove(0, 1));
                temp.Speed = byte.Parse(dataSplit[2].Remove(0, 1));
                temp.ForwordStep = dataSplit[3];
                temp.RightStep = dataSplit[4];
                temp.RighSelftStep = dataSplit[5];
                temp.LeftStep = dataSplit[6];
                temp.LeftSelfStep = dataSplit[7];
                temp.BackStep = dataSplit[8];
                temp.Degree = dataSplit[9];

                value = temp;
            }
            else if (Prefixdata == "Camera")
            {
                var temp = new RobotCameraModel();
                temp.ImageName = dataSplit[0];
                temp.WidthPixl = dataSplit[1];
                temp.HeightPixl = dataSplit[2];
                value = temp;
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }
        public void ReadLine(string dataline, char sperated)
        {
                var values = dataline.Split(sperated);
                {
                    RealServerDateTime = values[0];
                    RobotName = values[1];
                    Battary = values[2];
                    Wifi = values[3];
                    Sensor = values[4];
                    Movment = values[5];
                    Camera = values[6];
                    Status = values[7];
                    //  RealRobotDateTime = values[8];
                }       
        }
    }
}
