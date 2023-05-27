using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace models
{
    public class Email
    {
        /* Email
         * --------------------
         * +Verzender: Persoon
         * +Ontvanger: Persoon
         */

        private Persoon _verzender;
        private Persoon _ontvanger;
        private string _titel;
        private string _bericht;

        public Persoon Verzender
        {
            get { return _verzender; }
            set { _verzender = value; }
        }

        public Persoon Ontvanger
        {
            get { return _ontvanger; }
            set { _ontvanger = value; }
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public string Bericht
        {
            get { return _bericht; }
            set { _bericht = value; }
        }

        public Email(Persoon verzender, Persoon ontvanger, string titel, string bericht)
        {
            Verzender = verzender;
            Ontvanger = ontvanger;
            Titel = titel;
            Bericht = bericht;
        }

        public override string ToString()
        {
            return $"Volgende email wordt verstuurd:\n" +
                $"Verzender: {Verzender}\n" +
                $"Ontvanger: {Ontvanger}\n" +
                $"Titel: {Titel}\n" +
                $"Bericht: {Bericht}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Email email)
            {
                return this.Verzender == email.Verzender && this.Ontvanger == email.Ontvanger &&
                    this.Titel == email.Titel && this.Bericht == email.Bericht;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Verzender, Ontvanger, Titel, Bericht);
        }
    }
}
