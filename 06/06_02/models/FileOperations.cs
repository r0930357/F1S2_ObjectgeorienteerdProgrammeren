using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace models
{
    public class FileOperations
    {
        /* «static»
         * FileOperations
         * --------------------------------
         * +CursistenBestand : string
         * --------------------------------
         * +LeesCursisten() : List<Cursist>
         */

        public static string CursistenBestand = "cursisten.txt";

        public static List<Cursist> LeesCursisten()
        {
            List<Cursist> cursisten = new List<Cursist>();

            using StreamReader reader = new StreamReader(CursistenBestand);
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    int.TryParse(data[0], out int nummer);
                    string voornaam = data[1];
                    string familienaam = data[2];
                    cursisten.Add (new Cursist(nummer, voornaam, familienaam));
                }
            }
            return cursisten;
        }
    }
}
