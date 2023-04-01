using System;
using System.Text;

namespace models
{
    public class Zoetigheid
    {
        /* Zoetigheid
         * --------------------------------------------
         * +Siroop : string
         * +Topping : string
         * --------------------------------------------
         * #Zoetigheid(siroop: string, topping: string)
         * +BerekenPrijs() : double
         * +ToonOverzicht() : string
         */

        private string _siroop;
        private string _topping;

        public string Siroop
        {
            get { return _siroop; }
            set { _siroop = value; }
        }

        public string Topping
        { 
            get { return _topping; }
            set { _topping = value; }
        }

        protected Zoetigheid(string siroop, string topping)
        {
            Siroop = siroop;
            Topping = topping;
        }

        /* Een prijs wordt berekend op basis van de topping en siroop.
         * Voor een topping word 1,5 euro aangerekend en voor een siroop word 1 euro aangerekend.
         */
        public virtual double BerekenPrijs()
        {
            double zoetigheid = 0;
            if (Siroop != "Geen")
            {
                zoetigheid += 1;
            }

            if (Topping != "Geen")
            {
                zoetigheid += 1.5;
            }

            double prijs = zoetigheid;
            return prijs;
        }

        /* Deze methode geeft een tekstuele weergave van het object:
         * Topping: <Topping>
         * Siroop: <Siroop>
         */
         public virtual string ToonOverzicht()
        {
            return $"Topping: {Topping}\n" +
                   $"Siroop: {Siroop}";
        }
    }
}
