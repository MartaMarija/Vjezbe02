using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori
{
    internal class MeteoStanica
    {
        private List<Senzor> senzor;

        public MeteoStanica()
        {
            senzor = new List<Senzor>();
            senzor.Add(new Senzor("Senzor 1", 8.4, Senzor.JedinicaMjere.Celzijus));
            senzor.Add(new Senzor("Senzor 2", 281.5, Senzor.JedinicaMjere.Kelvin));
            senzor.Add(new Senzor("Senzor 3", 8.9, Senzor.JedinicaMjere.Celzijus));
            senzor.Add(new Senzor("Senzor 4", 9.1, Senzor.JedinicaMjere.Celzijus));
        }

        private double Pretvori(Senzor.JedinicaMjere izJedinice, Senzor.JedinicaMjere uJedinicu, double vrijednost)
        {
            if(izJedinice == uJedinicu)
            {
                return vrijednost;
            }
            else if(uJedinicu == Senzor.JedinicaMjere.Celzijus)
            {
                return vrijednost - 273.15;
            }
            else
            {
                return vrijednost + 273.15;
            }
        }
        public double DohvatiProsjecnuTemperaturu(Senzor.JedinicaMjere jedinica)
        {
            double prosjecnaTemp = 0.0;
            foreach(Senzor item in senzor)
            {
                prosjecnaTemp += Pretvori(item.Jedinica, jedinica, item.Vrijednost);
            }
            
            return prosjecnaTemp/4;
        }
    }
}
