using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace models
{
    public class Persoon
    {
        private string _voornaam;
        private string _familienaam;
        private string _email;

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Persoon(string voornaam, string familienaam, string email)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Voornaam} {Familienaam} ({Email})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Persoon persoon)
            {
                return this.Voornaam == persoon.Voornaam && this.Familienaam == persoon.Familienaam && this.Email == persoon.Email;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Voornaam, Familienaam, Email);
        }
    }
}
