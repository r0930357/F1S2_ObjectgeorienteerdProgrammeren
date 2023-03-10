using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

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

        public double _r;
        public string _omschrijving;

        public double R
            { get { return _r; }
            set {  _r = value; }
        }

        // Property Omschrijving
        // Dit geeft als returnwaarde de waarde.
        // <klassenaam>:coord= (< X >,< Y >) straal<R>
        // Tip: De klassenaam is op te vragen door de methode this.GetType().Name
        public string Omschrijving
        {
            get { return $"{this.GetType().Name}:coord(<{X}>, <{Y}>)straal <{R}>"; }
        }

        public Cirkel(double x, double y, double r) : base(x, y)
        {
            R = r;
        }

        public Cirkel() : this (0, 0, 0) { }

        // Methode Omtrek()
        // Returnwaarde is de omtrek van de cirkel
        // Formule: 2 * π* r.Rond af tot 2 cijfers na de komma adhv Math.Round().
        public double Omtrek()
        {
            double omtrek;
            omtrek = 2 * Math.PI * R;
            return Math.Round(omtrek, 2);
        }

        // Methode Oppervlakte()
        // Returnwaarde is de oppervlakte van de cirkel
        // Formule: π* r². Rond af tot 2 cijfers na de komma adhv Math.Round().

        public double Oppervlakte()
        {
            double oppervlakte;
            oppervlakte = Math.PI * Math.Pow(R, 2);
            return Math.Round(oppervlakte, 2);
        }

        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $"straal <{R}>\nOmtrek: {Omtrek()}\nOppervlakte: {Oppervlakte()}";
        }
    }
}
