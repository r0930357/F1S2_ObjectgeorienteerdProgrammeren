using models;
using System;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            List<TvKanaal> kanaallijst = new List<TvKanaal>();
            
            // Declaratie van variabelen
            string invoer;
            int kanaalNummer = 0;

            // Object "TvKanaal" opvullen met de kanaallijst
            TvKanaal een = new TvKanaal(1, "Een");
            TvKanaal canvas = new TvKanaal(2, "Canvas");
            TvKanaal vtm = new TvKanaal(3, "VTM");
            TvKanaal tobe = new TvKanaal(4, "2BE");
            TvKanaal vier = new TvKanaal(5, "Vier");

            // Toevoegen van de kanalen in de kanaallijst
            kanaallijst.Add(een);
            kanaallijst.Add(canvas);
            kanaallijst.Add(vtm);
            kanaallijst.Add(tobe);
            kanaallijst.Add(vier);

            // Kanaallijst weergeven aan de hand van de omschrijving
            foreach (TvKanaal kanaal in kanaallijst)
            {
                Console.WriteLine(kanaal.Omschrijving);
            }

            // Kanaal opvragen in de console
            invoer = KeuzeMenu();

            // Kanaal opzoeken aan de hand van het ingevoerde nummer
            foreach (TvKanaal kanaal in kanaallijst)
            {
                if (kanaal.Omschrijving.ToLower() == invoer)
                {
                    kanaalNummer = kanaal.Nummer;
                }
            }

            // Kanaalnummer weergeven in de console
            Console.WriteLine($"Nummer van het kanaal is {kanaalNummer}");
        }

        private static string KeuzeMenu()
        {
            string invoer;
            do
            {
                Console.Write("\nVan welk kanaal wil je het nummer tonen? ");
                invoer = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(invoer));
            return invoer.ToLower();
        }
    }
}
