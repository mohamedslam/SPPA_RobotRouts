using System;
using System.Collections.Generic;
using System.Text;

namespace SPPA.Models.Enumurations
{
    public enum RobotStatus { 
        InAreaHome,
        Runing,
        Pause,
        Stop,
        ChekingPointRoute,
        InAreaGoal,
        OutService
    }
}
