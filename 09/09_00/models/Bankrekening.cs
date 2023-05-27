using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace models
{
    public class Bankrekening
    {
        /* Bankrekening
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
         * +ToString() : string
         */

        private string _ibanNummer;
        private string _landCode;
        private double _minimum;
        private double _saldo;

        public string IbanNummer
        {
            get { return _ibanNummer; }
            set { _ibanNummer = value; }
        }

        // De landcode geeft de eerste 2 karakters van het iban-nummer terug.
        public string LandCode
        {
            get { return _ibanNummer.Substring(0, 2); }
            set { _landCode = value; }
        }

        public virtual double Minimum
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
                if (value < Minimum)
                {
                    throw new SaldoOnderNulException("Saldo mag niet kleiner zijn dan het minimum");
                    //_saldo = Minimum;
                }
                else
                {
                    _saldo = value;
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
            Saldo -= bedrag;
        }

        public void Storten(double bedrag)
        {
            Saldo += bedrag;
        }

        public virtual string ToonGegevens()
        {
            return $"Rekening {IbanNummer} met saldo {Saldo}";
        }

        // Geeft de tekstuele voorstelling van het object als volgt:
        // <IbanNummer> -> Je huidig saldo bedraagt: <Saldo> euro.
        public override string ToString()
        {
            return $"{IbanNummer} -> Je huidig saldo bedraagt: {Saldo} euro.";
        }
    }
}
