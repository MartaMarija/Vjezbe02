using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica3
{
    internal class Knjiznica
    {
        public List<Knjiga> Knjige;
        public List<Posudba> Posudbe;

        public Knjiznica()
        {
            Posudbe = new List<Posudba>();
            Knjige = new List<Knjiga>();
            Knjige.Add(new Knjiga("1111", "Knjiga 1"));
            Knjige.Add(new Knjiga("2222", "Knjiga 2"));
            Knjige.Add(new Knjiga("3333", "Knjiga 3"));
        }

        public Posudba PosudiKnjigu(string osoba, string isbn)
        {
            Posudba p = new Posudba(osoba, Knjige.Find(x => x.ISBN == isbn));
            Posudbe.Add(p);
            return p;
        }
    }
}
