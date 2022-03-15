using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Unesite ISBN knjige koju posudujete:");
                string isbn = Console.ReadLine();

                Knjiznica k = new Knjiznica();

                k.Posudi(isbn);

                Console.ReadLine();
            }
        }
    }
}
