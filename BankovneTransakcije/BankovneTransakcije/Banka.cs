using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije
{
    internal class Banka
    {
        private List<Racun> Racuni = new List<Racun>();

        public Banka()
        {
            Racuni.Add(new Racun("HR11", 100000));
            Racuni.Add(new Racun("HR22", 50000));
            Racuni.Add(new Racun("HR33", 12000));
            Racuni.Add(new Racun("HR44", 36000));
        }

        private Racun DohvatiRacun(string iban)
        {
            foreach(Racun item in Racuni)
            {
                if(iban == item.IBAN)
                {
                    return item;
                }
            }

            return null;
        }

        public Transakcija IzvrsiPlacanje(string ibanPlatitelja, string ibanPrimatelja,double iznos)
        {double novoStanjePrimatelj = DohvatiRacun(ibanPrimatelja).Stanje + iznos;
            double novoStanjePlatitelja = DohvatiRacun(ibanPlatitelja).Stanje - iznos;

            Racuni.Find(x => x.IBAN == ibanPrimatelja).Stanje = novoStanjePrimatelj;
            Racuni.Find(x => x.IBAN == ibanPlatitelja).Stanje = novoStanjePlatitelja;

            Transakcija t = new Transakcija(Racuni.Find(x => x.IBAN == ibanPrimatelja), Racuni.Find(x => x.IBAN == ibanPlatitelja), iznos);

            return t;
        }
    }
}
