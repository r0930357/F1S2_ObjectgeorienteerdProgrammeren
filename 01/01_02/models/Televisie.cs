using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Televisie
    {

        /* Televisie
         * --------------------------
         * +Kanaal : int
         * +Volume : int
         * --------------------------
         * +Televisie()
         * +ToonGegevens() : string
         * +VermeerderKanaal() : void
         * +VerminderKanaal() : void
         * +VermeerderVolume() : void
         * +VerminderVolume() : void
         * --------------------------
         */

        // Declaratie van de attributen
        public int _kanaal;
        public int _volume;

        // Declaratie van de properties
        // Het kanaal kan niet kleiner worden dan 1.
        // Het kanaal kan niet groter worden dan 30.
        public int Kanaal
        {
            get
            {
                return _kanaal;
            }
            set
            {
                if (value >= 1 && value <= 30)
                {
                    _kanaal = value;
                }
            }
        }

        // Het volume kan niet kleiner worden dan 0.
        // Het volume kan niet groter worden dan 10.
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _volume = value;
                }
            }
        }

        // Declaratie van de constructor
        // Standaardwaarde voor het kanaal is 1. Standaardwaarde voor het volume is 5.
        public Televisie()
        {
            _kanaal = 1;
            _volume = 5;
        }

        // Toon het actuele kanaal en volume.
        public string ToonGegevens()
        {
            return $"Kanaal: {_kanaal}, Volume: {_volume}";
        }


        // Declaratie van de methodes
        // Kanaal met 1 verhogen.
        public void VermeerderKanaal()
        {
        if (_kanaal < 30)
            {
                _kanaal++;
            } 
        }

        // Kanaal met 1 verlagen.
        public void VerminderKanaal()
        {
            if (_kanaal > 1)
            {
                _kanaal--;
            }
        }

        // Volume met 1 verhogen.
        public void VermeerderVolume()
        {
        if (_volume < 10)
            {
                _volume++;
            }
        }

        // Volume met 1 verlagen.
        public void VerminderVolume()
        {
            if (_volume > 0)
            {
                _volume--;
            }
        }
    }
}
