using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Utakmica
    {
        public Reprezentacija domacin;
        public Reprezentacija gost;
        public int brojZgoditakaDomacina, brojZgoditakaGosta;

        public Utakmica(Reprezentacija domacin, Reprezentacija gost, int brojDom, int brojGos)
        {
            this.domacin = domacin;
            this.gost = gost;
            this.brojZgoditakaGosta = brojGos;
            this.brojZgoditakaDomacina = brojDom;
        }
    }
}
