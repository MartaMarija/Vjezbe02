using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobusnaKarta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite polaziste, odrediste i tip karte:");
            string[] unos = Console.ReadLine().Split(' ');

            AutobusniKolodvor autobusniKolodvor = new AutobusniKolodvor();

            Console.WriteLine(autobusniKolodvor.KupiKartu(unos[0], unos[1], unos[2]));

            Console.ReadLine();
        }
    }
}
