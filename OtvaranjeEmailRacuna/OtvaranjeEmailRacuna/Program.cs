using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvaranjeEmailRacuna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otvaranje email korisničkog računa:\n---------------------------");
            Console.WriteLine("Unesite vaše ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite vaše prezime:");
            string prezime = Console.ReadLine();

            EmailServer emailServer = new EmailServer();
            KorisnickiRacun korisnickiRacun = emailServer.KreirajKorisnickiRacun(ime, prezime);

            Console.WriteLine("---------------------------");

            Console.WriteLine("Podaci za vaš emial korisnički račun su sljedeći:");
            Console.WriteLine($"Ime: {korisnickiRacun.Ime}\nPrezime: {korisnickiRacun.Prezime}\nEmail: {korisnickiRacun.Email}\nEmail: {korisnickiRacun.SkraceniEmail}\nLozinka: {korisnickiRacun.Lozinka}");

            Console.ReadLine();
        }
    }
}
