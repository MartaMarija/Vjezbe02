using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije
{
    internal class Transakcija
    {
        public Racun Platitelj { get; set; }
        public Racun Primatelj { get; set; }
        public double Iznos { get; set; }

        public Transakcija(Racun primatelj, Racun platitelj, double iznos)
        {
            this.Platitelj = platitelj;
            this.Primatelj = primatelj;
            this.Iznos = iznos;
        }
    }
}
