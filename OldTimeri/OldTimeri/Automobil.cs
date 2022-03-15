using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeri
{
    internal class Automobil : Vozilo
    {
        public Automobil(string naziv)
        {
            this.naziv = naziv;
        }

        public override string Ispis()
        {
            return $"Automobil: {naziv}";
        }
    }
}
