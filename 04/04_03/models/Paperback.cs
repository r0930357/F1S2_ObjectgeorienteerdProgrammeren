using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Paperback : Boek
    {
        // attributen
        private double _bladzijden;
        private double _blzPerDag;

        // properties
        public double Bladzijden
        {
            get { return _bladzijden; }
            set { _bladzijden = value; }
        }
        public double BlzPerDag
        {
            get { return _blzPerDag; }
            set { _blzPerDag = value; }
        }

        // constructor
        public Paperback(string titel, string auteur, int bladzijden, int blzPerDag) : base(titel, auteur)
        {
            this.Bladzijden = bladzijden;
            this.BlzPerDag = blzPerDag;
        }

        // methoden
        public override string ToonGegevens()
        {
            return $"{base.ToonGegevens()} zou {Math.Ceiling(Bladzijden / BlzPerDag)} dagen duren om uit te lezen.";
        }
    }
}