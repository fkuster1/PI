using WindowsFormsApplication1.VinotekaDataSet1TableAdapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using WindowsFormsApplication1;
using System.Collections.Generic;

namespace VinotekaUnitTest
{
    
    
    /// <summary>
    ///This is a test class for TableAdapterManagerTest and is intended
    ///to contain all TableAdapterManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TableAdapterManagerTest
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
///A test for Vrsta_vinaTableAdapter
///</summary>
[TestMethod()]
public void Vrsta_vinaTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
Vrsta_vinaTableAdapter expected = null; // TODO: Initialize to an appropriate value
    Vrsta_vinaTableAdapter actual;
    target.Vrsta_vinaTableAdapter = expected;
    actual = target.Vrsta_vinaTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Vrsta_bacviTableAdapter
///</summary>
[TestMethod()]
public void Vrsta_bacviTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
Vrsta_bacviTableAdapter expected = null; // TODO: Initialize to an appropriate value
    Vrsta_bacviTableAdapter actual;
    target.Vrsta_bacviTableAdapter = expected;
    actual = target.Vrsta_bacviTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Vinova_lozaTableAdapter
///</summary>
[TestMethod()]
public void Vinova_lozaTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
Vinova_lozaTableAdapter expected = null; // TODO: Initialize to an appropriate value
    Vinova_lozaTableAdapter actual;
    target.Vinova_lozaTableAdapter = expected;
    actual = target.Vinova_lozaTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for VinogradTableAdapter
///</summary>
[TestMethod()]
public void VinogradTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
VinogradTableAdapter expected = null; // TODO: Initialize to an appropriate value
    VinogradTableAdapter actual;
    target.VinogradTableAdapter = expected;
    actual = target.VinogradTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Vino_u_bacviTableAdapter
///</summary>
[TestMethod()]
public void Vino_u_bacviTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
Vino_u_bacviTableAdapter expected = null; // TODO: Initialize to an appropriate value
    Vino_u_bacviTableAdapter actual;
    target.Vino_u_bacviTableAdapter = expected;
    actual = target.Vino_u_bacviTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Vino_je_odTableAdapter
///</summary>
[TestMethod()]
public void Vino_je_odTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
Vino_je_odTableAdapter expected = null; // TODO: Initialize to an appropriate value
    Vino_je_odTableAdapter actual;
    target.Vino_je_odTableAdapter = expected;
    actual = target.Vino_je_odTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for VinoTableAdapter
///</summary>
[TestMethod()]
public void VinoTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
VinoTableAdapter expected = null; // TODO: Initialize to an appropriate value
    VinoTableAdapter actual;
    target.VinoTableAdapter = expected;
    actual = target.VinoTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for UpdateOrder
///</summary>
[TestMethod()]
public void UpdateOrderTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
TableAdapterManager.UpdateOrderOption expected = new TableAdapterManager.UpdateOrderOption(); // TODO: Initialize to an appropriate value
    TableAdapterManager.UpdateOrderOption actual;
    target.UpdateOrder = expected;
    actual = target.UpdateOrder;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for TableAdapterInstanceCount
///</summary>
[TestMethod()]
public void TableAdapterInstanceCountTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
    int actual;
    actual = target.TableAdapterInstanceCount;
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for SortaTableAdapter
///</summary>
[TestMethod()]
public void SortaTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
SortaTableAdapter expected = null; // TODO: Initialize to an appropriate value
    SortaTableAdapter actual;
    target.SortaTableAdapter = expected;
    actual = target.SortaTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for PosloviTableAdapter
///</summary>
[TestMethod()]
public void PosloviTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
PosloviTableAdapter expected = null; // TODO: Initialize to an appropriate value
    PosloviTableAdapter actual;
    target.PosloviTableAdapter = expected;
    actual = target.PosloviTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for PodrumTableAdapter
///</summary>
[TestMethod()]
public void PodrumTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
PodrumTableAdapter expected = null; // TODO: Initialize to an appropriate value
    PodrumTableAdapter actual;
    target.PodrumTableAdapter = expected;
    actual = target.PodrumTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Obavljeni_posloviTableAdapter
///</summary>
[TestMethod()]
public void Obavljeni_posloviTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
Obavljeni_posloviTableAdapter expected = null; // TODO: Initialize to an appropriate value
    Obavljeni_posloviTableAdapter actual;
    target.Obavljeni_posloviTableAdapter = expected;
    actual = target.Obavljeni_posloviTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for Connection
///</summary>
[TestMethod()]
public void ConnectionTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
IDbConnection expected = null; // TODO: Initialize to an appropriate value
    IDbConnection actual;
    target.Connection = expected;
    actual = target.Connection;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for ButeljeTableAdapter
///</summary>
[TestMethod()]
public void ButeljeTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
ButeljeTableAdapter expected = null; // TODO: Initialize to an appropriate value
    ButeljeTableAdapter actual;
    target.ButeljeTableAdapter = expected;
    actual = target.ButeljeTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for BacveTableAdapter
///</summary>
[TestMethod()]
public void BacveTableAdapterTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
BacveTableAdapter expected = null; // TODO: Initialize to an appropriate value
    BacveTableAdapter actual;
    target.BacveTableAdapter = expected;
    actual = target.BacveTableAdapter;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for BackupDataSetBeforeUpdate
///</summary>
[TestMethod()]
public void BackupDataSetBeforeUpdateTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
bool expected = false; // TODO: Initialize to an appropriate value
    bool actual;
    target.BackupDataSetBeforeUpdate = expected;
    actual = target.BackupDataSetBeforeUpdate;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for UpdateUpdatedRows
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void UpdateUpdatedRowsTest()
{
TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
VinotekaDataSet1 dataSet = null; // TODO: Initialize to an appropriate value
List<DataRow> allChangedRows = null; // TODO: Initialize to an appropriate value
List<DataRow> allAddedRows = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for UpdateInsertedRows
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void UpdateInsertedRowsTest()
{
TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
VinotekaDataSet1 dataSet = null; // TODO: Initialize to an appropriate value
List<DataRow> allAddedRows = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.UpdateInsertedRows(dataSet, allAddedRows);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for UpdateDeletedRows
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void UpdateDeletedRowsTest()
{
TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
VinotekaDataSet1 dataSet = null; // TODO: Initialize to an appropriate value
List<DataRow> allChangedRows = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.UpdateDeletedRows(dataSet, allChangedRows);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for UpdateAll
///</summary>
[TestMethod()]
public void UpdateAllTest()
{
TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
VinotekaDataSet1 dataSet = null; // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.UpdateAll(dataSet);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for SortSelfReferenceRows
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void SortSelfReferenceRowsTest()
{
TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
DataRow[] rows = null; // TODO: Initialize to an appropriate value
DataRelation relation = null; // TODO: Initialize to an appropriate value
bool childFirst = false; // TODO: Initialize to an appropriate value
    target.SortSelfReferenceRows(rows, relation, childFirst);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for MatchTableAdapterConnection
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void MatchTableAdapterConnectionTest()
{
TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
IDbConnection inputConnection = null; // TODO: Initialize to an appropriate value
bool expected = false; // TODO: Initialize to an appropriate value
    bool actual;
    actual = target.MatchTableAdapterConnection(inputConnection);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for GetRealUpdatedRows
///</summary>
[TestMethod()]
[DeploymentItem("WindowsFormsApplication1.exe")]
public void GetRealUpdatedRowsTest()
{
TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
DataRow[] updatedRows = null; // TODO: Initialize to an appropriate value
List<DataRow> allAddedRows = null; // TODO: Initialize to an appropriate value
DataRow[] expected = null; // TODO: Initialize to an appropriate value
    DataRow[] actual;
    actual = target.GetRealUpdatedRows(updatedRows, allAddedRows);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for TableAdapterManager Constructor
///</summary>
[TestMethod()]
public void TableAdapterManagerConstructorTest()
{
    TableAdapterManager target = new TableAdapterManager();
    Assert.Inconclusive("TODO: Implement code to verify target");
}
    }
}
