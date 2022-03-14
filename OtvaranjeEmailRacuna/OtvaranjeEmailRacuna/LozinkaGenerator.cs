using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvaranjeEmailRacuna
{
    internal class LozinkaGenerator
    {
        public string GenerirajLozinku(string ime, string prezime)
        {
            return $"{prezime.ToLower()}{prezime.Length+ime.Length}";
        }
    }
}
