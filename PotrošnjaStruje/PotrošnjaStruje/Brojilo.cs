
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrošnjaStruje
{
    internal class Brojilo
    {
        public string Naziv { get; set; }
        public enum TipBrojila
        {
            Voda, Struja, Plin
        }
        public TipBrojila Tip = new TipBrojila();
        private double stanje;
        private double zadnjeOcitanje;
        public Brojilo(string naziv, TipBrojila tip, double stanje, double zadnjeOcitanje)
        {
            this.Naziv = naziv;
            this.Tip = tip;
            this.zadnjeOcitanje = zadnjeOcitanje;
            this.stanje = stanje;
        }

        public double OcitajPotrosnju()
        {
            return stanje - zadnjeOcitanje;
        }
    }
}
