using System;
using Asiel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Asiel.Dieren;

namespace TestProjectAsiel
{
    [TestClass]
    public class UnitTestKat
    {
        private Kat kat;

        [TestInitialize]
        public void TestMethod1()
        {
            //  this.kat = new Kat("katje", Dier.Geslacht.Man);
            // kat.Info = "Hallo";
        }

        [TestMethod]
        public void TestKatConstructor()
        {
            Assert.AreEqual("katje", this.kat.naam);
            Assert.AreEqual(Dier.Geslacht.Man, this.kat.GeslachtSet);
            Assert.IsNull(this.kat.Info);
        }
    }
}