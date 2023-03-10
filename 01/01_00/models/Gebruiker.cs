using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Gebruiker
    {

        /* Gebruiker
         * ------------------------
         * +Nummer : int
         * +Voornaam : string
         * +Familienaam : string
         * ------------------------
         * +Gebruiker()
         * +Wissen() : void
         * +ToonGegevens() : string
         * ------------------------
         */

        // Onderdelen van een klasse

        /* Gebruiker                -> naam van de klasse (Gebruiker.cs)
        * 
        * ------------------------
        * 
        * +Nummer : int             -> eigenschap van een klasse. "+" = public, "-" = private. Naam = "Nummer", Type = int
        * +Voornaam : string        -> eigenschap van een klasse. "+" = public, "-" = private. Naam = "Voornaam", Type = string
        * +Familienaam : string     -> eigenschap van een klasse. "+" = public, "-" = private. Naam = "Familienaam", Type = string
        * 
        *                           De eigenschappen moeten in de klasse worden gedeclareerd door middel van het aanmakan van attributen.
        * 
        * ------------------------
        * 
        * +Gebruiker()              -> constructor van de klasse. Deze methode wordt gebruikt om een object van de klasse te instantiëren. De naam van de methode is altijd gelijk aan de naam van de klasse, in dit geval "Gebruiker".
        * 
        * +Wissen() : void          -> methode van de klasse. Deze methode wordt gebruikt om de eigenschappen van een object van de klasse te wissen. De naam van de methode is "Wissen".
        * +ToonGegevens() : string  -> methode van de klasse. Deze methode wordt gebruikt om de eigenschappen van een object van de klasse te tonen. De naam van de methode is "ToonGegevens".
        *
        * ------------------------
        */


        // Deel 1: Attributen
        // Deze bevatten de attributen _nummer, _voornaam en _familienaam welke in de eigenschappen worden gebruikt
        private int _nummer;
        private string _voornaam;
        private string _familienaam;

        // Deel 2: Properties
        // Deze bevatten de eigenschappen Nummer, Voornaam, Familienaam en VolledigeNaam

        // Eigenschap Nummer (get en set). Als het nummer kleiner is dan 0, dan wordt het nummer ingesteld op 0. Anders wordt het nummer ingesteld op de waarde die wordt meegegeven.
        public int Nummer
        {
            get { return _nummer; }
            set
            {
                if (value < 0)
                {
                    _nummer = 0;
                }
                else
                {
                    _nummer = value;
                }
            }
        }

        // Eigenschap Voornaam (get en set). De voornaam wordt ingesteld op de waarde die wordt meegegeven.
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        // Eigenschap Familienaam (get en set). De familienaam wordt ingesteld op de waarde die wordt meegegeven.
        public string Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }

        // Eigenschap VolledigeNaam (get). De volledige naam wordt opgebouwd uit de voornaam en de familienaam.
        public string VolledigeNaam
        {
            get { return $"{_voornaam} {_familienaam}"; }
        }

        // Deel 3: Constructores
        // Constructor Gebruiker. De eigenschappen Nummer, Voornaam en Familienaam worden ingesteld op een standaardwaarde.
        public Gebruiker()
        {
            Nummer = 0;
            Voornaam = "";
            Familienaam = "";
        }

        //Deel 4: methodes

        /* Methode Wissen
         * Deze methode zorgt ervoor dat de nummer wordt ingesteld op 0.
         * De voornaam en familienaam worden ingesteld op een lege string.
         */

        // Methode Wissen. De eigenschappen Nummer, Voornaam en Familienaam worden ingesteld op een standaardwaarde.
        public void Wissen()
        {
            Nummer = 0;
            Voornaam = "";
            Familienaam = "";
        }


        /* Methode ToonGegevens
         * Deze methode geeft een tekstuele weergave van het object:
         * <Nummer> - <Voornaam> <Familienaam>
         */

        // Methode ToonGegevens. De eigenschappen Nummer, Voornaam en Familienaam worden op het scherm getoond.
        public string ToonAlles()
        {
            return $"{Nummer}\n{Voornaam}\n{Familienaam}";
        }
    }
}
