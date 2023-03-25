using System;
using System.Collections.Generic;
using System.Drawing;
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

        private double _x;
        private double _y;
        private string _omschrijving;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        
        // Property Omschrijving
        // Dit geeft als returnwaarde de tekstuele waarde<klassenaam>:coord=(<X>,<Y>)
        // Tip: De klassenaam is op te vragen door de methode this.GetType().Name
        public virtual string Omschrijving
        {
            get { return this.GetType().Name + $": coord=({X},{Y})"; }
        }

        public Punt(double x, double y)
        {
            X = x ;
            Y = y;
        }

        public Punt() { }

        // Methode ToonGegevens()
        // returnwaarde is de omschrijving.
        public virtual string ToonGegevens()
        {
            return $"{Omschrijving}";
        }
    }
}
