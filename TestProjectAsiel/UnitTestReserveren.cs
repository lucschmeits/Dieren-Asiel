using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Asiel.Dieren;
using Asiel;

namespace TestProjectAsiel
{
    [TestClass]
    public class UnitTestReserveren
    {
        private Reservering reservering;
        private Persoon persoon;
        private Dier dier;

        [TestInitialize]
        public void TestMethod1()
        {
            this.persoon = new Persoon("Kees", "Achternaam", "Stategaard 43", "6227 GL", "Maastricht", "0612345678");
            // this.dier = new Hond("Hondje", Dier.Geslacht.Man);
            this.reservering = new Reservering(persoon, dier, DateTime.Today);
            this.reservering.isOpgehaald = true;
        }

        [TestMethod]
        public void TestReserveringHond()
        {
            Assert.AreEqual("Kees", reservering.persoon.naam);
            Assert.IsNotNull(reservering.dier);
            Assert.IsTrue(this.persoon.naam == "Kees");
            Assert.IsNotNull(this.reservering.persoon);
            Assert.IsTrue(reservering.isOpgehaald);
        }

        [TestMethod]
        public void TestReserveringCat()
        {
            // this.reservering = new Reservering(new Persoon("Kees", "Achternaam", "Stategaard 43", "6227 GL", "Maastricht", "0612345678"), new Kat("Katje", Dier.Geslacht.Vrouw), DateTime.Today);
            Assert.IsNotNull(reservering.persoon);
            Assert.IsFalse(reservering.isOpgehaald);
            Assert.AreEqual("Katje", reservering.dier.naam);
        }
    }
}