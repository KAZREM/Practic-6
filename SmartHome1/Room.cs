using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome1
{
    public class Room:Characteristics
    {
        public string name { get; set; }
        public Room() {}
        public Room(string name)
        {
            this.name = name;
        }
        
    }
}
