using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvaranjeEmailRacuna
{
    internal class KorisnickiRacun
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string SkraceniEmail { get; set; }
        public string Lozinka { get; set; }

        public KorisnickiRacun(string ime, string prezime, string email, string semail, string lozinka)
        {
            this.Prezime = prezime;
            this.Ime = ime;
            this.Email = email;
            this.SkraceniEmail = semail;
            this.Lozinka = lozinka;
        }
        
    }
}
