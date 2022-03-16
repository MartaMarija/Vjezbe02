using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Proizvodi
    {
        public string Naziv { get; set; }
        public double JedinicnaCijena { get; set; }
        public int Stanje { get; set; }

        public Proizvodi()
        {
                
        }

        public Proizvodi(string naziv, double jedCijena, int stanje)
        {
            this.Naziv = naziv;
            this.JedinicnaCijena = jedCijena;
            this.Stanje = stanje;
        }

        public double IzracunajVrijednostZaliha(string nazivProizvoda)
        {
            return this.JedinicnaCijena*this.Stanje;
        }

        public void DodajNaStanje(int kolicina)
        {
            if(kolicina > 0)
            {
                this.Stanje += kolicina;
            }
            else
            {
                Console.WriteLine("Ne možete dodati 0 ili negativnu količinu proizvoda!");
            }
        }

        public void OduzmiSaStanja(int kolicina)
        {
            if(kolicina > 0 && this.Stanje - kolicina > 0)
            {
                this.Stanje -= kolicina;
            }
            else
            {
                Console.WriteLine("Ne mozete oduzeti 0 ili negativnu količinu ili oduzeti više nego što ima proizvoda");
            }
        }
    }
}
