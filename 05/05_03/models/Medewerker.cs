using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Medewerker
    {
        // attributen
        private string _voornaam;
        private string _familienaam;
        private int _uurloon;

        // properties
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }
        public int Uurloon
        {
            get { return _uurloon; }
            set { _uurloon = value; }
        }

        // constructor
        public Medewerker(string voornaam, string familienaam, int uurloon)
        {
            this.Voornaam = voornaam;
            this.Familienaam = familienaam;
            this.Uurloon = uurloon;
        }

        // methoden
        public virtual string ToonGegevens()
        {
            return $"{Voornaam} {Familienaam} verdient {Uurloon * 160} euro per maand.";
        }
    }
}
