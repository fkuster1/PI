using WindowsFormsApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VinotekaTestProject
{
    
    
    /// <summary>
    ///This is a test class for BacveTest and is intended
    ///to contain all BacveTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BacveTest
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
        ///A test for Bacve Constructor
        ///</summary>
        [TestMethod()]
        public void BacveConstructorTest()
        {
            Bacve target = new Bacve();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for UnesiBacvu
        ///</summary>
        [TestMethod()]
        public void UnesiBacvuTest()
        {
            Bacve target = new Bacve(); // TODO: Initialize to an appropriate value
            target.UnesiBacvu();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DatumKupnje
        ///</summary>
        [TestMethod()]
        public void DatumKupnjeTest()
        {
            Bacve target = new Bacve(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.DatumKupnje = expected;
            actual = target.DatumKupnje;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Podrum
        ///</summary>
        [TestMethod()]
        public void PodrumTest()
        {
            Bacve target = new Bacve(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Podrum = expected;
            actual = target.Podrum;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Proizvodac
        ///</summary>
        [TestMethod()]
        public void ProizvodacTest()
        {
            Bacve target = new Bacve(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Proizvodac = expected;
            actual = target.Proizvodac;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Vrsta
        ///</summary>
        [TestMethod()]
        public void VrstaTest()
        {
            Bacve target = new Bacve(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Vrsta = expected;
            actual = target.Vrsta;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Zapremnina
        ///</summary>
        [TestMethod()]
        public void ZapremninaTest()
        {
            Bacve target = new Bacve(); // TODO: Initialize to an appropriate value
            int expected = -1; // TODO: Initialize to an appropriate value
            int actual;
            target.Zapremnina = expected;
            actual = target.Zapremnina;
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(target.Zapremnina >= 0, "Zapremnina ne može biti negativn!");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
