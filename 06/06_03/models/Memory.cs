using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Memory
    {
        private int _waarde;
        private string _soort;
        private string _kleur;
    
        public int Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }

        public string Soort
        {
            get { return _soort; }
            set { _soort = value; }
        }

        public string Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }

        public Memory(int waarde, string soort, string kleur)
        {
            Waarde = waarde;
            Soort = soort;
            Kleur = kleur;
        }

        public override string ToString()
        {
            return $"{Waarde}, {Soort}, {Kleur}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Memory memory)
            {
                return this.Waarde == memory.Waarde &&
                    this.Soort == memory.Soort &&
                    this.Kleur == memory.Kleur;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
