using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi
{
    internal class Studenti
    {
        public string ImePrezime { get; set; }
        public int UkupnoBodova { get; set; }

        public List<Vjezbe> Vjezba = new List<Vjezbe>();

        public Studenti(string imePrezime)
        {
            this.ImePrezime = imePrezime;
        }

        public int UkupniBodovi(List<Vjezbe> vjezba)
        {
            int suma = 0;
            foreach (Vjezbe vjezbe in vjezba)
            {
                suma += vjezbe.Bodovi;
            }
            return suma;
        }
    }
}
