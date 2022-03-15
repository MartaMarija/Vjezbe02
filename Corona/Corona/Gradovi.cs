using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona
{
    internal class Gradovi
    {
        public string NazivGrada { get; set; }
        public List<StanjaZarazenih> listaStanjaZarazenih = new List<StanjaZarazenih>();
        public Gradovi(string nazivGrada)
        {
            this.NazivGrada = nazivGrada;
        }
    }
}
