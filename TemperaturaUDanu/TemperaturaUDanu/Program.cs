using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaUDanu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEMPERATURE REPORT\n--------------------------");

            Reporter reporter = new Reporter();
            Console.WriteLine(reporter.GenerateReport()); 
            Console.ReadLine();
        }
    }
}
