using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace models
{
    public class Cirkel : Punt
    {
        /* Cirkel
         * ----------------------------------------
         * +R : double
         * +Omschrijving : string
         * ----------------------------------------
         * +Cirkel()
         * +Cirkel(x: double, y: double, r: double)
         * +Omtrek() : double
         * +Oppervlakte() : double
         * +ToonGegevens() : string
         */

        private double _r;

        public double R
            { get { return _r; }
            set {  _r = value; }
        }

        // Property Omschrijving
        // Dit geeft als returnwaarde de waarde.
        // <klassenaam>:coord= (< X >,< Y >) straal<R>
        // Tip: De klassenaam is op te vragen door de methode this.GetType().Name
        public override string Omschrijving
        {
            get { return base.Omschrijving + $" straal {R}"; }
        }

        public Cirkel(double x, double y, double r) : base(x, y)
        {
            R = r;
        }

        public Cirkel() { }

        // Methode Omtrek()
        // Returnwaarde is de omtrek van de cirkel
        // Formule: 2 * π* r.Rond af tot 2 cijfers na de komma adhv Math.Round().
        public virtual double Omtrek()
        {
            return 2 * Math.PI * R;
        }

        // Methode Oppervlakte()
        // Returnwaarde is de oppervlakte van de cirkel
        // Formule: π * r². Rond af tot 2 cijfers na de komma adhv Math.Round().

        public virtual double Oppervlakte()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        /* Methode ToonGegevens()
         * Geeft de tekstuele voorstelling van het object als volgt: <klassenaam>:coord=(<X>,<Y>) straal
         * <R> Oppervlakte: <Oppervlakte>
         * Omtrek: <Omtrek>
         * Maak gebruik van de property Omschrijving!
         */
        public override string ToonGegevens()
        {
            return $"{Omschrijving}\n" +
                $"Oppervlakte: {Math.Round(Oppervlakte(), 2)}\n" +
                $"Omtrek: {Math.Round(Omtrek(), 2)}";
        }
    }
}
