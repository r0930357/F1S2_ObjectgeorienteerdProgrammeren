using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Motor
    {
        /* Motor
         * ------------------------------------
         * +Cilinderinhoud : int
         * +Pk : int
         * ------------------------------------
         * +Motor(cilinderinhoud: int, pk: int)
         * +ToString() : string
         */

        private int _cilinderinhoud;
        private int _pk;

        public int Cilinderhoud
        {
            get { return _cilinderinhoud; }
            set { _cilinderinhoud = value; }
        }
        
        public int Pk
        {
            get { return _pk; }
            set { _pk = value; }
        }

        public Motor(int cilinderhoud, int pk)
        {
            Cilinderhoud = cilinderhoud;
            Pk = pk;
        }

        /* Geeft de tekstuele voorstelling van het object als volgt
         * Cilinderinhoud: <Cilinderinhoud> - Pk: <Pk>
         */

        public override string ToString()
        {
            return $"Cilinderinhoud: {Cilinderhoud} - Pk: {Pk}";
        }
    }
}