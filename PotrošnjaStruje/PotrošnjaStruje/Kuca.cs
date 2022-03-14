using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrošnjaStruje
{
    internal class Kuca
    {
        public List<Brojilo> Brojila;
        public Kuca()
        {
            Brojila = new List<Brojilo>();
            Brojila.Add(new Brojilo("HEP_101", Brojilo.TipBrojila.Struja, 34235, 32150));
            Brojila.Add(new Brojilo("TP_222", Brojilo.TipBrojila.Plin, 11500, 10400));
            Brojila.Add(new Brojilo("VAR_123", Brojilo.TipBrojila.Voda, 16225, 16100));
        }

        private double DohvatiCijenuEnergenta(Brojilo.TipBrojila tipBrojila)
        {
            switch(tipBrojila)
            {
                case Brojilo.TipBrojila.Voda:
                    return 3.5;
                case Brojilo.TipBrojila.Struja:
                    return 0.10;
                case Brojilo.TipBrojila.Plin:
                    return 0.20;
            }
            return 0;
        }

        public double IzracunajIznosZaBrojilo(Brojilo b)
        {
            double cijena = DohvatiCijenuEnergenta(b.Tip);
            return b.OcitajPotrosnju()*cijena;
        }

        public double IzracunajIznosUkupno()
        {
            double ukupno = 0;
            foreach(Brojilo b in Brojila)
            {
                ukupno+=IzracunajIznosZaBrojilo(b);
            }
            return ukupno;
        }
    }
}
