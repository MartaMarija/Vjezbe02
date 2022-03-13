using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class GlasackaKutija
    {
        private List<Glas> Glasovi = new List<Glas>();

        public GlasackaKutija()
        {
            
        }

        private bool VecGlasao(string oib)
        {
            foreach(Glas g in Glasovi)
            {
                if(g.OIB == oib)
                {
                    return true;
                }
            }
            return false;
        }

        public void Glasaj(string oib, string odabri)
        {
            if(!VecGlasao(oib))
            {
                Glasovi.Add(new Glas(oib, odabri));
            }
        }

        public void DohvatiRezultateGlasanja()
        {
            int[] rezultati = new int[3];
            foreach(Glas g in Glasovi)
            {
                if(g.Odabir == "Z")
                {
                    rezultati[0]++;
                }
                else if(g.Odabir == "P")
                {
                    rezultati[1]++;
                }
                else if(g.Odabir == "S")
                {
                    rezultati[2]++;
                }
            }
            Console.WriteLine($"Rezultati glasanja: ZA = {rezultati[0]}, PROTIV = {rezultati[1]}, SUZDRŽAN = {rezultati[2]}");
        }
    }
}
