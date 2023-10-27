using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace SPPA.Models.RobotModels.RobotProperitesModels
{
    public  class RobotCameraModel
    {
        public string Name { get; set; }
        public string Ip { get; set; } = string.Empty;
        public string  ImageName {  get; set; } = string.Empty;
        public string WidthPixl { get; set; }
        public string HeightPixl { get; set; }
        public string locationX { get; set; }
        public string locationY { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }
}
