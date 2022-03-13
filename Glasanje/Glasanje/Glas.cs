using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class Glas
    {
        public string OIB { get; set; }
        public string Odabir { get; set; }

        public Glas(string OIB, string Odabir)
        {
            this.OIB = OIB;
            this.Odabir = Odabir;
        }
    }
}
