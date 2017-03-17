using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            this.dier = new Hond("Hondje", Dier.Geslacht.Man);
            this.reservering = new Reservering(persoon, dier, DateTime.Today);
        }

        [TestMethod]
        public void TestReserveringConstructor()
        {
            Assert.AreEqual("Kees", reservering.persoon.naam);
        }
    }
}
