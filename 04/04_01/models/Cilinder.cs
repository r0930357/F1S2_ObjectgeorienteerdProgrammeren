using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace models
{
    public class Cilinder : Cirkel
    {
        /* Cilinder
         * -----------------------------------------------------
         * +H : double
         * +Omschrijving : string
         * -----------------------------------------------------
         * +Cilinder()
         * +Cilinder(x: double, y: double, r: double, h: double)
         * +Oppervlakte() : double
         * +Volume() : double
         * +ToonGegevens() : string
         */

        private double _h;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        // Property Omschrijving
        // Dit geeft als returnwaarde de waarde.
        // <klassenaam>:coord= (< X >,< Y >) straal<R>, hoogte<H>
        public override string Omschrijving
        {
            get { return base.Omschrijving + $", hoogte = {H}"; }
        }

        public Cilinder(double x, double y, double r, double h) : base(x, y, r)
        {
            H = h;
        }

        public Cilinder() { }

        // Methode Oppervlakte()
        // Berekent de oppervlakte van de cilinder.
        // Formule = 2 * π * r² + 2 * π * r * h.
        // Maak in de formule gebruik van de oppervlakte en de omtrek die in de klasse Cirkel is aangemaakt
        public override double Oppervlakte()
        {
            return 2 * base.Oppervlakte() + base.Omtrek() * H;
        }

        // Methode Volume()
        // Berekent het volume van de cilinder.
        // Formule = π* r² * h
        // Maak gebruik van de oppervlakte van de cirkel die in de klasse Cirkel is aangemaakt

        public double Volume()
        {
            return base.Oppervlakte() * H;
        }

        // Methode ToonGegevens()
        // Geeft de tekstuele voorstelling van het object als volgt:
        // <klassenaam>:coord=(<X>,<Y>) straal <R>, hoogte<H>
        // Oppervlakte: <Oppervlakte>
        // Volume: <Volume>
        // Maak gebruik van de property Omschrijving!

        public override string ToonGegevens()
        {
            return $"{Omschrijving}\n" +
                $"Oppervlakte: {Math.Round(Oppervlakte(), 2)}\n" +
                $"Volume: {Math.Round(Volume(), 2)}";
        }
    }
}
