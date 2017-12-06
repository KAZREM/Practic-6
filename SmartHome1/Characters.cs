using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome1
{
    public class Characteristics:ISwitchContract
    {
        public void SwitchOn(bool result)
        {
            if(result==false)
            {
                result = true;
            }
        }
        public void SwitchOff(bool result)
        {
            if(result==true)
            {
                result = false;
            }
        }
        
        public bool MediaSound { get; set; }
        public bool MediaTv { get; set; }
        public bool SecurityDoor { get;set; }
        public bool SecuritySignal { get; set; }
        public bool Access { get; set; }
        public bool LightState { get; set; }
    }
}
