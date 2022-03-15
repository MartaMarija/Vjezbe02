using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime prezime osobe kojoj posudujemo knjigu:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite ISBN knjige:");
            string isbn = Console.ReadLine();
                               
            Console.WriteLine("---------------------------------------\n-------------- POSUDBA ----------------\n---------------------------------------");
        
            Knjiznica k = new Knjiznica();

            Console.WriteLine($"Osoba: {k.PosudiKnjigu(ime, isbn).Osoba}\n" +
                $"ISBN knjige: {k.PosudiKnjigu(ime, isbn).PosudjenaKnjiga.ISBN}\n" +
                $"Naslov knjige: {k.PosudiKnjigu(ime, isbn).PosudjenaKnjiga.Naslov}\n" +
                $"Datum posudbe: {k.PosudiKnjigu(ime, isbn).Datum}");            

            Console.ReadLine();
        }
    }
}
