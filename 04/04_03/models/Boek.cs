using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Boek
    {
        // attributen
        private string _titel;
        private string _auteur;

        // properties
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        // constructor
        public Boek(string titel, string auteur)
        {
            this.Auteur = auteur;
            this.Titel = titel;
        }

        // methoden
        public virtual string ToonGegevens()
        {
            return $"Het Boek {Titel} van {Auteur}";
        }
    }
}