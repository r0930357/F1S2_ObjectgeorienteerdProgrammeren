using models;
using NUnit.Framework;
using System;

namespace test
{
    [TestFixture]
    public class VierkantTests
    {
        /* Unit tests
         * 
         * Maak de nodige test-methodes om de property Zijde te testen.
         * Maak de nodige test-methodes om de constructors te testen.
         * Maak de nodige test-methodes om de methode Diagonaal te testen.
         * Maak de nodige test-methodes om de methode Omtrek te testen.
         * Maak de nodige test-methodes om de methode Oppervlakte te testen.
         * Maak de nodige test-methodes om de methode Teken te testen.
         */

        [Test]
        public void Zijde_ValueIsKleinerDanNul_NummerGelijkAanValue()
        {
            // Arrange
            Vierkant vierkant = new Vierkant();

            // Act
            vierkant.Zijde = -1;

            // Assert
            Assert.AreEqual(vierkant.Zijde, 0);
        }

        [Test]
        public void Zijde_ValueIsGroterDan25_NummerGelijkAanValue()
        {
            // Arrange
            Vierkant vierkant = new Vierkant();

            // Act
            vierkant.Zijde = 26;

            // Assert
            Assert.AreEqual(vierkant.Zijde, 25);
        }

        [Test]
        public void Diagonaal()
        {
            /* Methode Diagonaal
             * De Lengte van de diagonaal wordt als volgt berekend: vierkantswortel(2) * <Zijde>.
             */

            // Arrange
            Vierkant vierkant = new Vierkant();
            vierkant.Zijde = 1;

            // Act
            double diagonaal = vierkant.Diagonaal();

            // Assert
            Assert.IsTrue(diagonaal == 1.41);
        }

        [Test]
        public void Omtrek()
        {
            /* Methode Omtrek
             * De omtrek wordt als volgt berekend: 4 * <Zijde>
             */

            // Arrange
            Vierkant vierkant = new Vierkant();
            vierkant.Zijde = 1;

            // Act
            double omtrek = vierkant.Omtrek();

            // Assert
            Assert.IsTrue(omtrek == 4);
        }

        [Test]
        public void Oppervlakte()
        {
            /* Methode Oppervlakte
             * De oppervlakte wordt als volgt berekend: <Zijde> * <Zijde>
             */

            // Arrange
            Vierkant vierkant = new Vierkant();
            vierkant.Zijde = 2;

            // Act
            double oppervlakte = vierkant.Oppervlakte();

            // Assert
            Assert.IsTrue(oppervlakte == 4);
        }

        [Test]
        public void Teken()
        {
            /* Methode Teken
             * Deze methode maakt onder de vorm van een sterretjesmatrix een vierkant met de opgegeven zijde.
             */

            // Arrange
            Vierkant vierkant = new Vierkant();
            vierkant.Zijde = 2;

            // Act
            string teken = vierkant.Teken();

            // Assert
            Assert.AreEqual(teken, "* *\n* *\n");
        }
    }
}