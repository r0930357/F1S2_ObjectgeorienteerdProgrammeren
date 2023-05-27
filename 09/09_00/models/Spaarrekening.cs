using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace models
{
    public class Spaarrekening : Bankrekening
    {
        /* Spaarrekening
         * -------------------------
         * +Percentage : double
         * -------------------------
         * +Spaarrekening()
         * +ToonGegevens() : string
         * +SchrijfRentebij() : void
         */

        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        // Het percentage krijgt een standaardwaarde van 15%.
        public Spaarrekening(string rekeningnr, double saldo) : base(rekeningnr, saldo)
        {
            this.Percentage = 15;
        }

        public Spaarrekening() : base("", 0)
        {
            this.Percentage = 15;
        }

        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" (percentage {this.Percentage})";
        }

        public void SchrijfRentebij()
        {
            Saldo = (1 + (Percentage / 100)) * Saldo;
        }

        //Geeft de tekstuele voorstelling van het object als volgt:
        //<IbanNummer> -> Je huidig saldo bedraagt: <Saldo> euro.
        //De rentevoet bedraagt: <Percentage>%
        public override string ToString()
        {
            return base.ToString() + $" De rentevoet bedraagt: {Percentage}%";
        }
    }
}
