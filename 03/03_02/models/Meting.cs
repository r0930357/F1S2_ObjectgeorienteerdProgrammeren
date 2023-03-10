using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace models
{
    public class Meting
    {
        /* Meting
         * ----------------------------------------------------------------------------
         * +Tijdstip : DateTime
         * +GradenFahrenheit : double
         * +GradenCelsius : double
         * ----------------------------------------------------------------------------
         * +Meting(gradenCelsius: double)
         * +Meting(tijdstip: DateTime, gradenCelsius: double)
         * +Meting(tijdstip: DateTime, gradenFahrenheit: double, gradenCelsius: double)
         * +ToonGegevens() : string
         */

        public DateTime _tijdstip = new DateTime();
        public double _gradenFahrenheit;
        public double _gradenCelsius;

        public DateTime Tijdstip
        {
            get { return _tijdstip; }
            set { _tijdstip = value; }
        }

        public double GradenFahrenheit
        {
            get { return _gradenFahrenheit; }
            set { _gradenFahrenheit = value; }
        }

        public double GradenCelsius
        {
            get { return _gradenCelsius; }
            set { _gradenCelsius = value; }
        }
        // Voorzie 3 constructors waarbij men de juiste gebruikt aan de hand van de beschikbare gegevens.
        public Meting(DateTime tijdstip, double gradenFahrenheit, double gradenCelsius)
        {
            Tijdstip = tijdstip;
            GradenFahrenheit = gradenFahrenheit;
            GradenCelsius = gradenCelsius;
        }

        public Meting(DateTime tijdstip, double gradenCelsius) : this(tijdstip, TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius), gradenCelsius) { }

        public Meting(double gradenCelsius) : this(DateTime.Now, TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius), gradenCelsius) { }

        public string ToonGegevens()
        {
            // string status = $"Meting\n------\nOp {Datum} werd er {GradenCelcius} graden Celcius en {GradenFahrenheit} graden Farenheit gemeten.";
            // Gevraagde string om de slagen in CodeGrade:
            string status = $"{GradenCelsius} graden Celsius en {GradenFahrenheit} graden Fahrenheit";
            return status ;
        }
    }
}
