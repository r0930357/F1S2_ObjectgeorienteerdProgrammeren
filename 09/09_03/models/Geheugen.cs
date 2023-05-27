using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Geheugen : Onderdeel
    {
        /* Geheugen
         * ----------------------------------------------------------
         * +Type : string
         * +ModuleGrootte : int
         * ----------------------------------------------------------
         * +Geheugen(type: string, moduleGrootte: int, prijs: double)
         * +ToString() : string
         */

        private string _type;
        private int _modulegrootte;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int ModuleGrootte
        {
            get { return _modulegrootte; }
            set { _modulegrootte = value; }
        }

        public Geheugen(string type, int moduleGrootte, double prijs) : base(prijs)
        {
            Type = type;
            ModuleGrootte = moduleGrootte;
        }

        /* Methode ToString
         * Geeft een tekstuele voorstelling van het object als volgt:
         * Geheugen: <Type> - <ModuleGrootte>GB
         */
        public override string ToString()
        {
            return $"Geheugen; <{Type}> - <{ModuleGrootte}>GB";
        }

    }
}
