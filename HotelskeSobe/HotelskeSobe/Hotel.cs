using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal class Hotel
    {
        private List<Soba> soba;
        public Hotel()
        {
            soba = new List<Soba>();
            soba.Add(new Soba("10A", 3, Soba.StatusSobe.Slobodna));
            soba.Add(new Soba("10B", 1, Soba.StatusSobe.Rezervirana));
            soba.Add(new Soba("11A", 2, Soba.StatusSobe.Slobodna));
            soba.Add(new Soba("11B", 4, Soba.StatusSobe.Slobodna));
            soba.Add(new Soba("12A", 5, Soba.StatusSobe.Slobodna));
            soba.Add(new Soba("12B", 3, Soba.StatusSobe.Rezervirana));
            soba.Add(new Soba("13A", 1, Soba.StatusSobe.Slobodna));
            soba.Add(new Soba("13B", 2, Soba.StatusSobe.Rezervirana));
        }

        public List<Soba> PronadjiSobe(int brojOsoba)
        {
            List<Soba> sobaPom = new List<Soba>();
            foreach(Soba item in soba)
            {
                if(item.Status == Soba.StatusSobe.Slobodna)
                {
                    if(item.Kapacitet >= brojOsoba)
                    {
                        sobaPom.Add(item);
                    }
                }
            }
            return sobaPom;
        }

        public void RezervirajSobu (string oznaka)
        {
            foreach (Soba item in soba)
            {
                if(item.Oznaka == oznaka)
                {
                    if (item.Status == Soba.StatusSobe.Slobodna)
                    {
                        item.Status = Soba.StatusSobe.Rezervirana;
                    }
                }
            }
        }
    }
}
