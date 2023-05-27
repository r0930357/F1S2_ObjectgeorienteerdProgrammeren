using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace models
{
    public class PC
    {
        /* PC
         * ------------------------------
         * +Geheugen : Geheugen
         * +Moederbord : Moederbord
         * +Processor : Processor
         * ------------------------------
         * +ControleerOnderdelen() : bool
         * +PcIsCompleet() : bool
         * +VerwijderOnderdelen() : void
         * +TotaalPrijs() : double
         * +ToString() : string
         */

        private Geheugen _geheugen;
        private Moederbord _moederbord;
        private Processor _processor;

        public Geheugen Geheugen
        {
            get { return _geheugen; }
            set { _geheugen = value; }
        }

        public Moederbord Moederbord
        {
            get { return _moederbord; }
            set { _moederbord = value; }
        }

        public Processor Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }

        /* Methode ControleerOnderdelen
         * Controleerd of onderdelen compatibel zijn.
         * Wanneer de socket van moederbord en processor niet overeenkomen, gooi dan een Exception met de message "Deze processor past niet op dit moederbord".
         * Wanneer het geheugentype van het moederbord en geheugen niet overeenkomen, gooi dan een Exception met de message "Dit geheugen past niet op dit moederbord".
         * Wanneer er geen Exception gegooid werd, zal de returnwaarde true zijn.
         */
        public bool ControleerOnderdelen()
        {
            if (Moederbord.Socket != Processor.Socket)
            {
                return false;
                throw new Exception("Deze processor past niet op dit moederbord");
            }
            else if (Moederbord.GeheugenType != Geheugen.Type)
            {
                return false;
                throw new Exception("Dit geheugen past niet op dit moederbord");
            }
            return true;
        }
         
        /* Methode PcIsCompleet
         * Deze methode zal controleren of elk onderdeel opgevuld is.
         */
        public bool PcIsCompleet()
        {
            if (Geheugen != null && Moederbord != null && Processor != null)
            {
                return true;
            }
            return false;
        }

        /*Methode VerwijderOnderdelen
         * Deze methode zal alle onderdelen verwijderen.
         */
        public void VerwijderOnderdelen()
        {
            Geheugen = null;
            Moederbord = null;
            Processor = null;
        }

        /* Methode TotaalPrijs
         * Deze methode zal een returnwaarde bevatten van de prijs van alle onderdelen samen.
         */
        public double TotaalPrijs()
        {
            return Geheugen.Prijs + Moederbord.Prijs + Processor.Prijs;
        }

        /*Methode ToString
         * Geeft een tekstuele voorstelling van het object als volgt:
         * Geheugen: <Geheugen>
         * Moederbord: <Moederbord>
         * Processor: <Processor>
         * Totaalprijs: <TotaalPrijs()> euro
         */

        public override string ToString()
        {
            return $"Geheugen: {Geheugen}\n" +
                $"Moederbord: {Moederbord}\n" +
                $"Processor: {Processor}\n" +
                $"Totaalprijs: {TotaalPrijs()} euro";
        }
    }
}
