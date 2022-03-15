using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Potvrda
    {
        public DateTime Datum;
        public double IznosZaPromjenu;
        public double Tecaj;
        public double KonvertiraniIznos;
        public double Naknada;

        public Potvrda(DateTime datum, double iznosZaPromjenu, double tecaj, double konvertiraniIznos, double naknada)
        {
            this.Datum = datum;
            this.IznosZaPromjenu = iznosZaPromjenu;
            this.Tecaj = tecaj;
            this.KonvertiraniIznos = konvertiraniIznos;
            this.Naknada = naknada;
        }
    }


}
