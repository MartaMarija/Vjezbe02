using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi
{
    internal class Vjezbe
    {
        public string NazivVjezbe { get; set; }
        public int Bodovi { get; set; }

        public Vjezbe(string nazivVjezbe, int bodovi)
        {
            this.NazivVjezbe = nazivVjezbe;
            this.Bodovi = bodovi;
        }
    }
}
