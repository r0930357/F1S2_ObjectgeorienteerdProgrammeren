using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Moederbord : Onderdeel
    {

        /* Moederbord
         * -----------------------------------------------------------------------------------------------------
         * +Socket : string
         * +Chipset : string
         * +FormFactor : string
         * +GeheugenType : string
         * -----------------------------------------------------------------------------------------------------
         * +Moederbord(socket: string, chipset: string, formFactor: string, geheugenType: string, prijs: double)
         * +ToString() : string
         */

        private string _socket;
        private string _chipset;
        private string _formfactor;
        private string _geheugenType;

        public string Socket
        {
            get { return _socket; }
            set { _socket = value; }
        }

        public string Chipset
        { 
            get { return _chipset; }
            set {  _chipset = value; }
        }

        public string Formfactor
        {
            get { return _formfactor; }
            set { _formfactor = value; }
        }

        public string GeheugenType
        {
            get { return _geheugenType; }
            set { _geheugenType = value; }
        }

        public Moederbord(string socket, string chipset, string formfactor, string geheugenType, double prijs) : base(prijs)
        {
            Socket = socket;
            Chipset = chipset;
            Formfactor = formfactor;
            GeheugenType = geheugenType;
        }
  
        /* Methode ToString
         * Geeft een tekstuele voorstelling van het object als volgt:
         * Moederbord: Socket <Socket> - Chipset <Chipset> - Formfactor <FormFactor> - Geheugentype <GeheugenType>
         */
        public override string ToString()
        {
            return $"Socket: <{Socket}> - Chipset <{Chipset}> - Formfactor <{Formfactor}> - Geheugentype <{GeheugenType}>";
        }
    }
}
