using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobusnaKarta
{
    internal class AutobusniKolodvor
    {
        private List<Linija> listaLinija;
        public AutobusniKolodvor()
        {
            listaLinija = new List<Linija>();
            listaLinija.Add(new Linija("Varaždin", "Zagreb", 80));
            listaLinija.Add(new Linija("Varazdin", "Cakovec", 20));
            listaLinija.Add(new Linija("Varaždin", "Slavonski Brod", 240));
            listaLinija.Add(new Linija("Varaždin", "Krapina", 40));
            listaLinija.Add(new Linija("Varaždin", "Novi Marof", 22));
            listaLinija.Add(new Linija("Varaždin", "Koprivnica", 45));
            listaLinija.Add(new Linija("Varaždin", "Virovitica", 100));
            listaLinija.Add(new Linija("Varaždin", "Osijek", 220));
        }

        private double IzracunajCijenu(int udaljenost, string tipKarte)
        {
            switch (tipKarte)
            {
                case "povratna":
                    return udaljenost * 2;
                case "regularna":
                    return udaljenost * 1.5;
                case "studentska":
                    return udaljenost * 2;
            }

            return 0;
        }

        public string KupiKartu(string polaziste, string odrediste, string tipKarte)
        {
            double cijena = IzracunajCijenu(listaLinija.Find(x => x.Odrediste == odrediste).Udaljenost, tipKarte);
            return $"Cijena za kartu tipa {tipKarte}, na relaciji {polaziste}-{odrediste} iznosi {cijena}";
        }
    }
}
