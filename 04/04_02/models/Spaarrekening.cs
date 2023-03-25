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

        // Bij het aanmaken van een spaarrekening, zal standaard een percentage voorzien worden van 5%.
        public Spaarrekening() : base("", 0)
        {
            this.Percentage = 5;
        }

        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" (percentage {this.Percentage})";
        }

        public void SchrijfRentebij()
        {
            Saldo = (1 + (Percentage/100)) * Saldo;
        }
    }
}
