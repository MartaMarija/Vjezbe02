using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class TecajnaLista
    {
        public List<Tecaj> ListaTecajeva;
        public TecajnaLista()
        {
            ListaTecajeva = new List<Tecaj>();
            ListaTecajeva.Add(new Tecaj("EUR", 7.5));
            ListaTecajeva.Add(new Tecaj("CAD", 5.4));
            ListaTecajeva.Add(new Tecaj("USD", 6.9));
        }
    }
}
