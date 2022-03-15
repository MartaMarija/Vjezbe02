using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Tecaj
    {
        public string Valuta;
        public double TrenutniTecaj;

        public Tecaj(string valuta, double trenutniTecaj)
        {
            this.Valuta = valuta;
            this.TrenutniTecaj = trenutniTecaj;
        }
    }
}
