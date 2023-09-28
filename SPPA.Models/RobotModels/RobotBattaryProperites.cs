using System;
using System.Collections.Generic;
using System.Text;

namespace SPPA.Models.RobotModels
{
  public  class RobotBattaryProperites
    {
        public string BattaryType { get; set; }
        public string BattaryName { get; set; }
        public double  Volt { get; set; }
        public double Wat { get; set; }
        public double HoursWork { get; set; }
    }
}
