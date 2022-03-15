using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica3
{
    internal class Knjiga
    {
        public string ISBN { get; set; }
        public string Naslov { get; set; }
        public Knjiga(string isbn, string naslov)
        {
            this.Naslov = naslov;
            this.ISBN = isbn;
        }
    }
}
