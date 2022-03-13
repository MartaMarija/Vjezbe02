using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaClanova
{
    internal class Registrator
    {
        List<Clan> listaClanova;

        public Registrator()
        {
            listaClanova = new List<Clan>();
            listaClanova.Add(new Clan("mpicic@foi.hr", "aabbccddee"));
            listaClanova.Add(new Clan("izuvela@foi.hr", "aabbccddee"));
            listaClanova.Add(new Clan("mhranic@foi.hr", "aabbccddee"));
        }

        private bool EmailZauzet(string emailAdresa)
        {
            foreach (Clan clan in listaClanova)
            {
                if (clan.EmailAdresa.Contains(emailAdresa))
                {
                    return false;
                }
            }

            return true;
        }

        public void RegistrirajClana(string email, string lozinka)
        {
            Validator validator = new Validator();
            if (!validator.ValidirajEmail(email))
            {
                Console.WriteLine("Email adresa je neispravnog oblika!");
            }
            else if (!validator.ValidirajLozinku(lozinka))
            {
                Console.WriteLine("Lozinka mora imati između 6 i 10 znakova!");
            }
            else if (!EmailZauzet(email))
            {
                Console.WriteLine("Već postoji član sa navedenim emailom!");
            }
            else
            {
                listaClanova.Add(new Clan(email, lozinka));
                foreach (Clan clan in listaClanova)
                {
                    Console.WriteLine($"Email: {clan.EmailAdresa}");
                }
            }
        }
    }
}
