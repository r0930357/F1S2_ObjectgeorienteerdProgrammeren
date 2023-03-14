using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Rekening
    {
        /* Rekening
         * --------------------------------------------
         * +IbanNummer : string
         * +LandCode : string
         * +Minimum : double
         * +Saldo : double
         * --------------------------------------------
         * +Rekening(ibanNummer: string, saldo: double)
         * +Afhalen(bedrag: double) : void
         * +Storten(bedrag: double) : void
         * +ToonGegevens() : string
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

        public Rekening(string ibanNummer, double saldo)
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
    }
}
