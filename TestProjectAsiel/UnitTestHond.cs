using System;
using Asiel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asiel.Dieren;

namespace TestProjectAsiel
{
    [TestClass]
    public class UnitTestHond
    {
        private Hond hond;

        [TestInitialize]
        public void TestMethod1()
        {
            this.hond = new Hond("Hondje", Dier.Geslacht.Man);
        }

        [TestMethod]
        public void TestHondConstructor()
        {
            Assert.AreEqual("Hondje", this.hond.naam);
            Assert.AreEqual(Dier.Geslacht.Man, this.hond.GeslachtSet);
            Assert.AreEqual(default(DateTime), this.hond.LaatstUitgelaten);
        }
    }
}