using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Boek
    {

        /* Boek
         * -----------------------
         * +Titel: string
         * +Auteur: string
         * +Paginas: int
         * -----------------------
         * +Boek()
         * +BoekParameters(): void
         * +ToonBoek(): string
         * -----------------------
         */

        // Declaratie van de attributen "_titel", "_auteur" en "_paginas".
        private string _titel;
        private string _auteur;
        private int _paginas;

        // Declaratie van de properties "Titel", "Auteur" en "Paginas".
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
        public int Paginas
        {
            get { return _paginas; }
            set { _paginas = value; }
        }

        // Constructor Boek() aanmakan met de parameters "Titel", "Auteur" en "Paginas".
        public Boek()
        {
            Titel = string.Empty;
            Auteur = string.Empty;
            Paginas = 0;
        }

        // Methodes aanmaken
        // Methode BoekParameters: Voeg eigenschappen "Titel", "Auteur" en "Paginas" toe.
        public void BoekParameters()
        {
            Titel = _titel;
            Auteur = _auteur;
            Paginas = _paginas;
        }

        // Methode ToonBoek: De eingeschappen "Titel", "Auteur" en "Paginas" worden op het scherm afgedrukt.
        public string ToonBoek()
        {
            return $"Titel: {Titel}, Auteur: {Auteur}, Aantal bladzijden: {Paginas}";
        }
    }
}
