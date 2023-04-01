using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Donut : Zoetigheid
    {
        /* Donut
         * -------------------------------------------------------------------------
         * +Glazuur : string
         * +Vulling : string
         * -------------------------------------------------------------------------
         * +Donut(siroop: string, topping: string, glazuur: string, vulling: string)
         * +BerekenPrijs() : double
         * +ToonOverzicht() : string
         * +ToString() : string
         */

        private string _glazuur;
        private string _vulling;

        public string Glazuur
        {
            get { return _glazuur; }
            set { _glazuur = value; }
        }

        public string Vulling
        {
            get { return _vulling; }
            set { _vulling = value; }
        }

        public Donut(string siroop, string topping, string glazuur, string vulling) : base(siroop, topping)
        {
            Glazuur = glazuur;
            Vulling = vulling;
        }

        /* Een standaardprijs voor een donut is 2 euro.
         * Voor elke extra optie (glazuur en vulling) die gekozen wordt, word er 0.5 euro toegevoegd aan de totale prijs voor de donut.
         * Vergeet de topping en siroop niet mee te tellen!
         */
        public override double BerekenPrijs()
        {
            double donut = 2;

            if (Glazuur != "Geen")
            {
                donut += 0.5;
            }

            if (Vulling != "Geen")
            {
                donut += 0.5;
            }

            double prijs = base.BerekenPrijs() + donut;
            return prijs;
        }

        /* Deze methode geeft een tekstuele weergave van het object:
         * Type: <Type>
         * Topping: <Topping>
         * Siroop: <Siroop>
         * Glazuur: <Glazuur>
         * Vulling: <Vulling>
         * Prijs: <Prijs> euro
         */
        public override string ToonOverzicht()
        {
            return $"Type: {this.GetType().Name}\n" +
                   $"{base.ToonOverzicht()}\n" +
                   $"Glazuur: {Glazuur}\n" +
                   $"Vulling: {Vulling}\n" +
                   $"Prijs: {BerekenPrijs()}";
        }

        /* Deze methode geeft een tekstuele weergave van het object:
         * <Type> ⇒ <Prijs> euro
         */
        public override string ToString()
        {
            return $"{this.GetType().Name} => {BerekenPrijs()} euro";
        }
    }
}
