using System;
using System.Collections.Generic;
using System.Text;

namespace models
{

    /* KlantNietGevondenException
     * ---------------------------------------------
     * +KlantNietGevondenException(klantnummer: int)
     */

    public class KlantNietGevondenException : Exception
    {
        /* Geeft een tekstuele voorstelling van de Exception als volgt:
         * De klantnummer <Klantnummer> bestaat niet.
         * Gebruik hiervoor constructor chaining!
         */
        public KlantNietGevondenException() { }

        public KlantNietGevondenException(int klantnummer, string message) : base(message) { }
    }
}
