using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Verwarming
    {
        /* Verwarming
         * -------------
         * +Graden : double
         * +AanUit : bool
         * -------------
         * +Verwarming()
         */

        private double _graden;
        private bool _aanuit;

        public double Graden
        {
            get { return _graden; }
            set { _graden = value; }
        }

        public bool AanUit
        {
            get { return _aanuit; }
            set { _aanuit = value; }
        }

        public Verwarming()
        {
            Graden = 0;
            AanUit = false;
        }
    }
}
