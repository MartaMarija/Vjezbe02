using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APLIKACIJA ZA GLASANJE\n_________________________");
            GlasackaKutija glasackaKutija = new GlasackaKutija();

            while (true)
            {
                Console.WriteLine("Unesite OIB:");
                string OIB = Console.ReadLine();
                Console.WriteLine("Unesite odabir [Z] = Za, [P] = Protiv i [S] = Suzdržan:");
                string Odabir = Console.ReadLine();

               
                glasackaKutija.Glasaj(OIB, Odabir);
                glasackaKutija.DohvatiRezultateGlasanja();

                Console.WriteLine("_________________________\n");
            }
        }
    }
}
