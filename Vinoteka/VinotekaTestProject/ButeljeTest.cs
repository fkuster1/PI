using WindowsFormsApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VinotekaTestProject
{
    
    
    /// <summary>
    ///This is a test class for ButeljeTest and is intended
    ///to contain all ButeljeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ButeljeTest
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
        ///A test for Zapremnina
        ///</summary>
        [TestMethod()]
        public void ZapremninaTest()
        {
            Butelje target = new Butelje(); // TODO: Initialize to an appropriate value
            float expected = -1; // TODO: Initialize to an appropriate value
            float actual;
            target.Zapremnina = expected;
            actual = target.Zapremnina;
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(target.Zapremnina >= 0, "Zapremnina ne može biti negativna!");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SadrziVino
        ///</summary>
        [TestMethod()]
        public void SadrziVinoTest()
        {
            Butelje target = new Butelje(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.SadrziVino = expected;
            actual = target.SadrziVino;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BrojButelji
        ///</summary>
        [TestMethod()]
        public void BrojButeljiTest()
        {
            Butelje target = new Butelje(); // TODO: Initialize to an appropriate value
            int expected = -1; // TODO: Initialize to an appropriate value
            int actual;
            target.BrojButelji = expected;
            actual = target.BrojButelji;
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(target.BrojButelji >= 0, "Broj butelji ne može biti negativan!");
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UnesiPodrum
        ///</summary>
        [TestMethod()]
        public void UnesiPodrumTest()
        {
            Butelje target = new Butelje(); // TODO: Initialize to an appropriate value
            target.UnesiPodrum();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Butelje Constructor
        ///</summary>
        [TestMethod()]
        public void ButeljeConstructorTest()
        {
            Butelje target = new Butelje();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
