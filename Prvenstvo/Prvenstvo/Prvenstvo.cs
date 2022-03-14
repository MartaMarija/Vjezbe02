using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Prvenstvo
    {
        public List<Utakmica> UtakmicaList = new List<Utakmica>();
        public List<Reprezentacija> ReprezentacijaList = new List<Reprezentacija>();

        public void DodajReprezentaciju(string oznaka, string naziv)
        {
            ReprezentacijaList.Add(new Reprezentacija(oznaka, naziv));
        }

        public void DodajUtakmicu(string domacin, string gost, int brojZgoditakaDomacina, int brojZgoditakaGosta)
        {
            Reprezentacija dom = new Reprezentacija(domacin, ReprezentacijaList.Find(x => x.oznaka == domacin).nazivReprezentacije);
            Reprezentacija gos = new Reprezentacija(gost, ReprezentacijaList.Find(x => x.oznaka == gost).nazivReprezentacije);
            UtakmicaList.Add(new Utakmica(dom, gos, brojZgoditakaDomacina, brojZgoditakaGosta));
        }

        public void GenerirajTablicuRezultata()
        {
            foreach(Utakmica u in UtakmicaList)
            {
                Console.WriteLine($"{u.domacin.oznaka} {u.brojZgoditakaDomacina}:{u.brojZgoditakaGosta} {u.gost.oznaka}");
            }
        }
        public void GenerirajBodovnuLjestvicu()
        {
            Console.WriteLine("BODOVNA LJESTVICA\n-------------------------------------------");
            Console.WriteLine("REP  OU  POB  NER  IZG  POZ  PRZ  RUZ  BOD\n-------------------------------------------");

            string rep = "";
            foreach (Reprezentacija r in ReprezentacijaList)
            {
                rep = r.oznaka;
                Console.WriteLine($"{rep}  {Odredi_OU(rep)}    {Odredi_POB(rep)}    {Odredi_NER(rep)}    {Odredi_IZG(rep)}    {Odredi_POZ(rep)}    {Odredi_PRZ(rep)}    {Odredi_RUZ(rep)}    {Odredi_BOD(rep)}");
            }

        }
        private int Odredi_OU(string oznaka)
        {
            int broj = 0;

            foreach (Utakmica u in UtakmicaList)
            {
                if (u.domacin.oznaka == oznaka)
                {
                    broj++;
                }
                if (u.gost.oznaka == oznaka)
                {
                    broj++;
                }
            }

            return broj;
        }

        private int Odredi_POB(string oznaka)
        {
            int broj = 0;

            foreach (Utakmica u in UtakmicaList)
            {
                if(u.domacin.oznaka == oznaka)
                {
                    if(u.brojZgoditakaDomacina > u.brojZgoditakaGosta)
                    {
                        broj++;
                    }
                }
                if (u.gost.oznaka == oznaka)
                {
                    if (u.brojZgoditakaGosta > u.brojZgoditakaDomacina)
                    {
                        broj++;
                    }
                }
            }

            return broj;
        }

        private int Odredi_NER(string oznaka)
        {
            int broj = 0;

            foreach (Utakmica u in UtakmicaList)
            {
                if (u.domacin.oznaka == oznaka)
                {
                    if (u.brojZgoditakaDomacina == u.brojZgoditakaGosta)
                    {
                        broj++;
                    }
                }
                if (u.gost.oznaka == oznaka)
                {
                    if (u.brojZgoditakaGosta == u.brojZgoditakaDomacina)
                    {
                        broj++;
                    }
                }
            }

            return broj;
        }

        private int Odredi_IZG(string oznaka)
        {
            int broj = 0;

            foreach (Utakmica u in UtakmicaList)
            {
                if (u.domacin.oznaka == oznaka)
                {
                    if (u.brojZgoditakaDomacina < u.brojZgoditakaGosta)
                    {
                        broj++;
                    }
                }
                if (u.gost.oznaka == oznaka)
                {
                    if (u.brojZgoditakaGosta < u.brojZgoditakaDomacina)
                    {
                        broj++;
                    }
                }
            }

            return broj;
        }

        private int Odredi_POZ(string oznaka)
        {
            int broj = 0;

            foreach (Utakmica u in UtakmicaList)
            {
                if (u.domacin.oznaka == oznaka)
                {
                    broj += u.brojZgoditakaDomacina;
                }
                if (u.gost.oznaka == oznaka)
                {
                    broj += u.brojZgoditakaGosta;
                }
            }

            return broj;
        }
        private int Odredi_PRZ(string oznaka)
        {
            int broj = 0;

            foreach (Utakmica u in UtakmicaList)
            {
                if (u.domacin.oznaka == oznaka)
                {
                    broj += u.brojZgoditakaGosta;
                }
                if (u.gost.oznaka == oznaka)
                {
                    broj += u.brojZgoditakaDomacina;
                }
            }

            return broj;
        }
        private int Odredi_RUZ(string oznaka)
        {
            int broj = 0;

            foreach (Utakmica u in UtakmicaList)
            {
                broj = Odredi_POZ(oznaka) - Odredi_PRZ(oznaka);
            }

            return broj;
        }
        private int Odredi_BOD(string oznaka)
        {
            int broj = 0;

            foreach (Utakmica u in UtakmicaList)
            {
                broj = Odredi_POB(oznaka) * 3 + Odredi_NER(oznaka);
            }

            return broj;
        }
    }
}
