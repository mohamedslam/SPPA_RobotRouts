using System;
using System.Collections.Generic;
using System.Text;

namespace SPPA.Models.RobotModels.RobotProperitesModels
{
    public class RobotMovmentModel
    {
        public long  x { get; set; }
        public long Y { get; set; }
        public byte Speed { get; set; }
        public string ForwordStep { get; set; }
        public string BackStep { get; set; }
        public string RightStep { get; set; }
        public string LeftStep { get; set; }
        public string RighSelftStep { get; set; }
        public string LeftSelfStep { get; set; }
        public string Degree { get; set; }
    }
}
