using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("U kojoj mjernoj jedinici zelite izracun prosjecne temperature (C/K)?");
                char jedinica = char.Parse(Console.ReadLine());

                MeteoStanica meteoStanica = new MeteoStanica();
                if (jedinica == 'C')
                {
                    Console.WriteLine($"Prosjecna temperatura je: {meteoStanica.DohvatiProsjecnuTemperaturu(Senzor.JedinicaMjere.Celzijus)}"); 
                }
                else
                {
                    Console.WriteLine($"Prosjecna temperatura je: {meteoStanica.DohvatiProsjecnuTemperaturu(Senzor.JedinicaMjere.Kelvin)}");
                }
            }
        }
    }
}
