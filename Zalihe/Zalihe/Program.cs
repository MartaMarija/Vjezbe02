using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0, kolicina = 0;

            Skladiste skladiste = new Skladiste();
            Proizvodi proizvod;

            string naziv = "";

            while (izbor != 9)
            {
                Console.WriteLine("1. Dodaj proizvod na skladište\n" +
                    "2. Povećaj količinu proizvoda\n" +
                    "3. Smanji količinu proizvoda\n" +
                    "4. Ispiši stanje skladište i ukupnu vrijednost svih zaliha\n" +
                    "9. Izlaz\n" +
                    "Unesite oodabir: ");
                izbor = int.Parse(Console.ReadLine());

                switch(izbor)
                {
                    case 1:
                        Console.WriteLine("Unesite ime proizvoda:");
                        naziv = Console.ReadLine();
                        Console.WriteLine("Unesite jediničnu cijenu proizvoda:");
                        double jedCijena = double.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite stanje proizvoda:");
                        int stanje = int.Parse(Console.ReadLine());

                        proizvod = new Proizvodi(naziv, jedCijena, stanje);

                        skladiste.DodajProizvod(proizvod);
                        break;
                    case 2:
                        Console.WriteLine("Koji proizvod želite povećati:");
                        naziv = Console.ReadLine();
                        Console.WriteLine("Za koliko:");
                        kolicina = int.Parse(Console.ReadLine());

                        skladiste.DohvatiProizvod(naziv).DodajNaStanje(kolicina);
                        break;
                    case 3:
                        Console.WriteLine("Koji proizvod želite smanjiti:");
                        naziv = Console.ReadLine();
                        Console.WriteLine("Za koliko:");
                        kolicina = int.Parse(Console.ReadLine());

                        skladiste.DohvatiProizvod(naziv).OduzmiSaStanja(kolicina);
                        break;
                    case 4:
                        foreach(Proizvodi p in skladiste.DohvatiSveProizvode())
                        {
                            Console.WriteLine($"Naziv:{p.Naziv}, Jedinična cijena: {p.JedinicnaCijena}, Stanje: {p.Stanje}");
                        }
                        Console.WriteLine($"\nUkupna vrijdnost zaliha:{skladiste.IzracunajUkupnuVrijednostZaliha()}");
                        break;
                }
            }
        }
    }
}
