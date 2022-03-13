using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Unesite naslov knjige koju posudujete:");
                string knjiga = Console.ReadLine();

                Console.WriteLine("Unesite ime osobe kojoj posudujete knjigu:");
                string ime = Console.ReadLine();

                Knjiznica knjiznica = new Knjiznica();
                knjiznica.Posudi(knjiga, ime);

                
                Console.WriteLine();
                
            }
        }
    }
}
