using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona
{
    internal class Drzave
    {
        public string Naziv { get; set; }
        public List<Gradovi> ListaGradova = new List<Gradovi>();

        public Drzave()
        {

        }

        public Drzave(string naziv, int brojGradova)
        {
            this.Naziv = naziv;
            this.DodajGradove(brojGradova);
        }

        private void DodajGradove(int brojGradova)
        {
            Console.WriteLine($"Unesite {brojGradova} gradova:");
            for (int i = 1; i <= brojGradova; i++)
            {
                Console.Write(i + ". ");
                ListaGradova.Add(new Gradovi(Console.ReadLine()));
            }
        }
    }
}
