using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Koffie : Zoetigheid
    {
        /* Koffie
         * --------------------------------------------------------------------------
         * +Smaak : string
         * +Slagroom : bool
         * --------------------------------------------------------------------------
         * +Koffie(siroop: string, topping: string, smaak: string, metSlagroom: bool)
         * +BerekenPrijs() : double
         * +ToonOverzicht() : string
         * +ToString() : string
         */

        private string _smaak;
        private bool _slagroom;

        public string Smaak
        {
            get { return _smaak; }
            set { _smaak = value; }
        }

        public bool Slagroom
        {
            get { return _slagroom; }
            set { _slagroom = value; }
        }

        public Koffie(string siroop, string topping, string smaak, bool metSlagroom) : base(siroop, topping)
        {
            Smaak = smaak;
            Slagroom = metSlagroom;
        }

        /* Een standaardprijs voor een koffie is 3,5 euro.
         * Indien slagroom gevraagd is, wordt er 0.5 euro toegevoegd aan de totale prijs van de koffie.
         * Vergeet de topping en siroop niet mee te tellen!
         */
        public override double BerekenPrijs()
        {
            double koffie = 3.5;

            if (Smaak != "Geen")
            {
                koffie += 0.5;
            }

            if (Slagroom != false)
            {
                koffie += 0.5;
            }

            double prijs = base.BerekenPrijs() + koffie;
            return prijs;
        }

        /* Deze methode geeft een tekstuele weergave van het object:
         * Type: <Type>
         * Topping: <Topping>
         * Siroop: <Siroop>
         * Smaak: <Smaak>
         * Met slagroom: <MetSlagroom>
         * Prijs: <Prijs> euro
         */
        public override string ToonOverzicht()
        {
            return $"Type: {this.GetType().Name}\n" +
                   $"{base.ToonOverzicht()}\n" +
                   $"Smaak: {Smaak}\n" +
                   $"Met slagroom: {Slagroom}\n" +
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
