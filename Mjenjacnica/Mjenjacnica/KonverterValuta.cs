using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class KonverterValuta
    {
        public double Konvertiraj(double novac, string valuta)
        {
            TecajnaLista tecajnaLista = new TecajnaLista();
            double trenutniTecaj = tecajnaLista.ListaTecajeva.Find(x=> x.Valuta == valuta).TrenutniTecaj;
            return novac / trenutniTecaj;
        }
    }
}
