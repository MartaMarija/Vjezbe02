using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvaranjeEmailRacuna
{
    internal class EmailServer
    {
        public KorisnickiRacun KreirajKorisnickiRacun(string ime, string prezime)
        {
            EmailGenerator emailGenerator = new EmailGenerator();
            LozinkaGenerator lozinkaGenerator = new LozinkaGenerator();

            string skraceniMail = emailGenerator.GenerirajSkraceniEmail(ime, prezime);
            string mail = emailGenerator.GenerirajEmail(ime, prezime);
            string lozinka = lozinkaGenerator.GenerirajLozinku(ime, prezime);
            KorisnickiRacun korisnickiRacun = new KorisnickiRacun(ime, prezime, mail, skraceniMail, lozinka);
            return korisnickiRacun;
        }
    }
}
