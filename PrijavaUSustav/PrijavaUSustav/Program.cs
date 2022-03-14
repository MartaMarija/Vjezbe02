using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaUSustav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korisnicko ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Lozinka:");
            string lozinka = Console.ReadLine();

            Autentifikator autentifikator = new Autentifikator();

            Console.WriteLine(autentifikator.PrijavioKorisnika(ime, lozinka));

            Console.ReadLine();
        }
    }
}
