using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Mjenjacnica
    {
        private Potvrda PromijeniNovac(double iznos, string valuta)
        {
            KonverterValuta konverter = new KonverterValuta();
            double ukupno = konverter.Konvertiraj(iznos, valuta);

            DateTime datum = DateTime.Now;

            Potvrda p = new Potvrda(datum, iznos, iznos/ukupno, ukupno, 0.05*ukupno);
            return p;
        }

        public void IspisPotvrde(double iznos, string valuta)
        {
            Potvrda p = PromijeniNovac(iznos, valuta);
            Console.WriteLine($"Datum: {p.Datum}\nIznos za promjenu: {p.IznosZaPromjenu} HRK\nPo tečaju: {p.Tecaj}\nIznosi: {p.KonvertiraniIznos} {valuta}\nNaknada: 5% ({p.Naknada} {valuta})");
            Console.WriteLine($"\nZa isplatiti: {p.KonvertiraniIznos-p.Naknada}");
        }
    }
}
