using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Auto
    {
        /* Auto
         * -----------------------------------------------------------------------------------------------
         * #Merk : string
         * #Nummerplaat: string
         * #AantalKilometer : double
         * #KostPrijs : double
         * #LiterBrandstof : double
         * -----------------------------------------------------------------------------------------------
         * #Auto(nummerplaat: string, aantalKilometers: double, kostPrijs: double, literBrandstof: double)
         * +ToString() : string
         * +Equals(obj: object) : bool
         * +Rijden(aantalKilometer: double)
         */

        // Attributen
        private string _nummerplaat;
        private double _aantalkilometer;
        private double _kostprijs;
        private double _literbrandstof;

        // Properties

        /* Property Merk
         * Dit geeft als returnwaarde de tekstuele waarde <klassenaam>
         * Tip: De klassenaam is op te vragen door de methode this.GetType().Name *
         */
        protected string Merk
        {
            get { return this.GetType().Name; }
        }

        protected string Nummerplaat
        {
            get { return _nummerplaat; }
            set { _nummerplaat = value; }
        }

        protected double Aantalkilometer
        {
            get { return _aantalkilometer; }
            set { _aantalkilometer = value; }
        }

        protected double Kostprijs
        {
            get { return _kostprijs; }
            set { _kostprijs = value; }
        }

        protected double Literbrandstof
        {
            get { return _literbrandstof; }
            set { _literbrandstof = value; }
        }

        // Constructor
        protected Auto(string nummerplaat, double aantalKilometers, double kostPrijs, double literBrandstof)
        {
            nummerplaat = Nummerplaat;
            aantalKilometers = Aantalkilometer;
            kostPrijs = Kostprijs;
            literBrandstof = Literbrandstof;
        }

        //Methoden

        /* Methode Rijden(double aantalKilometer)
         * Deze methode zal kilometers toevoegen aan het totale aantal en vervolgens de hoeveelheid brandstof verrekenen waarbij er bij 20 kilometer 1 liter verbruikt is.
         */

        public virtual void Rijden(double aantalKilometer)
        {
            this.Aantalkilometer += aantalKilometer;
            this.Literbrandstof -= (aantalKilometer / 20);
        }

        /* Methode Equals(Object obj)
         * Een auto is gelijk aan een andere kaart als beide een van het type auto zijn alsook dezelfde nummerplaat bevatten.
         */
        
        public override bool Equals(object obj)
        {
            if (obj is Auto auto)
            {
                return (this.Nummerplaat == auto.Nummerplaat) && this.GetType() == auto.GetType();
            }
            return false;
        }

        /* Methode ToString()
         * Geeft de tekstuele voorstelling van het object als volgt:
         * Ik ben een<Merk> <AantalKilometer> km op de teller. Je kan mij kopen voor<KostPrijs> euro!
         */
        public override string ToString()
        {
            return $"Ik ben een {this.Merk} {this.Aantalkilometer} km op de teller. {this.Literbrandstof:N2} liter. Je kan mij kopen voor {this.Kostprijs} euro!";
        }

        // !! Indien CodeGrade moeilijk doet -> deze override methode bijvoegen !!
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
