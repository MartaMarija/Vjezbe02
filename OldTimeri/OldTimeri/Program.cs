using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vozilo> vozila = new List<Vozilo>();
            int unos = 0;

            while(unos != 3)
            {
                Console.Clear();
                Console.WriteLine("1. Dodavanje vozila\n2. Ispis vozila\n3. Izlaz\nŠto želite:");
                unos = int.Parse(Console.ReadLine());

                switch(unos)
                {
                    case 1:
                        Console.WriteLine("Unesite tip vozila: (A/M):");
                        string tip = Console.ReadLine();
                        Console.WriteLine("Unesite naziv vozila:");
                        string naziv = Console.ReadLine();

                        if(tip == "A")
                        {
                            vozila.Add(new Automobil(naziv));
                        }
                        else if(tip == "M")
                        {
                            vozila.Add(new Motocikl(naziv));
                        }
                        break;
                    case 2:
                        foreach(Vozilo vozilo in vozila)
                        {
                            Console.WriteLine(vozilo.Ispis());
                        }
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
