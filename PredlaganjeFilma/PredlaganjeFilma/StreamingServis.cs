using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredlaganjeFilma
{
    internal class StreamingServis
    {
        public List<Film> Filmovi;

        public StreamingServis()
        {
            Filmovi = new List<Film>();
            Filmovi.Add(new Film("Film 1", Film.TipZanra.Komedija, 88, false));
            Filmovi.Add(new Film("Film 2", Film.TipZanra.Akcija, 95, false));
            Filmovi.Add(new Film("Film 3", Film.TipZanra.Horor, 70, true));
            Filmovi.Add(new Film("Film 4", Film.TipZanra.Komedija, 120, false));
            Filmovi.Add(new Film("Film 5", Film.TipZanra.Akcija, 110, true));
            Filmovi.Add(new Film("Film 6", Film.TipZanra.Horor, 99, false));
            Filmovi.Add(new Film("Film 7", Film.TipZanra.Komedija, 75, false));
            Filmovi.Add(new Film("Film 8", Film.TipZanra.Akcija, 80, false));
            Filmovi.Add(new Film("Film 9", Film.TipZanra.Horor, 81, false));
            Filmovi.Add(new Film("Film 10", Film.TipZanra.Komedija, 99, true));
        }

        private List<Film> DohvatiFilmoveKojeNisamGledao()
        {
            return Filmovi.FindAll(x => x.VecGledan == false);
        }

        public Film PredloziFilm()
        {
            List<Film> pom = DohvatiFilmoveKojeNisamGledao();
            Random r = new Random();
            int rInt = r.Next(0, pom.Count);

            return pom.ElementAt(rInt);
        }
    }
}
