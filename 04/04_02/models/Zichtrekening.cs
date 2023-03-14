using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Zichtrekening : Rekening
    {
        /* Zichtrekening
         * -------------------------------------------------
         * +Zichtrekening(rekeningnr: string, saldo: double)
         * +ToonGegevens() : string
         */

        public Zichtrekening(string rekeningnr, double saldo) : base(rekeningnr, saldo) { }

        public string ToonGegevens()
        {
            return base.ToonGegevens();
        }
    }
}
