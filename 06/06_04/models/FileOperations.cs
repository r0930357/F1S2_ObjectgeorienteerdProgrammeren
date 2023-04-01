using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace models
{
    public class FileOperations
    {
        /* «static»
         * FileOperations
         * ------------------------------------------------
         * +string BestandSiropen
         * +string BestandToppings
         * +string BestandGlazuren
         * +string BestandVullingen
         * +string BestandSmaken
         * ------------------------------------------------
         * +LeesOpties(bestandsnaam: string) : List<string>
         */

        public static string BestandSiropen = "siropen.txt";
        public static string BestandToppings = "toppings.txt";
        public static string BestandGlazuren = "glazuren.txt";
        public static string BestandVullingen = "vullingen.txt";
        public static string BestandSmaken = "smaken.txt";

        // Deze methode zal alle opties van het meegestuurde bestand uitlezen en returnen als één lijst met strings.
        public static List<string> LeesOpties(string bestandsnaam)
        {
            // Lege lijst aanmaken
            List<string> record = new List<string>();
            
            // Eerste record van de lijst = 0. Geen
            record.Insert(0, "Geen");
            {
                if (File.Exists(bestandsnaam))
                {
                    using StreamReader reader = new StreamReader(bestandsnaam);
                    while (!reader.EndOfStream)
                    {
                        string lijn = reader.ReadLine();
                        record.Add(lijn);
                    }
                }
                else
                {
                    Console.WriteLine("Bestand niet gevonden!");
                }
                return record;
            }
        }
    }
}