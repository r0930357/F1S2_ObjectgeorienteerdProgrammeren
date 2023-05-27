using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Auto
    {
        /* Auto
         * --------------------------------------------------------
         * +Chassisnummer : string
         * +Merk : string
         * +Motor : Motor
         * --------------------------------------------------------
         * +Auto(chassisnummer: string, merk: string, motor: Motor)
         * +ToString() : string
         * +Equals(obj: object) : bool
         * +GetHashCode() : int
         */

        private string _chassisnummer;
        private string _merk;
        private Motor _motor;

        public string Chassisnummer
        {
            get { return _chassisnummer; }
            set { _chassisnummer = value; }
        }
        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }
        public Motor Motor
        {
            get { return _motor; }
            set { _motor = value; }
        }

        public Auto(string chassisnummer, string merk, Motor motor)
        {
            Chassisnummer = chassisnummer;
            Merk = merk;
            Motor = motor;
        }

        /* Geeft de tekstuele voorstelling van het object als volgt
         * De <Merk> met chassisnummer <Chassisnummer> heeft volgende kenmerken:
         * <Motor>
         */
        public override string ToString()
        {
            return $"De {Merk} met chassisnummer {Chassisnummer} heeft de volgende kenmerken:\n" +
                $"{Motor.ToString()}";
        }

        /* Methode Equalsµ
         * Een auto is gelijk aan een andere auto als beide een van het type auto zijn alsook hetzelfde chassisnummer bevatten.
         */
        public override bool Equals(object obj)
        {
            if (obj is Auto auto)
                return Chassisnummer == auto.Chassisnummer;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Chassisnummer);
        }
    }
}
