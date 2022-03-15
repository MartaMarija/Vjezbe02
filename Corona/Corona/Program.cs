using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Drzave> listaDrzava = new List<Drzave>();
            int unos = 0;
            string nazivDrzave, nazivGrada;
            int brojGradova, brojZarazenih;
            while (unos != 4)
            {
                //Console.Clear();
                Console.Write("1. Dodavanje drzave i gradova\n2. Zapis broja zaraženih u gradu \n3. Ispis bodova\n4. Izlaz\nŠto želite:");
                unos = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (unos)
                {
                    case 1:
                        Console.Write("Unesite naziv drzave:");
                        nazivDrzave = Console.ReadLine();
                        Console.Write("Unesite koliko gradova želite dodati:");
                        brojGradova = int.Parse(Console.ReadLine());

                        listaDrzava.Add(new Drzave(nazivDrzave, brojGradova));
                        break;
                    case 2:
                        Console.Write("Unesite naziv drzave:");
                        nazivDrzave = Console.ReadLine();
                        Console.Write("Unesite naziv grada:");
                        nazivGrada = Console.ReadLine();
                        Console.Write("Unesite broj zarazenih:");
                        brojZarazenih = int.Parse(Console.ReadLine());

                        listaDrzava.Find(x=>x.Naziv == nazivDrzave).ListaGradova.Find(x => x.NazivGrada == nazivGrada).listaStanjaZarazenih.Add(new StanjaZarazenih(brojZarazenih));
                        break;
                    case 3:
                        Console.Write("Unesite naziv drzave:");
                        nazivDrzave = Console.ReadLine();
                        Console.Write("Unesite naziv grada:");
                        nazivGrada = Console.ReadLine();

                        foreach(StanjaZarazenih s in listaDrzava.Find(x => x.Naziv == nazivDrzave).ListaGradova.Find(x => x.NazivGrada == nazivGrada).listaStanjaZarazenih)
                        {
                            s.IspisStanja();
                        }

                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
