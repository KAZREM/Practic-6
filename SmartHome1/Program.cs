using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome1
{
    class Program
    {
        static void Main(string[] args)
        {
            Room GuestRoom = new Room("guest");
            Room Kitchen = new Room("kitchen");
            Room BedRoom = new Room("bedroom");
            Room Toilet = new Room("toilet");
            Room Garage = new Room("garage");
            int menu;


            do
            {
                Console.WriteLine("1-ЗАЛ\n2-КУХНЯ\n3-СПАЛЬНЯ\n4-ТУАЛЕТ\n5-ГАРАЖ\n");
                bool result = int.TryParse(Console.ReadLine(), out menu);
                if (result) {

                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("1-Включить свет\n2-выключить свет\n");
                            result = int.TryParse(Console.ReadLine(), out menu);
                            if (result)
                            {
                                switch (menu)
                                {
                                    case 1:
                                        GuestRoom.SwitchOn(GuestRoom.LightState);
                                        break;
                                    case 2:
                                        GuestRoom.SwitchOff(GuestRoom.LightState);
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("NOT correctly parsing");
                            }
                            break;
                        case 3:
                            Console.WriteLine("1-Включить музыку\n2-выключить музыку\n");
                            result = int.TryParse(Console.ReadLine(), out menu);
                            if (result)
                            {
                                switch (menu)
                                {
                                    case 1:
                                        GuestRoom.SwitchOn(GuestRoom.MediaSound);
                                        break;
                                    case 2:
                                        GuestRoom.SwitchOff(GuestRoom.MediaSound);
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("NOT correctly parsing");
                            }
                            break;
                    }
                           



                }
                else
                {
                    Console.WriteLine("NOT correctly parsing");
                }
            }
            while (menu != 0);
       
        }
    }
}
