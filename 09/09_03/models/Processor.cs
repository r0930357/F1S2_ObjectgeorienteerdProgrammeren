using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Processor : Onderdeel
    {
        /* Processor
         * ---------------------------------------------------------------------------------------------------------------------
         * +Merk : string
         * +Socket : string
         * +AantalCores : int
         * +AantalThreads : int
         * +KlokFrequentie : double
         * ---------------------------------------------------------------------------------------------------------------------
         * +Processor(merk: string, socket: string, aantalCores: int, aantalThreads: int, klokFrequentie: double, prijs: double)
         * +ToString() : string
         */

        private string _merk;
        private string _socket;
        private int _aantalCores;
        private int _aantalThreads;
        private double _klokFrequentie;

        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }

        public string Socket
        {
            get { return _socket; }
            set { _socket = value; }
        }

        public int AantalCores
        {
            get { return _aantalCores; }
            set { _aantalCores = value; }
        }

        public int AantalThreads
        {
            get { return _aantalThreads; }
            set { _aantalThreads = value; }
        }

        public double KlokFrequentie
        {
            get { return _klokFrequentie; }
            set { _klokFrequentie = value; }
        }

        public Processor(string merk, string socket, int aantalCores, int aantalThreads, double klokFrequentie, double prijs) : base(prijs)
        {
            Merk = merk;
            Socket = socket;
            AantalCores = aantalCores;
            AantalThreads = aantalThreads;
            KlokFrequentie = klokFrequentie;
        }

        /* Methode ToString
         * Geeft een tekstuele voorstelling van het object als volgt:
         * Processor: Merk <Merk> - Socket <Socket> - <AantalCores> cores - <AantalThreads> threads - <KlokFrequentie> MHz
         */
        public override string ToString()
        {
            return $"Merk <{Merk}> - Socket <{Socket}> - <{AantalCores}> cores - <{AantalThreads}> threads - <{KlokFrequentie}> MHz";
        }
    }
}
