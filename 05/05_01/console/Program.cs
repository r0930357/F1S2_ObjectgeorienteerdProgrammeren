using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van de applicatie krijgt de gebruiker een menu met de volgende opties:
             * 
             * 1. Spaarrekening
             * 2. Zichtrekening
             * 
             * Afhankelijk van de keuze wordt er een respectievelijk object aangemaakt.
             */
            
            // Declaratie van de variabelen
            int keuzeRekening, keuzeMenu;
            string invoer;
            
            // Initialiseren van de objecten;

            Console.WriteLine("1. Spaarrekening\n" +
                "2. Zichtrekening");

            do
            {
                Console.WriteLine("Kies een optie");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuzeRekening) || keuzeRekening < 1 || keuzeRekening > 2);

            /* De gebruiker krijgt dan 4 opties:
             * 
             * 1. Afhalen
             * 2. Storten
             * 3. Schrijf rente bij
             * 4. Informatie
             */

            switch (keuzeRekening)
            {
                case 1:
                    // Zichtrekening

                    Zichtrekening zichtrekening = new Zichtrekening;

                    Console.WriteLine("1. Afhalen\n" +
                        "2. Storten\n" +
                        "3. Schrijf rente bij" +
                        "\nInformatie");

                    do
                    {
                        Console.WriteLine("Kies een optie");
                        invoer = Console.ReadLine();
                    } while (!int.TryParse(invoer, out keuzeMenu) || keuzeMenu < 1 || keuzeMenu > 4);

                    switch (keuzeMenu)
                    {
                        case 1:
                            /* Optie Afhalen
                             * Vraag hoeveel de gebruiker wil afhalen.
                             * Als het bedrag kleiner of gelijk is aan 0, tonen we: "Het af te halen bedrag moet groter zijn dan 0"
                             * Het saldo mag niet onder het minumum komen.
                             * Indien dit het geval zou zijn tonen we: "Je hebt niet genoeg saldo om deze opdracht te verwerken..."
                             * Als bovenstaande creteria niet het geval zijn, halen we het bedrag van ons saldo.
                             */

                            break;
                        case 2:
                            /* Optie Storten
                             * Vraag hoeveel de gebruiker wil storten.
                             * Als het bedrag kleiner of gelijk is aan 0, tonen we: "Het te storten bedrag moet groter zijn dan 0"
                             * Als bovenstaande creteria niet het geval zijn, storten we het bedrag bij ons saldo.
                             */

                            break;
                        case 3:
                            /* Optie Schrijf rente bij
                             * Rente bijschrijven kan alleen als de rekening van het type Spaarrekening is.
                             * Is dat niet het geval dan tonen we: "Deze optie is alleen beschikbaar bij een spaarrekening..."
                             */


                            break;
                        case 4:
                            /* Optie Informatie
                             * Toon een tekstuele waarde van de rekening.
                             * Gebruik hiervoor de ToString() methode.
                             * De applicatie sluit af na deze operatie.
                             */

                            break;
                    }
                    break;
                case 2:
                    // Spaarrekening

                    Spaarrekening spaarrekening = new Spaarrekening;

                    Console.WriteLine("1. Afhalen\n" +
                        "2. Storten\n" +
                        "3. Schrijf rente bij" +
                        "\nInformatie");

                    do
                    {
                        Console.WriteLine("Kies een optie");
                        invoer = Console.ReadLine();
                    } while (!int.TryParse(invoer, out keuzeMenu) || keuzeMenu < 1 || keuzeMenu > 4);

                    switch (keuzeMenu)
                    {
                        case 1:
                        /* Optie Afhalen
                         * Vraag hoeveel de gebruiker wil afhalen.
                         * Als het bedrag kleiner of gelijk is aan 0, tonen we: "Het af te halen bedrag moet groter zijn dan 0"
                         * Het saldo mag niet onder het minumum komen.
                         * Indien dit het geval zou zijn tonen we: "Je hebt niet genoeg saldo om deze opdracht te verwerken..."
                         * Als bovenstaande creteria niet het geval zijn, halen we het bedrag van ons saldo.
                         */

                        break;
                    case 2:
                        /* Optie Storten
                         * Vraag hoeveel de gebruiker wil storten.
                         * Als het bedrag kleiner of gelijk is aan 0, tonen we: "Het te storten bedrag moet groter zijn dan 0"
                         * Als bovenstaande creteria niet het geval zijn, storten we het bedrag bij ons saldo.
                         */

                        break;
                    case 3:
                        /* Optie Schrijf rente bij
                         */


                        break;
                    case 4:
                        /* Optie Informatie
                         * Toon een tekstuele waarde van de rekening.
                         * Gebruik hiervoor de ToString() methode.
                         * De applicatie sluit af na deze operatie.
                         */

                        break;
                    }
                 break;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
