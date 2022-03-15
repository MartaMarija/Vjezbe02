using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica3
{
    internal class Posudba
    {
        public string Osoba { get; set; }
        public Knjiga PosudjenaKnjiga { get; set; }
        public DateTime Datum { get; set; }

        public Posudba(string osoba, Knjiga knjiga)
        {
            this.Osoba = osoba;
            this.PosudjenaKnjiga = knjiga;
            this.Datum = DateTime.Now;
        }
    }
}
