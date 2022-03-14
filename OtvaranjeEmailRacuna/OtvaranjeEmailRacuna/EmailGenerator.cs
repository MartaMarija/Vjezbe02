using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvaranjeEmailRacuna
{
    internal class EmailGenerator
    {
        public string GenerirajEmail(string ime, string prezime)
        {
            return $"{ime.ToLower()}.{prezime.ToLower()}@foi.hr";
        }
        public string GenerirajSkraceniEmail(string ime, string prezime)
        {
            return $"{ime.ToLower().Substring(0,1)}.{prezime.ToLower().Substring(0,5)}@foi.hr";
        }
        
    }
}
