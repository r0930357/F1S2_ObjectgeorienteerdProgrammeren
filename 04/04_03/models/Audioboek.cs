using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Audioboek : Boek
    {
        // attributen
        private string _verteller;
        private double _speelminuten;
        private double _minutenPerDag;

        // properties
        public string Verteller
        {
            get { return _verteller; }
            set { _verteller = value; }
        }
        public double Speelminuten
        {
            get { return _speelminuten; }
            set { _speelminuten = value; }
        }
        public double MinutenPerDag
        {
            get { return _minutenPerDag; }
            set { _minutenPerDag = value; }
        }

        // constructor
        public Audioboek(string titel, string auteur, string verteller, int speelminuten, int minutenPerDag) : base(titel, auteur)
        {
            this.Verteller = verteller;
            this.Speelminuten = speelminuten;
            this.MinutenPerDag = minutenPerDag;
        }

        // methoden
        public override string ToonGegevens()
        {
            return $"{base.ToonGegevens()}, verteld door {Verteller} zou {Math.Ceiling(Speelminuten / MinutenPerDag)} dagen duren om uit te lezen.";
        }
    }
}
