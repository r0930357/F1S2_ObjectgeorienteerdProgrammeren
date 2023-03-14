using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace models
{
    public class Spaarrekening : Rekening
    {
        /* Spaarrekening
         * -------------------------
         * +Percentage : double
         * -------------------------
         * +Spaarrekening()
         * +ToonGegevens() : string
         * +SchrijfRentebij() : void
         */

        public double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public Spaarrekening() : base()
        {
            SchrijfRentebij();
        }

        public override string ToonGegevens()
        {
            return base.ToonGegevens();
        }

        public void SchrijfRentebij()
        {

        }
    }
}
