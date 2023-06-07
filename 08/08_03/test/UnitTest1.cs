using models;
using NUnit.Framework;
using System;
using System.Reflection;
using System.Runtime;

namespace test
{
    [TestFixture]
    public class TamagochiTests
    {

        /* Unit tests
         * 
         * Maak de nodige test-methodes om de property GoedGevoel te testen.
         * Maak de nodige test-methodes om de property Honger te testen.
         * Maak de nodige test-methodes om de property LaatsteMaaltijd te testen.
         * Maak de nodige test-methodes om de naam te testen.
         * Maak de nodige test-methodes om de constructors te testen.
         * Maak de nodige test-methodes om de methode Eten te testen.
         * Maak de nodige test-methodes om de methode Liefkozen te testen.
         * Maak de nodige test-methodes om de methode Straffen te testen.
         * Maak de nodige test-methodes om de methode Gevoel te testen.
         */

        [Test]
        public void Tamagochi_GoedGevoel_Overschrijd_MinimumWaarde()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.GoedGevoel = -11;

            // Assert
            Assert.That(tamagotchi.GoedGevoel, Is.EqualTo(-10));
        }

        [Test]
        public void Tamagochi_GoedGevoel_Overschrijd_MaximumWaarde()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.GoedGevoel = 11;

            // Assert
            Assert.That(tamagotchi.GoedGevoel, Is.EqualTo(10));
        }

        [Test]
        public void Tamagochi_Honger_Overschrijd_MinimumWaarde()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.Honger = -6;

            // Assert
            Assert.That(tamagotchi.Honger, Is.EqualTo(-5));
        }

        [Test]
        public void Tamagochi_Honger_Overschrijd_MaximumWaarde()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.Honger = 21;

            // Assert
            Assert.That(tamagotchi.Honger, Is.EqualTo(20));
        }

        [Test]
        public void Tamagochi_Controle_LaatsteMaaltijd()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            DateTime nu = DateTime.Now;
            tamagotchi.LaatsteMaaltijd = nu;

            // Assert
            Assert.That(tamagotchi.LaatsteMaaltijd, Is.EqualTo(nu));
        }

        [Test]
        public void Tamagochi_Controle_Naam()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.Naam = "Joshi";

            // Assert
            Assert.That(tamagotchi.Naam, Is.EqualTo("Joshi"));
        }

        [Test]
        public void Tamagochi_Constructor_Tamagochi_Naam_Minimumwaarde_Honger_Minimumwaarde_GoedGevoel()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.Naam = "Joshi";
            tamagotchi.Honger = -6;
            tamagotchi.GoedGevoel = -11;

            // Assert
            Assert.That(tamagotchi.Naam, Is.EqualTo("Joshi"));
            Assert.That(tamagotchi.Honger, Is.EqualTo(-5));
            Assert.That(tamagotchi.GoedGevoel, Is.EqualTo(-10));
        }

        [Test]
        public void Tamagochi_Constructor_Tamagochi_Naam_Maximum_Honger_Maximum_GoedGevoel()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.Naam = "Joshi";
            tamagotchi.Honger = 21;
            tamagotchi.GoedGevoel = 11;

            // Assert
            Assert.That(tamagotchi.Naam, Is.EqualTo("Joshi"));
            Assert.That(tamagotchi.Honger, Is.EqualTo(20));
            Assert.That(tamagotchi.GoedGevoel, Is.EqualTo(10));
        }

        [Test]
        public void Tamagochi_Methode_Eten()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
           tamagotchi.Eten(4);

            // Assert
            Assert.That(tamagotchi.Honger, Is.EqualTo(3));
        }

        [Test]
        public void Tamagochi_Methode_Liefkozen()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.Liefkozen();

            // Assert
            Assert.That(tamagotchi.GoedGevoel, Is.EqualTo(1));
        }

        [Test]
        public void Tamagochi_Methode_Straffen()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            tamagotchi.Straffen(1);

            // Assert
            Assert.That(tamagotchi.GoedGevoel, Is.EqualTo(-1));
        }

        [Test]
        public void Tamagochi_Methode_Gevoel()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("", 0, 0);

            // Act
            DateTime nu = DateTime.Now;
            tamagotchi.Naam = "Joshi";
            tamagotchi.Honger = 21;
            tamagotchi.GoedGevoel = 11;
            tamagotchi.LaatsteMaaltijd = nu;

            // Assert
            Assert.That(tamagotchi.Naam, Is.EqualTo("Joshi"));
            Assert.That(tamagotchi.Honger, Is.EqualTo(20));
            Assert.That(tamagotchi.GoedGevoel, Is.EqualTo(10));
            Assert.That(tamagotchi.LaatsteMaaltijd, Is.EqualTo(nu));
        }
    } 
}