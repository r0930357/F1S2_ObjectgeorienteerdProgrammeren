using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace models
{
    public class TvKanaal
    {
        /* TvKanaal
         * --------------------------------------------
         * +Nummer : int
         * +Omschrijving : string
         * --------------------------------------------
         * +TvKanaal()
         * +TvKanaal(nummer: int, omschrijving: string)
         * +ToString() : string
         */

        private int _nummer;
        private string _omschrijving;

        // Deze property bevat de omschrijving of naam van het kanaal.
        public int Nummer
        {
            get { return _nummer; }
            set { _nummer = value; }
        }

        // Deze property bevat de omschrijving of naam van het kanaal.
        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public TvKanaal(int nummer, string omschrijving)
        {
            Nummer = nummer;
            Omschrijving = omschrijving;
        }

        public TvKanaal() : this(0, "") { }

        // Deze methode geef een string terug met daarin "Nummer van het kanaal is <Nummer>"
        public override string ToString()
        {
            return $"Nummer van het kanaal is {Nummer}";
        }
    }
}
