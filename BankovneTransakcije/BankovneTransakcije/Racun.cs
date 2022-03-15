﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije
{
    internal class Racun
    {
        public string IBAN { get; set; }
        public double Stanje { get; set; }

        public Racun(string iban, double stanje)
        {
            this.IBAN = iban;
            this.Stanje = stanje;
        }
    }
}
