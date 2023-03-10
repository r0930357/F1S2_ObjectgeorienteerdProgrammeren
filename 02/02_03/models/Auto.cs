using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace models
{
    public class Auto
    {
        /* Klassediagram:
         *
         * Auto
         * -----------------------------------------------
         * +Brandstofstand: double
         * +Kilomterstand: int
         * +Onderhoudstand : int
         * -----------------------------------------------
         * +Auto()
         * +Auto(brandstofstand: int, kilometerstand: int)
         * +Keuzemenu(keuze: int) : void
         * +ToonStatus() : string
         */

        //Attributen 
        public double _brandstofstand;
        public int _kilometerstand;
        public int _onderhoudsstand;

        //Properties
        /* De hoeveelheid brandstof kan niet groter zijn dan 60 en niet kleiner zijn dan 0.
         * Bij een foutieve nieuwe waarde kleiner dan 0, zal 0 ingesteld worden.
         * Bij foutieve nieuwe waarde groter dan 60, wordt 60 ingesteld.
         * Beide kilometerstanden kunnen niet kleiner zijn dan 0.
         * Bij een foutieve nieuwe waarde kleiner dan 0, zal 0 ingesteld worden.
         */
        public double Brandstofstand
        {
            get { return _brandstofstand; }
            set
            {
                if (value > 60)
                {
                    _brandstofstand = 60;
                }
                else if (value < 0)
                {
                    _brandstofstand = 0;
                }
                _brandstofstand = value;
            }
        }

        public int Kilometerstand
        {
            get { return _kilometerstand; }
            set
            {
                if (value < 0)
                {
                    _kilometerstand = 0;
                }
                else
                {
                    _kilometerstand = value;
                }
            }
        }

        public int Onderhoudsstand
        {
            get { return _onderhoudsstand; }
            set
            {
                if (value < 0)
                {
                    _onderhoudsstand = 0;
                }
                else
                {
                    _onderhoudsstand = value;
                }
            }
        }

        //Constructors
        //Overloaded constructor
        public Auto(int brandstof, int kilometers, int onderhoudsstand)
        {
            Brandstofstand = brandstof;
            Kilometerstand = kilometers;
            Onderhoudsstand = onderhoudsstand;
        }

        //Standaard constructor
        public Auto() : this(0, 0, 0) { }

        //Methodes
        /* Per kilometer zal 0.05 liter verdwijnen uit de brandstof.
         * Indien de brandstof onder de 10 liter komt, zal er vloeistof aangevuld moeten worden.
         * Vanaf 25.000 kilometer gereden te hebben sinds het laatste onderhoud, zal er onderhoud aan de auto vereist zijn.
         */
        public void KeuzeMenu(int keuze)
        {
            if (keuze == 0)
            {
                ToonStatus();
            }
            else if (keuze == 1)
            {
                Kilometerstand += 25;
                Brandstofstand -= 1.25;
                ToonStatus();
            }
            else if (keuze == 2)
            {
                Kilometerstand += 100;
                Brandstofstand -= 5;
                ToonStatus();
            }
            else if (keuze == 3)
            {
                Kilometerstand += 1000;
                Brandstofstand -= 50;
                ToonStatus();
            }
            else if (keuze == 4)
            {
                Console.Write("Geef hoeveelheid brandstof: ");
                double brandstof = double.Parse(Console.ReadLine());
                Brandstofstand += brandstof;
                ToonStatus();
            }
            else if (keuze == 5)
            {
                Kilometerstand = 0;
                ToonStatus();
            }
        }

        public string ToonStatus()
        {
            string status = string.Empty;

            if (Brandstofstand > 10 && (Kilometerstand - Onderhoudsstand < 25000))
            {
                status = $"\nStatus\n------\nDe auto is volledig in orde!";
            }
            else if (Brandstofstand < 10 && (Kilometerstand - Onderhoudsstand < 25000))
            {
                status = $"\nStatus\n------\nVoeg brandstof toe aub!";
            }
            else if (Brandstofstand > 10 && (Kilometerstand - Onderhoudsstand > 25000))
            {
                status = $"\nStatus\n------\nEr is dringend onderhoud nodig!";
            }
            else if (Brandstofstand < 10 && (Kilometerstand - Onderhoudsstand > 25000))
            {
                status = $"\nStatus\n------\nVoeg brandstof toe aub!\nEr is dringend onderhoud nodig!";
            }
            return status;
        }
    }
}
