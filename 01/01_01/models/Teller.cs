using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Teller
    {

        /*Teller                    -> Naam van de klasse (Teller.cs)
        * -------------------------
        * +Waarde : int             -> Eigenschap "Waarde" met bijhordend attribuut "_waarde". De eigenschap staat public zodat deze vanuit andere klassen kan worden aangesproken.
        * -------------------------
        * +Teller()                 -> Constructor "Teller()" waarin de standaardwaarde wordt gezet (0). De constructor heeft dezelfde naam als de klasse.
        * +Verhoog() : void         -> Methode "Verhoog()" die de waarde van de teller met 1 verhoogt.
        * +Verlaag() : void         -> Methode "Verlaag()" die de waarde van de teller met 1 verlaagt.
        * +Resetten() : void        -> Methode "Resetten()" die de waarde van de teller terug op 0 zet.
        * +ToonGegevens() : string  -> Methode "ToonGegevens()" die de waarde van de teller teruggeeft als een string.
        * ------------------------
        */
 
        //Deel 1: Attributen
        private int _waarde;

        //Deel 2: Properties 
        public int Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }

        //Deel 3: Constructors
        public Teller()
        {
            Waarde = 0;
        }
        //Deel 4: Methoden

        /* Methode Verhoog
        * Deze methode verhoogt de waarde van de teller met 1.
        */
        public void Verhoog()
        {
            Waarde++;
        }
        
        /* Methode Verlaag
        * Deze methode verlaagt de waarde van de tellert met 1.
        */
        public void Verlaag()
        {
            Waarde--;
        }

        /* Methode Resetten
        * Deze methode reset de waarde van de teller naar 0.
        */
        public void Resetten()
        {
            Waarde = 0;
        }

        /* Methode ToonGegevens
        * Deze methode geeft een tekstuele weergave van het object:
        * De waarde van de teller is <Waarde>
        */
        public string ToonGegevens()
        {
            Convert.ToString(Waarde);
            return $"{Waarde}";
        }
    }
}