using models;
using System;
using System.Threading;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaratie van de variabelen
            int keuzeRekening, keuzeMenu;
            string invoer = "", weergave = "";
            double bedrag = 0;

            // Initialiseren van de objecten;
            Bankrekening bankrekening = new Bankrekening("BE12 3456 7890 1234", 1000);
            Zichtrekening zichtrekening;
            Spaarrekening spaarrekening;

            Console.WriteLine("1. Spaarrekening\n" +
                              "2. Zichtrekening");

            keuzeRekening = MenuKeuze(invoer, 0, 2);

            switch (keuzeRekening)
            {
                case 1:
                    // Spaarrekening
                    spaarrekening = new Spaarrekening(bankrekening.IbanNummer, bankrekening.Saldo);
                    Console.WriteLine("1. Afhalen\n" +
                        "2. Storten\n" +
                        "3. Schrijf rente bij\n" +
                        "4. Informatie");

                    keuzeMenu = MenuKeuze(invoer, 0, 4);

                    while (keuzeMenu != 4)
                    {
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
                                Console.Write("Welk bedrag wil u afhalen?: ");
                                bedrag = double.Parse(Console.ReadLine());
                                if (bedrag <= 0)
                                {
                                    Console.WriteLine("Het af te halen bedrag moet groter zijn dan 0");
                                }
                                else if (spaarrekening.Saldo < spaarrekening.Minimum)
                                {
                                    Console.WriteLine("Je hebt niet genoeg saldo om deze opdracht te verwerken...");
                                }
                                else
                                {
                                    spaarrekening.Afhalen(bedrag);
                                }
                                break;
                            case 2:
                                /* Optie Storten
                                 * Vraag hoeveel de gebruiker wil storten.
                                 * Als het bedrag kleiner of gelijk is aan 0, tonen we: "Het te storten bedrag moet groter zijn dan 0"
                                 * Als bovenstaande creteria niet het geval zijn, storten we het bedrag bij ons saldo.
                                 */
                                Console.Write("Welk bedrag wil u storten?: ");
                                bedrag = double.Parse(Console.ReadLine());
                                if (bedrag <= 0)
                                {
                                    Console.WriteLine("Het te storten bedrag moet groter zijn dan 0");
                                }
                                else
                                {
                                    spaarrekening.Storten(bedrag);
                                }
                                Console.WriteLine(spaarrekening.ToString());
                                break;
                            case 3:
                                /* Optie Schrijf rente bij
                                 */
                                spaarrekening.SchrijfRentebij();
                                Console.WriteLine(spaarrekening.ToString());
                                break;
                            case 4:
                                /* Optie Informatie
                                 * Toon een tekstuele waarde van de rekening.
                                 * Gebruik hiervoor de ToString() methode.
                                 * De applicatie sluit af na deze operatie.
                                 */
                                Console.Write(spaarrekening.ToString());
                                break;
                        }

                        // Spaarrekening
                        spaarrekening = new Spaarrekening(bankrekening.IbanNummer, bankrekening.Saldo);
                        Console.WriteLine("1. Afhalen\n" +
                            "2. Storten\n" +
                            "3. Schrijf rente bij\n" +
                            "4. Informatie");

                        keuzeMenu = MenuKeuze(invoer, 0, 4);
                    }

                    Console.Write(spaarrekening.ToString());

                    break;

                case 2:
                    // Zichtrekening
                    zichtrekening = new Zichtrekening(bankrekening.IbanNummer, bankrekening.Saldo);
                    Console.WriteLine("1. Afhalen\n" +
                        "2. Storten\n" +
                        "3. Schrijf rente bij\n" +
                        "4. Informatie");

                    keuzeMenu = MenuKeuze(invoer, 0, 4);

                    while (keuzeMenu != 4)
                    {
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
                                Console.Write("Welk bedrag wil u afhalen?: ");
                                bedrag = double.Parse(Console.ReadLine());
                                if (bedrag <= 0)
                                {
                                    Console.WriteLine("Het af te halen bedrag moet groter zijn dan 0");
                                }
                                else if (zichtrekening.Saldo < zichtrekening.Minimum)
                                {
                                    Console.WriteLine("Je hebt niet genoeg saldo om deze opdracht te verwerken...");
                                }
                                else
                                {
                                    zichtrekening.Afhalen(bedrag);
                                }
                                break;
                            case 2:
                                /* Optie Storten
                                 * Vraag hoeveel de gebruiker wil storten.
                                 * Als het bedrag kleiner of gelijk is aan 0, tonen we: "Het te storten bedrag moet groter zijn dan 0"
                                 * Als bovenstaande creteria niet het geval zijn, storten we het bedrag bij ons saldo.
                                 */
                                Console.Write("Welk bedrag wil u storten?: ");
                                bedrag = double.Parse(Console.ReadLine());
                                if (bedrag <= 0)
                                {
                                    Console.WriteLine("Het te storten bedrag moet groter zijn dan 0");
                                }
                                else
                                {
                                    zichtrekening.Storten(bedrag);
                                }
                                break;
                            case 3:
                                /* Optie Schrijf rente bij
                                 * Rente bijschrijven kan alleen als de rekening van het type Spaarrekening is.
                                 * Is dat niet het geval dan tonen we: "Deze optie is alleen beschikbaar bij een spaarrekening..."
                                 */
                                Console.WriteLine("Deze optie is alleen beschikbaar bij een spaarrekening...");
                                break;
                            case 4:
                                /* Optie Informatie
                                 * Toon een tekstuele waarde van de rekening.
                                 * Gebruik hiervoor de ToString() methode.
                                 * De applicatie sluit af na deze operatie.
                                 */
                                Console.Write(zichtrekening.ToString());
                                break;
                        }
                     
                        // Zichtrekening
                        zichtrekening = new Zichtrekening(bankrekening.IbanNummer, bankrekening.Saldo);
                        Console.WriteLine("1. Afhalen\n" +
                            "2. Storten\n" +
                            "3. Schrijf rente bij\n" +
                            "4. Informatie");

                        keuzeMenu = MenuKeuze(invoer, 0, 4);
                    }
                    Console.Write(zichtrekening.ToString());
                    
                    break;
            }
        }

        // Methodes
        private static int MenuKeuze(string invoer, int min, int max)
        {
            int keuze;
            do
            {
                Console.Write("Maak uw keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < min || keuze > max);
            return keuze;
        }
    }
}
