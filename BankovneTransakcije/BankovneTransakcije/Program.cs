using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ibanPlatitelja, ibanPrimatelja;
            double iznos = 0;

            Console.WriteLine("Unesite IBAN platitelja");
            ibanPlatitelja = Console.ReadLine();
            Console.WriteLine("Unesite IBAN primatelja");
            ibanPrimatelja = Console.ReadLine();
            Console.WriteLine("Unesite iznos");
            iznos = double.Parse(Console.ReadLine());

            Transakcija t = new Transakcija();
            Banka b = new Banka();
            t = b.IzvrsiPlacanje(ibanPlatitelja, ibanPrimatelja, iznos);

            Console.WriteLine($"Novo stanje računa {t.Platitelj.IBAN} je {t.Platitelj.Stanje}");
            Console.WriteLine($"Novo stanje računa {t.Primatelj.IBAN} je {t.Primatelj.Stanje}");

            Console.ReadLine();
        }
    }
}
