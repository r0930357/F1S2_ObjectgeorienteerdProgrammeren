using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace models
{
    
    /* «static»
     * FileOperations
     * ----------------------------------
     * +string BestandStudenten
     * +string BestandScores
     * ----------------------------------
     * +StudentenLezen() : List<string>
     * +ScoresLezen() : List<int>
     * ----------------------------------
     */

    public static class FileOperations
    {
       /* Statische property BestandStudenten
        * Dit attribuut bevat de bestandsnaam waaruit de studenten kunnen uitgelezen worden. De waarde is "studenten.txt".
        * Voorzie dat dit bestand in je project is opgenomen.
        */

        public static string BestandStudenten = "studenten.txt";

       /* Statisch property BestandScores
        * Dit attribuut bevat de bestandsnaam waaruit de scores kunnen uitgelezen worden. De waarde is "scores.txt".
        * Voorzie dat dit bestand in je project is opgenomen.
        */

        public static string BestandScores = "scores.txt";

       /* Statische methode StudentenLezen
        * Deze methode zal de studenten uitlezen aan de hand van de bestandsnaam via het statische attriubuut BestandStudenten.
        */

        public static List<string> StudentenLezen()
        {
            List<string> studenten = new List<string>();
            using (StreamReader reader = new StreamReader(BestandStudenten))
            {
                while (!reader.EndOfStream)
                {
                    studenten.Add(reader.ReadLine());
                }
            }
            return studenten;
        }

       /* Statische methode ScoresLezen
        * Deze methode zal de scores uitlezen aan de hand van de bestandsnaam via het statische attriubuut BestandScores.
        */

        public static List<int> ScoresLezen()
        {
            // Variabelen om de invoer te controleren
            string invoer;
            int score;
            
            List<int> scores = new List<int>();
            using (StreamReader reader = new StreamReader(BestandScores))
            {
                while (!reader.EndOfStream)
                {
                    // De invoer kan enkel een integer zijn
                    invoer = reader.ReadLine();
                    if (int.TryParse(invoer, out score))
                    {
                        scores.Add(score);
                    }
                }
            }
            return scores;
        }
    }
} 
