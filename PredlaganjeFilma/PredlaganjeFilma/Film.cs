using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredlaganjeFilma
{
    internal class Film
    {
        public string Naziv { get; set; }
        public enum TipZanra
        {
            Komedija, Akcija, Horor
        }
        public int Trajanje { get; set; }
        public bool VecGledan { get; set; }

        public TipZanra Zanr = new TipZanra();
        public Film()
        {

        }

        public Film(string naziv, TipZanra zanr, int trajanje, bool vecGledan)
        {
            this.Naziv = naziv;
            this.Zanr = zanr;
            this.Trajanje = trajanje;
            this.VecGledan = vecGledan;
        }

        public string DohvatiInfo()
        {
            StreamingServis s = new StreamingServis();
            Film f = s.PredloziFilm();
            return $"{f.Naziv} ({f.Zanr}, {f.Trajanje} min)";
        }
    }
}
