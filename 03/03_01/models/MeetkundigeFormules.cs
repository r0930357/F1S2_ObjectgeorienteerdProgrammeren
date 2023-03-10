using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace models
{
    public static class MeetkundigeFormules
    {
        /* «static»
         * MeetkundigeFormules
         * ------------------------------------------------------------------
         * +OppervlakteRechthoek(double lengte, double breedte) : double
         * +OppervlakteCirkel(double straal) : double
         * +VolumeBalk(double lengte, double breedte, double hoogte) : double
         * +VolumeCilinder(double straal, double hoogte) : double
         * ------------------------------------------------------------------
         */

        /* Statische methode OppervlakteRechthoek
         * Deze methode zal de oppervlakte van een rechthoek berekenen aan de hand van de meegegeven lengte en breedte.
         * De formule hiervoor is: <lengte> * <breedte>
         */
        public static double OppervlakteRechthoek(double lengte, double breedte)
        {
            double opperlvlakterechthoek;
            opperlvlakterechthoek = lengte * breedte;
            return opperlvlakterechthoek;
        }

        /* Statische methode OppervlakteCirkel
         * Deze methode zal de oppervlakte van een cirkel berekenen aan de hand van de meegegeven straal.
         * De formule hiervoor is: π * <straal>²
         */
        public static double OppervlakteCirkel(double straal)
        {
            double oppervlaktecirkel;
            oppervlaktecirkel = Math.PI * Math.Pow(straal, 2);
            return oppervlaktecirkel;
        }

        /* Statische methode VolumeBalk
         * Deze methode zal de volume van een balk berekenen aan de hand van de meegegeven lengte, breedte en hoogte.
         * De formule hiervoor is: <lengte> * <breedte> * <hoogte>
         */
        public static double VolumeBalk(double lengte, double breedte, double hoogte)
        {
            double volumeBalk;
            volumeBalk = lengte * breedte * hoogte;
            return volumeBalk;
        }

        /* Statische methode VolumeCilinder
         * Deze methode zal de volume van een cilinder berekenen aan de hand van de meegegeven straal en hoogte.
         * De formule hiervoor is: π * <straal>² * <hoogte>
         */
        public static double VolumeCilinder(double straal, double hoogte)
        {
            double volumeCilinder;
            volumeCilinder = Math.PI * Math.Pow(straal, 2) * hoogte;
            return volumeCilinder;
        }
    }
}
