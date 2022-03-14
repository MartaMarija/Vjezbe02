using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaUSustav
{
    internal class Autentifikator
    {
        private List<Korisnik> listaKorisnika;
        public Autentifikator()
        {
            listaKorisnika = new List<Korisnik>();
            listaKorisnika.Add(new Korisnik("mpicic", "123"));
            listaKorisnika.Add(new Korisnik("izuvela", "123"));
            listaKorisnika.Add(new Korisnik("mhranic", "123"));
        }

        private Korisnik DohvatiKorisnika(string korisnickoIme)
        {
            foreach(Korisnik k in listaKorisnika)
            {
                if(k.KoriscnickoIme == korisnickoIme)
                {
                    return k;
                }
            }
            return null;
        }

        public string PrijavioKorisnika(string korisnickoIme, string lozinka)
        {
            if(DohvatiKorisnika(korisnickoIme) != null)
            {
                if(DohvatiKorisnika(korisnickoIme).Lozinka == lozinka)
                {
                    return "Uspješno prijavljen korisnik!";
                }
                else
                {
                    return "Pogresko upisana lozinka!";
                }
            }
            else
            {
                return "Ne postoji korisnik sa navedenim korisničkim imenom!";
            }
        }
    }
}
