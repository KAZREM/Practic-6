using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome1
{
    public interface ISwitchContract
    {
        void SwitchOn(bool result);
        void SwitchOff(bool result);
    }
   
        //bool MediaSound();
        //bool MediaTv;
        //bool SecurityDoor();
        //bool SecuritySignal();
        //bool Access();
        //bool LightState();
    }
}
