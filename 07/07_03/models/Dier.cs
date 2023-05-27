using System;
using System.Collections.Generic;
//using System.Data;
//using System.Text;

namespace models
{
    public class Dier
    {

        /* Dier
         * ----------------------------------------------------------
         * +Naam : string
         * +Diersoort : string
         * +LaatstGevoerd : DateTime
         * +IsGevaarlijk : bool
         * ----------------------------------------------------------
         * +Dier(naam: string, diersoort: string, isGevaarlijk: bool)
         * +ToString() : string
         * +Equals(obj: object) : bool
         * +GetHashCode() : int
         * +Eten(moment: DateTime) : void
         */

        private string _naam;
        private string _diersoort;
        private DateTime _laatstGevoerd;
        private bool _isGevaarlijk;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Diersoort
        {
            get { return _diersoort; }
            set { _diersoort = value; }
        }

        public DateTime LaatstGevoerd
        {
            get { return _laatstGevoerd; }
            set { _laatstGevoerd = value; }
        }

        public bool IsGevaarlijk
        {
            get { return _isGevaarlijk; }
            set { _isGevaarlijk = value; }
        }

        public Dier(string naam, string diersoort, bool isGevaarlijk)
        {
            Naam = naam;
            Diersoort = diersoort;
            IsGevaarlijk = isGevaarlijk;
        }

        /* Methode ToString
         * Deze methode geeft een tekstuele weergave van het object als volgt: <Naam> (<Diersoort>).
         * Bijvoorbeeld: Dumbo (Olifant)
         */
        public override string ToString()
        {
            return $"{Naam} ({Diersoort})";
        }

        /* Methode Equals en GetHashCode
         * Deze methodes controleren of twee objecten hetzelfde zijn.
         * Twee objecten zijn hetzelfde als ze dezelfde naam en diersoort hebben.
         */
        public override bool Equals(object obj)
        {
            if (obj is Dier dier)
            {
                return this.Naam == dier.Naam &&
                    this.Diersoort == dier.Diersoort;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Naam, Diersoort);
        }

        /* Methode Eten
         * Deze methode zorgt er voor dat het dier gevoerd wordt.
         * De LaatstGevoerd waarde wordt aangepast naar het moment van voeren.
         */
        public void Eten(DateTime moment)
        {
            LaatstGevoerd = moment;
        }
    }
}