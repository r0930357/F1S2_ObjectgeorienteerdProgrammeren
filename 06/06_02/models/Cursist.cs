using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Cursist
    {
        /* Cursist
         * ---------------------------------------------------------------
         * +CursistID : int
         * +Voornaam : string
         * +Familienaam : string
         * +Naam : string
         * ---------------------------------------------------------------
         * +Cursist(cursistId: int, voornaam: string, familienaam: string)
         * +ToString() : string
         * +Equals(obj: object) : bool
        */

        private int _cursistID;
        private string _voornaam;
        private string _familienaam;
        private string _naam;

        public int CursistID
        {
            get { return _cursistID; }
            set { _cursistID = value; }
        }

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

        public string Naam
        {
            get { return $"{Voornaam} {Familienaam}"; }
        }

        public Cursist(int cursistId, string voornaam, string familienaam) 
        {
            CursistID = cursistId;
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
        public override string ToString()
        {
            return $"{CursistID}. {Naam}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) ;
        }
    }
}
