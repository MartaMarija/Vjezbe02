using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaUDanu
{
    internal class DataParser
    {
        public double[] Parse(string senzorData)
        {
            string[] podaciString = senzorData.Split(';');
            double[] podaciDouble = new double[podaciString.Length];

            for (int i = 0; i < podaciString.Length; i++)
            {
                podaciDouble[i] = double.Parse(podaciString[i]);
            }
            
            return podaciDouble;
        }
    }
}
