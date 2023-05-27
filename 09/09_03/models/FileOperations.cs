using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace models
{
    public class FileOperations
    {
        public static string BestandOnderdelen = "onderdelen.txt";

        /* Methode FilterGeheugen
         * Filter alle geheugen-objecten uit het txt-bestand.
         */
        public static List<Geheugen> FilterGeheugen()
        {
            List<Geheugen> memory = new List<Geheugen>();
            List<Onderdeel> onderdelen = LeesOnderdelen();

            foreach (Onderdeel onderdeel in onderdelen)
            {
                if (onderdeel.GetType().Name.ToLower() == "geheugen")
                {
                    memory.Add((Geheugen)onderdeel);
                }
            }
            return memory;
        }

        /* Methode FilterMoederborden
         * Filter alle moederbord-objecten uit het txt-bestand.
         */
        public static List<Moederbord> FilterMoederborden()
        {
            List<Moederbord> motherboard = new List<Moederbord>();
            List<Onderdeel> onderdelen = LeesOnderdelen();

            foreach (Onderdeel onderdeel in onderdelen)
            {
                if (onderdeel.GetType().Name.ToLower() == "moederbord")
                {
                    motherboard.Add((Moederbord)onderdeel);
                }
            }
            return motherboard;
        }

        /* Methode FilterProcessoren
         * Filter alle processor-objecten uit het txt-bestand.
         */
        public static List<Processor> FilterProcessor()
        {
            List<Processor> processoren = new List<Processor>();
            List<Onderdeel> onderdelen = LeesOnderdelen();

            foreach (Onderdeel onderdeel in onderdelen)
            {
                if (onderdeel.GetType().Name.ToLower() == "processor")
                {
                    processoren.Add((Processor)onderdeel);
                }
            }
            return processoren;
        }

        /* Methode LeesOnderdelen
         * Lees alle onderdelen uit het txt-bestand.
         */
        public static List<Onderdeel> LeesOnderdelen()
        {
            List<Onderdeel> onderdelen = new List<Onderdeel>();

            using StreamReader reader = new StreamReader(BestandOnderdelen);
            {
                while (!reader.EndOfStream)
                {
                    Onderdeel onderdeel = null;

                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    string typeOnderdeel = data[0];
                    if (typeOnderdeel.ToLower() == "geheugen")
                    {
                        string type = data[1];
                        int.TryParse(data[2], out int geheugentype);
                        double.TryParse(data[3], out double prijs);
                        onderdeel = new Geheugen(type, geheugentype, prijs);
                    }
                    else if (typeOnderdeel.ToLower() == "moederbord")
                    {
                        string socket = data[1];
                        string chipset = data[2];
                        string formFactor = data[3];
                        string geheugenType = data[4];
                        double.TryParse(data[5], out double prijs);
                        onderdeel = new Moederbord(socket, chipset, formFactor, geheugenType, prijs);
                    }
                    else if (typeOnderdeel.ToLower() == "processor")
                    {
                        string merk = data[1];
                        string socket = data[2];
                        int.TryParse(data[3], out int aantalCores);
                        int.TryParse(data[4], out int aantalThreads);
                        double.TryParse(data[5], out double klokFrequentie);
                        double.TryParse(data[6], out double prijs);
                        onderdeel = new Processor(merk, socket, aantalCores, aantalThreads, klokFrequentie, prijs);
                    }

                    if (!onderdelen.Contains(onderdeel) && onderdeel != null)
                        onderdelen.Add(onderdeel);
                }
            }
            return onderdelen;
        }
    }
}
