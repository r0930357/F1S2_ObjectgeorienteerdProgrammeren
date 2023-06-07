using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace models
{
    public class Tamagotchi
    {
        /* Tamagotchi
         * ---------------------------------------------------------
         * +GoedGevoel : int
         * +Honger : int
         * +LaatsteMaaltijd : DateTime
         * +Naam : string
         * ---------------------------------------------------------
         * +Tamagotchi(naam: string)
         * +Tamagotchi(naam: string, eenHonger: int, eenGevoel: int)
         * +Eten(eenheden: int) : void
         * +Liefkozen() : void
         * +Straffen(eenheden: int) : void
         * +Gevoel() : string
         */

        private int _goedGevoel;
        private int _honger;
        private DateTime _laatsteMaaltijd;
        private string _naam;

        /* Er word een waarde bijgehouden die het emotionele gevoel zal voorstellen.
         * Deze waarde kan variëren van -10 (rotslecht) tot +10 (Super).
         * Bij een foutieve nieuwe waarde groter dan 10, wordt het ingesteld op 10.
         * Bij een foutieve nieuwe waarde kleiner dan -10, wordt het ingesteld op -10.
         */
        public int GoedGevoel
        {
            get { return _goedGevoel; }
            set
            {
                if (value < -10)
                {
                    value = -10;
                }
                else if (value > 10)
                {
                    value = 10;
                }
                _goedGevoel = value;
            }
        }

        /* Er word een waarde bijgehouden die het hongersgevoel zal voorstellen.
         * Deze waarde kan variëren van -5 (uitgehongerd) tot +20 (meer dan voldaan).
         * Bij een foutieve nieuwe waarde groter dan 20, wordt het ingesteld op 20.
         * Bij een foutieve nieuwe waarde kleiner dan -5, wordt het ingesteld op -5.
         */
        public int Honger
        {
            get { return (_honger); }
            set
            {
                if (value < -5)
                {
                    value = -5;
                }
                else if (value > 20)
                {
                    value = 20;
                }
                _honger = value;
            }
        }

        public DateTime LaatsteMaaltijd
        {
            get { return _laatsteMaaltijd; }
            set { _laatsteMaaltijd = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public Tamagotchi(string naam, int eenHonger, int eenGevoel)
        {
            Naam = naam;
            Honger = eenHonger;
            GoedGevoel = eenGevoel;
        }
        public Tamagotchi(string naam)
        {
            Naam = naam;
        }

        /* Men kan een Tamagotchi eten geven.
         * De methode eten heeft een parameter waarin men aangeeft hoeveel eenheden men geeft.
         * Per keer kan een Tamagotchi echter slechts 3 eenheden opnemen, zelfs als er meerdere aangeboden worden.
         * Het tijdstip van eten wordt bijgehouden bij de LaatsteMaaltijd.
         */
        public void Eten(int eenheden)
        {
            LaatsteMaaltijd = DateTime.Now;
            eenheden++;

            if (eenheden <= 3)
            {
                Honger++;
            }
            Honger = 3;
        }

        /* Daarnaast kan men het diertje liefkozen als het nog leeft.
         * Telkens als men dit doet, gaat er het goedgevoel met één vermeerderd worden.
         */
        public void Liefkozen()
        {
            GoedGevoel++;
        }

        /* Men kan het natuurlijk ook straffen als het nog leeft.
         * Men geeft op hoeveel men straft.
         * Het goed gevoel vermindert in dezelfde mate.
         */
        public void Straffen(int eenheden)
        {
            GoedGevoel--;
        }

        /* Er kan gevraagd worden naar een tekstuele weergave over hoe de Tamagotchi zich voelt.
         * Belangrijk is dat net voordat hij antwoordt, de Tamagotchi zal berekenen hoe hij zich voelt.
         * Telkens je ernaar vraagt, zal hij zijn goedgevoel met 1 verminderen, hij mist immers je liefkozingen.
         * Maar onder de nul zal zijn GoedGevoel op deze manier niet geraken.
         * Als hij 30 seconden niets gegeten heeft, dan zal zijn honger met een eenheid zakken.
         */
        public string Gevoel()
        {
            GoedGevoel--;
            if (GoedGevoel < 0)
            {
                GoedGevoel = 0;
            }

            if (LaatsteMaaltijd.AddSeconds(30) >= LaatsteMaaltijd)
            {
                Honger--;
            }

            return $"\nTamagochi naam: {Naam}\n" +
                $"Gevoel (-5 tot 20): {GoedGevoel}\n" +
                $"Honger: {Honger}\n" +
                $"Laatste maaltijd: {LaatsteMaaltijd.ToShortTimeString()}";
        }
    }
}
