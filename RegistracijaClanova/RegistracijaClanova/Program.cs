using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaClanova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Unesite email korisnika:");
                string mail = Console.ReadLine();
                Console.WriteLine("Unesite željenu lozinku:");
                string lozinka = Console.ReadLine();

                Registrator registrator = new Registrator();
                registrator.RegistrirajClana(mail, lozinka);
            }
        }
    }
}
