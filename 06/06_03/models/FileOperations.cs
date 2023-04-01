using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Text;

namespace models
{
    public class FileOperations
    {
        public static List<Memory> LeesBestand(string bestandsnaam)
        {
            List<Memory> spel = new List<Memory>();

            if (File.Exists(bestandsnaam))
            {
                using StreamReader reader = new StreamReader(bestandsnaam);
                while (!reader .EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    int.TryParse(data[0], out int waarde);
                    string soort = data[1];
                    string kleur = data[2];
                    Memory item = new Memory(waarde, data[1], data[2]);
                    spel.Add(item);
                }
            }
            else
            {
                Console.WriteLine("Bestand niet gevonden!");
            }
            return spel;
        }

    }
}
