using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaUDanu
{
    internal class Reporter
    {
        private double GetMinimalTemperature()
        {
            DataParser parser = new DataParser();
            Senzor senzor = new Senzor();

            double minTemp = (parser.Parse(senzor.GetData())).Min();
            return minTemp;
        }
        private double GetMaximalTemperature()
        {
            DataParser parser = new DataParser();
            Senzor senzor = new Senzor();

            double minTemp = (parser.Parse(senzor.GetData())).Max();
            return minTemp;
        }
        private double GetAverageTemperature()
        {
            DataParser parser = new DataParser();
            Senzor senzor = new Senzor();

            double averageTemp = 0;
            int brojac = 0;

            foreach(double d in parser.Parse(senzor.GetData()))
            {
                averageTemp += d;
                brojac++;
            }
            return averageTemp / brojac;
        }

        public string GenerateReport()
        {
            return $"Average temperature is {GetAverageTemperature()} °C, minimal temperature is {GetMinimalTemperature()} °C, maximal temperature is {GetMaximalTemperature()} °C";
        }


    }
}
