using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori
{
    internal class Senzor
    {
        public string Oznaka { get; set; }
        public double Vrijednost { get; set; }
        public enum JedinicaMjere
        {
            Celzijus, Kelvin
        }

        public JedinicaMjere Jedinica = new JedinicaMjere();

        public Senzor(string Oznaka, double Vrijednost, JedinicaMjere Jedinica)
        {
            this.Oznaka = Oznaka;
            this.Vrijednost = Vrijednost;
            this.Jedinica = Jedinica;
        }
    }
}
