using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Licht
    {
        /* Licht
         * --------------
         * +AanUit : bool
        */

        private bool _aanuit;

        public bool AanUit
        {
            get { return _aanuit; }
            set { _aanuit = value; }
        }

        public Licht()
        {
            AanUit = false;
        }
    }
}
