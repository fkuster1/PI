using WindowsFormsApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VinotekaTestProject
{
    
    
    /// <summary>
    ///This is a test class for PodrumTest and is intended
    ///to contain all PodrumTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PodrumTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Podrum Constructor
        ///</summary>
        [TestMethod()]
        public void PodrumConstructorTest()
        {
            Podrum target = new Podrum();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for UnesiPodrum
        ///</summary>
        [TestMethod()]
        public void UnesiPodrumTest()
        {
            Podrum target = new Podrum(); // TODO: Initialize to an appropriate value
            target.UnesiPodrum();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Adresa
        ///</summary>
        [TestMethod()]
        public void AdresaTest()
        {
            Podrum target = new Podrum(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Adresa = expected;
            actual = target.Adresa;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BrojMjesta
        ///</summary>
        [TestMethod()]
        public void BrojMjestaTest()
        {
            Podrum target = new Podrum(); // TODO: Initialize to an appropriate value
            int expected = -1; // TODO: Initialize to an appropriate value
            int actual;
            target.BrojMjesta = expected;
            actual = target.BrojMjesta;
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(target.BrojMjesta >= 0, "Broj mjesta ne može biti negativan!");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
