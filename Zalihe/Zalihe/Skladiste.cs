using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Skladiste
    {
        private List<Proizvodi> listaProizvoda = new List<Proizvodi>();
        public Skladiste()
        {

        }

        public void DodajProizvod(Proizvodi proizvod)
        {
            if(listaProizvoda.Count == 0)
            {
                listaProizvoda.Add(proizvod);
            }
            else if(listaProizvoda.Find(x => x.Naziv == proizvod.Naziv) == null)
            {
                listaProizvoda.Add(proizvod);
            }
            else
            {
                Console.WriteLine("Proizvod s tim nazivom vec postoji!");
            }
        }

        public void UkloniProizvod(Proizvodi proizvod)
        {
            listaProizvoda.Remove(proizvod);
        }

        public Proizvodi DohvatiProizvod(string nazivProizvoda)
        {
            return listaProizvoda.Find(x => x.Naziv == nazivProizvoda);
        }

        public List<Proizvodi> DohvatiSveProizvode()
        {
            return listaProizvoda;
        }

        public double IzracunajUkupnuVrijednostZaliha()
        {
            double ukupno = 0;
            foreach(Proizvodi proizvod in listaProizvoda)
            {
                ukupno += proizvod.Stanje * proizvod.JedinicnaCijena;
            }
            return ukupno;
        }
    }
}
