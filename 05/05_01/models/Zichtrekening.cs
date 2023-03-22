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
         * +ToString() : string
        */

        public Zichtrekening(string rekeningnummer, double saldo) : base(rekeningnummer, saldo) { }

        public string ToonGegevens()
        {

        }

        /* Methode ToString()
         * Geeft de tekstuele voorstelling van het object als volgt:
         * <IbanNummer> -> Je hudig saldo bedraagt: <Saldo> euro.
         * Het minimumbedrag bedraagt: <Minimum> euro.
         */

        public override string ToString()
        {
            return base.ToString() + $"\nHet minimumbedrag bedraagt: {base.Minimum} euro.";
        }

    }
}
