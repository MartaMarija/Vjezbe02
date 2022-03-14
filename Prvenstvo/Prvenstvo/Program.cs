using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRVENSTVO APP\n------------------------------");

            int izbor = -1;

            Prvenstvo prvenstvo = new Prvenstvo();

            while (izbor != 0)
            {
                Console.WriteLine("[1] Unesi reprezentaciju\n[2] Evidentiraj utakmicu\n[3] Ispiši tablicu rezultata\n[4] Ispiši bodovnu ljestvicu\n[0] Izlaz\n------------------------------");
                izbor = int.Parse(Console.ReadLine());

                switch(izbor)
                {
                    case 1:
                        {
                            string[] unosReprezentacije = Console.ReadLine().Split(' ');
                            prvenstvo.DodajReprezentaciju(unosReprezentacije[0], unosReprezentacije[1]);
                            break;
                        }
                    case 2:
                        {
                            string[] unosUtakmice = Console.ReadLine().Split(':');
                            prvenstvo.DodajUtakmicu(unosUtakmice[0].Substring(0, 3), unosUtakmice[1].Substring(2), int.Parse(unosUtakmice[0].Substring(4)), int.Parse(unosUtakmice[1].Substring(0, 1)));
                            break;
                        }
                    case 3:
                        {
                            prvenstvo.GenerirajTablicuRezultata();
                            break;
                        }
                    case 4:
                        {
                            prvenstvo.GenerirajBodovnuLjestvicu();
                            break;
                        }
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
    }
}
