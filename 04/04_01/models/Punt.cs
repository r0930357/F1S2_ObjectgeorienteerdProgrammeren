using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace models
{
    public class Punt
    {
        /* Punt
         * ---------------------------
         * +X : double
         * +Y : double
         * +Omschrijving : string
         * ---------------------------
         * +Punt()
         * +Punt(x: double, y: double)
         * +ToonGegevens() : string
         */

        public double _x;
        public double _y;
        public string _omschrijving;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _x; }
            set { _x = value; }
        }
        
        // Property Omschrijving
        // Dit geeft als returnwaarde de tekstuele waarde<klassenaam>:coord=(<X>,<Y>)
        // Tip: De klassenaam is op te vragen door de methode this.GetType().Name
        public string Omschijving
        {
            get { return $"{this.GetType().Name}:coord(<{X}>, <{Y}>)"; }
        }

        public Punt(double x, double y)
        {
            X = x ;
            Y = y;
        }

        public Punt() : this(0.0, 0.0) { }

        // Methode ToonGegevens()
        // returnwaarde is de omschrijving.
        public virtual string ToonGegevens()
        {
            string omschrijving = $"{Omschijving}";
            return omschrijving ;
        }
    }
}
