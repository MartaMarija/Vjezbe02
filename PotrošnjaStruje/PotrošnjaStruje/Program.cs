using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrošnjaStruje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cijena potrosene energije za proteklo razdoblje:\n------------------------------------------");

            Kuca kuca = new Kuca();

            foreach(Brojilo b in kuca.Brojila)
            {
                Console.WriteLine($"Brojilo {b.Naziv} ({b.Tip}) = {kuca.IzracunajIznosZaBrojilo(b)} kn");
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"UKUPNO: {kuca.IzracunajIznosUkupno()} kn");
            Console.ReadLine();
        }
    }
}
