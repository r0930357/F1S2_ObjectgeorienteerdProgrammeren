using System;
using System.Text;

namespace models
{
    public class Vierkant
    {

        /* Vierkant
         * ----------------------
         * +Zijde : int
         * +Vierkant()
         * +Vierkant(lengte: int)
         * ----------------------
         * +Diagonaal() : double
         * +Omtrek() : int
         * +Oppervlakte() : int
         * +Teken() : string
         * ----------------------
         */

        public int _zijde;
                
       /* Property Zijde
        * De zijde mag niet kleiner zijn dan 0. Bij een waarde kleiner dan 0, zal 0 ingesteld worden.
        * De zijde mag niet groter zijn dan 25. Bij een waarde groter dan 25, zal 25 ingesteld worden.
        */

        public int Zijde
        {
            get { return _zijde; }
            set
            {
                if (value < 0)
                {
                    _zijde = 0;
                }
                else if (value > 25)
                {
                    _zijde = 25;
                }
                else
                {
                    _zijde = value;
                }
            }
        }

        public Vierkant (int lengte)
        {
            Zijde = lengte;
        }

        public Vierkant() : this(0) { }

        /* Methode Oppervlakte
         * De oppervlakte wordt als volgt berekend: <Zijde> * <Zijde>
         */

        public int Oppervlakte()
        {
            int oppervlakte = Zijde * Zijde;
            return oppervlakte;
        }

        /* Methode Omtrek
         * De omtrek wordt als volgt berekend: 4 * <Zijde>
         */

        public int Omtrek()
        {
            int omtrek = Zijde * 4;
            return omtrek;
        }

        /* Methode Diagonaal
         * De Lengte van de diagonaal wordt als volgt berekend: vierkantswortel(2) * <Zijde>.
         * Rond af tot op 2 cijfers na de komma.Gebruik hiervoor de methode Math.Round.
         */
        public double Diagonaal()
        {
            double diagonaaal = Math.Sqrt(2) * Zijde;
            return Math.Round(diagonaaal, 2);
        }

        /* Methode Teken
         * Deze methode maakt onder de vorm van een sterretjesmatrix een vierkant met de opgegeven zijde.
         * Een voorbeeld met zijde = 3:
         */

        public string Teken()
        {
            string figuur = "", symbool = "*";

            for (int i = 1; i <= Zijde; i++)
            {
                for (int j = 1; j <= Zijde; j++)
                {
                    figuur += symbool + " ";
                }
                figuur = figuur.Trim();
                figuur += Environment.NewLine;
            }
            return figuur;
        }
    }
}
