using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    /* OngeldigBtwNummerException
     * -----------------------------
     * +OngeldigBtwNummerException()
     */
    public class OngeldigBtwNummerException : Exception
    {
        /* Geeft een tekstuele voorstelling van de Exception als volgt:
         * Het BTW-nummer moet beginnen met BE.
         * Gebruik hiervoor constructor chaining!
         */

        public OngeldigBtwNummerException() { }

        public OngeldigBtwNummerException(string message) : base(message) { }
    }
}
