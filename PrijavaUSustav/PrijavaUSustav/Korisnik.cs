using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaUSustav
{
    internal class Korisnik
    {
        public string KoriscnickoIme { get; set; }
        public string Lozinka { get; set; }

        public Korisnik(string ime, string lozinka)
        {
            this.KoriscnickoIme = ime;
            this.Lozinka = lozinka;
        }
    }
}
