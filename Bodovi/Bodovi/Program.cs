using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unos = 0;

            List<Studenti> listaStudenata = new List<Studenti>();

            while (unos != 4)
            {
                //Console.Clear();
                Console.Write("1. Dodavanje studenta\n2. Dodavanje vježbe i bodova studentima\n3. Ispis bodova\n4. Izlaz\nŠto želite:");
                unos = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (unos)
                {
                    case 1:
                        Console.WriteLine("Unesite ime i prezime studenta:");
                        string imePrezime = Console.ReadLine();

                        listaStudenata.Add(new Studenti(imePrezime));
                        break;
                    case 2:
                        Console.WriteLine("Unesite naziv vjezbe:");
                        string naziv = Console.ReadLine();
                        
                        foreach(Studenti student in listaStudenata)
                        {
                            Console.WriteLine($"Unesite broj bodova za {student.ImePrezime}:");
                            int brojBodova = int.Parse(Console.ReadLine());

                            student.Vjezba.Add(new Vjezbe(naziv, brojBodova));
                        }
                        break;
                    case 3:
                        foreach (Studenti student in listaStudenata)
                        {
                            Console.WriteLine($"{student.ImePrezime} je ostvario ukupno: {student.UkupniBodovi(student.Vjezba)} bodova");
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
