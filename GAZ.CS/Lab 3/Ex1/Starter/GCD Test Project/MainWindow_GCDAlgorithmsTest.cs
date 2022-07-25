using GreatestCommonDivisor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GCD_Test_Project
{
    
    
    /// <summary>
    ///This is a test class for MainWindow_GCDAlgorithmsTest and is intended
    ///to contain all MainWindow_GCDAlgorithmsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainWindow_GCDAlgorithmsTest
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
        ///A test for FindGCDEuclid
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Module3.exe")]
        public void FindGCDEuclidTest()
        {
            int a = 2806; // TODO: Initialize to an appropriate value
            int b = 345; // TODO: Initialize to an appropriate value
            int expected = 23; // TODO: Initialize to an appropriate value
            int actual;
            actual = MainWindow_Accessor.GCDAlgorithms.FindGCDEuclid(a, b);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
