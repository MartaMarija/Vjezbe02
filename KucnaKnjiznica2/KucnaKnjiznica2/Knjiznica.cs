using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica2
{
    internal class Knjiznica
    {
        List<Knjiga> knjigaList;

        public Knjiznica()
        {
            knjigaList = new List<Knjiga>();
            knjigaList.Add(new Knjiga(naslov: "Lijepa knjiga"));
            knjigaList.Add(new Knjiga(naslov: "Zelena knjiga"));
            knjigaList.Add(new Knjiga(naslov: "Stara knjiga"));
        }

        public void Posudi(string naslov, string osoba)
        {
            foreach(Knjiga knjiga in knjigaList)
            {
                if(knjiga.Naslov == naslov)
                {
                    if(knjiga.Dostupno)
                    {
                        knjiga.Dostupno = false;
                        knjiga.Osoba = osoba;
                        Console.WriteLine(knjiga.DohvatiOpis()); 
                    }
                    else
                    {
                        Console.WriteLine(knjiga.DohvatiOpis());
                    }
                }
                else
                {
                    Console.WriteLine(knjiga.DohvatiOpis());
                }
            }
        }
    }
}
