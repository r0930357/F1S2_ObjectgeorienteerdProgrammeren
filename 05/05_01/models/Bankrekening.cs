using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Bankrekening
    {
        /* Bankrekening
         * ------------------------------------------------
         * +IbanNummer : string
         * +LandCode : string
         * +Minimum : double
         * +Saldo : double
         * ------------------------------------------------
         * +Bankrekening(ibanNummer: string, saldo: double)
         * +Afhalen(bedrag: double) : void
         * +Storten(bedrag: double) : void
         * +ToonGegevens() : string
         * +ToString() : string
         */

        public string _ibanNummer;
        public string _landCode;
        public double _minimum;
        public double _saldo;

        public string IbanNummer
        {
            get { return _ibanNummer; }
            set { _ibanNummer = value; }
        }

        public string LandCode
        {
            get { return LandCode; }
            set { LandCode = value; }
        }

        public double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        /* Het saldo mag niet onder minimum komen.
         * Bij foutieve waarde wordt het saldo op het minimum ingesteld.
         */
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = Minimum;
                }
            }
        }

        public Bankrekening(string ibanNummer, double saldo)
        {
            IbanNummer = ibanNummer;
            Saldo = saldo;
        }

        public void Afhalen(double bedrag)
        {

        }

        public void Storten(double bedrag)
        {

        }

        public virtual string ToonGegevens()
        {
            string gegevens = "";
            return gegevens;
        }

        /* Methode ToString()
         * Geeft de tekstuele voorstelling van het object als volgt:
         * <IbanNummer> -> Je huidig saldo bedraagt: <Saldo> euro.
         */
        public virtual string ToString()
        {
            return $"{this.IbanNummer} -> Je huidig saldo bedraagt: {this.Saldo} euro.";
        }

    }
}
