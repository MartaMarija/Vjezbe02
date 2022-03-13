using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaClanova
{
    internal class Validator
    {
        public bool ValidirajEmail(string emailAdresa)
        {
            if (!emailAdresa.Contains('@') || !emailAdresa.Contains("foi.hr"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidirajLozinku(string lozinka)
        {
            if (lozinka.Length < 6 || lozinka.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
