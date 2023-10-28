using System;
using System.Collections.Generic;
using System.Text;
using SPPA.Models.RobotModels.RobotProperitesModels;

namespace SPPA.Models.RobotModels
{
    public class RobotProperitesModel
    {
        public string RobotName { get; set; }
        public VSRModel RobotSpeed { get; set; }
        public RobotBattaryProperites Battry { get; set; }
        public SizeModel RobotSize { get; set; }
        public long RobotWeight { get; set; }
        public int SafeDistance { get; set; }
    }
}
