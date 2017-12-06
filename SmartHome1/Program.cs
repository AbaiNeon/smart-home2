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
                            Console.Clear();
                            Console.WriteLine("1-свет\n2-тв\n3-музыка\n4-температура\n");
                            result = int.TryParse(Console.ReadLine(), out menu);
                            if (result)
                            {
                                switch (menu)
                                {

                                }
                            }
                            else
                            {
                                Console.WriteLine("NOT correctly parsing");
                            }

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
