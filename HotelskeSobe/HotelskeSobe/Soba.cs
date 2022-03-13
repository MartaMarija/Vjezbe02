using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal class Soba
    {
        public string Oznaka { get; set; }
        public int Kapacitet { get; set; }

        public enum StatusSobe
        {
            Rezervirana,
            Slobodna
        }

        public StatusSobe Status = new StatusSobe();

        public Soba(string Oznaka, int Kapacitet, StatusSobe Status)
        {
            this.Oznaka = Oznaka;
            this.Kapacitet = Kapacitet;
            this.Status = Status;
        }
    }
}
