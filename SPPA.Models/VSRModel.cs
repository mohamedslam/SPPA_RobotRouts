using System;
using System.Collections.Generic;
using System.Text;

namespace SPPA.Models
{
  public  class VSRModel
    {
        public enum MovmentMotorType { 
        DC,
        Servo,
        Step
        }
        public MovmentMotorType MotorType { get; set; }
        private int vsr;
        public int VSR
        {
            get
            {
                //need to calculated that for many type of motor and then 
                //Calculating the speed of the motor under load and the effect of each gram on it
                int rpm = 0;
                if (MotorType == MovmentMotorType.DC)
                    rpm = 2400;
                else if (MotorType == MovmentMotorType.DC)
                    rpm = 0;
                else if (MotorType == MovmentMotorType.DC)
                    rpm = 0;

                vsr = 5;///
                return vsr;
            }
        }

        public double Volts { get; set; }=3;       
        public int Centimeter { get; set; }
        public int Second { get; set; } = 60;
    }
}
