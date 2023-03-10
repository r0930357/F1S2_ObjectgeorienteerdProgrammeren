using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class TemperatuurConversies
    {

        /* «static»
         * TemperatuurConversies
         * --------------------------------------------------------------
         * +ConverteerNaarGradenCelsius(double gradenFahrenheit) : double
         * +ConverteerNaarGradenFahrenheit(double gradenCelsius) : double
         */

        /* Voorzie een methode die graden Celsius berekenen aan de hand van de meegegeven graden Fahrenheit.
         * De formule hiervoor is: (<gradenFahrenheit> - 32) * 5 / 9.
         */
        public static double ConverteerNaarGradenCelsius(double grandenFarenheit)
        {
            double converteerNaarGradenCelcius;
            converteerNaarGradenCelcius = (grandenFarenheit - 32) * 5 / 9;
            return Math.Round(converteerNaarGradenCelcius, 2);
        }

        /* Voorzie een methode die graden Fahrenheit berekenen aan de hand van de meegegeven graden Celsius.
         * De formule hiervoor is: (<gradenCelsius> x 9 / 5) + 32.
         */
        public static double ConverteerNaarGradenFahrenheit(double grandenCelcius)
        {
            double converteerNaarGradenFarenheit;
            converteerNaarGradenFarenheit = (grandenCelcius * 9 / 5) + 32;
            return Math.Round(converteerNaarGradenFarenheit, 2);
        }
    }
}
