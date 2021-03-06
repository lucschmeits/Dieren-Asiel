﻿using System;
using Asiel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace TestProjectAsiel
{
    [TestClass]
    public class UnitTestHond
    {
        private Hond hond;

        [TestInitialize]
        public void TestMethod1()
        {
            this.hond = new Hond();
            hond.naam = "Hondje";
            hond.GeslachtSet = Dier.Geslacht.Man;
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