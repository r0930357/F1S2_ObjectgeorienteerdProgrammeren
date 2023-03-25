using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Zichtrekening : Bankrekening
    {
        /* Zichtrekening
         * -------------------------------------------------
         * +Zichtrekening(rekeningnr: string, saldo: double)
         * +ToonGegevens() : string
         */

        // Bij het aanmaken van een zichtrekening, zal er standaard een minimum voorzien worden van -100.
        public Zichtrekening(string rekeningnr, double saldo) : base(rekeningnr, saldo)
        {
            this.Minimum = -100;
        }

        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" (Minimum {Minimum})";
        }
    }
}