using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredlaganjeFilma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            while(izbor != "ne")
            {
                Console.WriteLine("Zelite li prijedlog filma (da/ne)?:");
                izbor = Console.ReadLine();
                Film f = new Film();
                Console.WriteLine(f.DohvatiInfo());
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
