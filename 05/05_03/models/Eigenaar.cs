using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Eigenaar : Medewerker
    {
        // attributen
        private int _vastInkomen;

        // properties
        public int VastInkomen
        {
            get { return _vastInkomen; }
            set { _vastInkomen = value; }
        }

        // constructor
        public Eigenaar(string voornaam, string familienaam, int uurloon, int vastInkomen) :
            base(voornaam, familienaam, uurloon)
        {
            this.VastInkomen = vastInkomen;
        }

        // methoden
        public override string ToonGegevens()
        {
            return $"{Voornaam} {Familienaam} verdient {(Uurloon * 160) + VastInkomen} euro per maand. Dit is ook de eigenaar en daarom is het loon hoger.";
        }
    }
} 