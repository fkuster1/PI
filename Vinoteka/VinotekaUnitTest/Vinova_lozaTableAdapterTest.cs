using WindowsFormsApplication1.VinotekaDataSet1TableAdapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApplication1;

namespace VinotekaUnitTest
{
    
    
    /// <summary>
    ///This is a test class for Vinova_lozaTableAdapterTest and is intended
    ///to contain all Vinova_lozaTableAdapterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Vinova_lozaTableAdapterTest
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
///A test for Transaction
///</summary>
[TestMethod()]
public void TransactionTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
SqlTransaction expected = null; // TODO: Initialize to an appropriate value
    SqlTransaction actual;
    target.Transaction = expected;
    actual = target.Transaction;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Connection
///</summary>
[TestMethod()]
public void ConnectionTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
SqlConnection expected = null; // TODO: Initialize to an appropriate value
    SqlConnection actual;
    target.Connection = expected;
    actual = target.Connection;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for CommandCollection
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void CommandCollectionTest()
{
Vinova_lozaTableAdapter_Accessor target = new Vinova_lozaTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
    SqlCommand[] actual;
    actual = target.CommandCollection;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for ClearBeforeFill
///</summary>
[TestMethod()]
public void ClearBeforeFillTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
bool expected = false; // TODO: Initialize to an appropriate value
    bool actual;
    target.ClearBeforeFill = expected;
    actual = target.ClearBeforeFill;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Adapter
///</summary>
[TestMethod()]
public void AdapterTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
    SqlDataAdapter actual;
    actual = target.Adapter;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Update
///</summary>
[TestMethod()]
public void UpdateTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
DataRow dataRow = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Update(dataRow);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Update
///</summary>
[TestMethod()]
public void UpdateTest1()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
DataRow[] dataRows = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Update(dataRows);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Update
///</summary>
[TestMethod()]
public void UpdateTest2()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
VinotekaDataSet1.Vinova_lozaDataTable dataTable = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Update(dataTable);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Update
///</summary>
[TestMethod()]
public void UpdateTest3()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
VinotekaDataSet1 dataSet = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Update(dataSet);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Update
///</summary>
[TestMethod()]
public void UpdateTest4()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
Nullable<int> Sorta = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> BrojCokota = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Vinograd = new Nullable<int>(); // TODO: Initialize to an appropriate value
int Original_Id = 0; // TODO: Initialize to an appropriate value
Nullable<int> Original_Sorta = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Original_BrojCokota = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Original_Vinograd = new Nullable<int>(); // TODO: Initialize to an appropriate value
int Id = 0; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Update(Sorta, BrojCokota, Vinograd, Original_Id, Original_Sorta, Original_BrojCokota, Original_Vinograd, Id);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Update
///</summary>
[TestMethod()]
public void UpdateTest5()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
Nullable<int> Sorta = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> BrojCokota = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Vinograd = new Nullable<int>(); // TODO: Initialize to an appropriate value
int Original_Id = 0; // TODO: Initialize to an appropriate value
Nullable<int> Original_Sorta = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Original_BrojCokota = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Original_Vinograd = new Nullable<int>(); // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Update(Sorta, BrojCokota, Vinograd, Original_Id, Original_Sorta, Original_BrojCokota, Original_Vinograd);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Insert
///</summary>
[TestMethod()]
public void InsertTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
Nullable<int> Sorta = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> BrojCokota = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Vinograd = new Nullable<int>(); // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Insert(Sorta, BrojCokota, Vinograd);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for InitConnection
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void InitConnectionTest()
{
Vinova_lozaTableAdapter_Accessor target = new Vinova_lozaTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
    target.InitConnection();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for InitCommandCollection
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void InitCommandCollectionTest()
{
Vinova_lozaTableAdapter_Accessor target = new Vinova_lozaTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
    target.InitCommandCollection();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for InitAdapter
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void InitAdapterTest()
{
Vinova_lozaTableAdapter_Accessor target = new Vinova_lozaTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
    target.InitAdapter();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for GetData
///</summary>
[TestMethod()]
public void GetDataTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
VinotekaDataSet1.Vinova_lozaDataTable expected = null; // TODO: Initialize to an appropriate value
    VinotekaDataSet1.Vinova_lozaDataTable actual;
    actual = target.GetData();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Fill
///</summary>
[TestMethod()]
public void FillTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
VinotekaDataSet1.Vinova_lozaDataTable dataTable = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Fill(dataTable);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Delete
///</summary>
[TestMethod()]
public void DeleteTest()
{
Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter(); // TODO: Initialize to an appropriate value
int Original_Id = 0; // TODO: Initialize to an appropriate value
Nullable<int> Original_Sorta = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Original_BrojCokota = new Nullable<int>(); // TODO: Initialize to an appropriate value
Nullable<int> Original_Vinograd = new Nullable<int>(); // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.Delete(Original_Id, Original_Sorta, Original_BrojCokota, Original_Vinograd);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Vinova_lozaTableAdapter Constructor
///</summary>
[TestMethod()]
public void Vinova_lozaTableAdapterConstructorTest()
{
    Vinova_lozaTableAdapter target = new Vinova_lozaTableAdapter();
    Assert.Inconclusive("TODO: Implement code to verify target");
}
    }
}
