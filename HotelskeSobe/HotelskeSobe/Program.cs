using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] naredba = new string[2];
            Hotel hotel = new Hotel();
            while(naredba[0] != "#exit")
            {
                Console.WriteLine("Unesite naredbu:");
                naredba = (Console.ReadLine()).Split();

                switch(naredba[0])
                {
                    case "#pronadji":
                        {
                            List<Soba> soba = hotel.PronadjiSobe(int.Parse(naredba[1]));
                            foreach(Soba item in soba)
                            {
                                Console.WriteLine($"Oznaka: {item.Oznaka}, Kapacitet:{item.Kapacitet}");
                            }
                            break;
                        }
                    case "#rezerviraj":
                        {
                            hotel.RezervirajSobu(naredba[1]);
                            break;
                        }
                    default:
                        Console.WriteLine("Unesena kriva naredba");
                        break;
                }
            }
        }
    }
}
