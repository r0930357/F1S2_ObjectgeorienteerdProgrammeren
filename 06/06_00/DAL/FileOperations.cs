using models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAL
{
    public static class FileOperations
    {
        /* <<static>>
         * FileOperations
         * -----------------------------------------
         * +BestandStudenten : string
         * -----------------------------------------
         * +LeesStudenten() : List<ResultaatStudent>
         */

        public static string BestandStudenten = "StudentEnPunt.txt";

        public static List<ResultaatStudent> LeesStudenten()
        {
            List<ResultaatStudent> studenten = new List<ResultaatStudent>();
            
            using (StreamReader reader = new StreamReader(BestandStudenten))
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    string naam = data[0];
                    double.TryParse(data[1], out double grade );

                    ResultaatStudent student = new ResultaatStudent(naam, grade);
                    studenten.Add(student);
                }
            }
            
            return studenten;
        }
    }
}
