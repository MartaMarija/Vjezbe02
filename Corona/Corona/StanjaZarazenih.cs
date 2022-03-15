using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona
{
    internal class StanjaZarazenih
    {
        public int BrojZarazenih { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public StanjaZarazenih(int brojZarazenih)
        {
            this.BrojZarazenih = brojZarazenih;
            this.DatumVrijeme = DateTime.Now;
        }

        public void IspisStanja()
        {
            Console.WriteLine($"Na datum {DatumVrijeme} broj zaraženih je bio {BrojZarazenih}.");
        }
    }
}
