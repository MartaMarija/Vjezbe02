using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaClanova
{
    internal class Clan
    {
        public string EmailAdresa { get; set; }
        public string Lozinka { get; set; }

        public Clan(string email, string lozinka)
        {
            this.EmailAdresa = email;
            this.Lozinka = lozinka;
        }
    }
}
