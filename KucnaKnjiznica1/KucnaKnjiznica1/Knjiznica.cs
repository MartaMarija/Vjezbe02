using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica1
{
    internal class Knjiznica
    {
        private List<Knjiga> popisKnjiga;

        public Knjiznica()
        {
            popisKnjiga = new List<Knjiga>();
            popisKnjiga.Add(new Knjiga("1111", "Knjiga 1", Knjiga.StatusKnjige.Dostupno));
            popisKnjiga.Add(new Knjiga("2222", "Knjiga 2", Knjiga.StatusKnjige.Dostupno));
            popisKnjiga.Add(new Knjiga("3333", "Knjiga 3", Knjiga.StatusKnjige.NaPosudbi));
        }

        public Knjiga DohvatiKnjigu(string isbn)
        {
            if(popisKnjiga.Find(x=> x.ISBN == isbn) != null)
            {
                return popisKnjiga.Find(x => x.ISBN == isbn);
            }
            return null;
        }

        public void Posudi(string isbn)
        {
            if(DohvatiKnjigu(isbn) != null)
            {
                if(DohvatiKnjigu(isbn).Status == Knjiga.StatusKnjige.Dostupno)
                {
                    DohvatiKnjigu(isbn).Status = Knjiga.StatusKnjige.NaPosudbi;
                    Console.WriteLine("Status: NaPosudbi");
                }
                else
                {
                    Console.WriteLine("Knjiga nije dostupna");
                }
            }
            else
            {
                Console.WriteLine("Knjiga ne postoji");
            }
        }
    }
}
