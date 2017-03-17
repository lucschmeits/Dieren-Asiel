using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectAsiel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
            public void TestInitialize() { this.cat = new Cat("Ms. Meow", Gender.Female, "Scratches couch"); }
       

        [TestMethod]
        public void TestCatConstructor()
        {
            Assert.AreEqual();
        }
    }
}
