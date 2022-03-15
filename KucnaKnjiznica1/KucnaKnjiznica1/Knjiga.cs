using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica1
{
    internal class Knjiga
    {
        public string ISBN { get; set; }
        public string Naslov { get; set; }
        public enum StatusKnjige 
        {
            Dostupno, NaPosudbi
        }

        public StatusKnjige Status = new StatusKnjige();

        public Knjiga(string ISBN, string Naslov, StatusKnjige status)
        {
            this.Status = status;
            this.ISBN = ISBN;
            this.Naslov = Naslov;
            
        }
    }
}
