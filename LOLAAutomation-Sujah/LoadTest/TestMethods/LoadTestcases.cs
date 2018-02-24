using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UITestAutomationFrameWork.Pages;
using System.Configuration;
using LoadTest.PageObjectModel;
using LoadTest.Utility;

namespace LoadTest.TestMethods
{
    [TestClass]
    public class LoadTestcases
    {
        [TestClass]
        public class LoadTestCases
        {
            private static TestContext testContext;
            private static string url;
            public static IWebDriver driver;
            public static AdminLogin login;
            public static DashBoard dashBoard;
            public static Client client;

            #region Initialize

            [ClassInitialize]
            public static void Init(TestContext context)
            {
                testContext = context;
                
                
            }
            #endregion Initialize

            [TestMethod]
            [TestCategory("LOLA_Loadtest_LeadCreatation")]
            public void GivenLogIntoDashBoard_CreateANewLead()
            {
                Log.WriteStringLine();
                Log.Write("There was a problem in shifting bytes left!");
                Log.WriteLine();
                Log.WriteFormat("Test args {0} and {1}", "#first#", "#second#");
                Log.WriteLineFormat("Test args {0} and {1}", "#first#", "#second#");

                Log.Write(" The Start Time");

                Log log = new Log(driver);
                driver = log.driver;
                driver = Driver.Initialize(ConfigurationManager.AppSettings["BrowserIEName"]);
                url = ConfigurationManager.AppSettings["EnvironmentUrl"];
                login = new AdminLogin(driver);
                dashBoard = new DashBoard(driver);
                login.NavigateToLoginPage(driver, url);
                login.NavigateToDashBoard(driver, ConfigurationManager.AppSettings["BankerUserName"], ConfigurationManager.AppSettings["BankerPassword"]);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                dashBoard.NavigateToClient(driver);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                Log.Write(" The elapsed time "+elapsedMs.ToString());

            }
            //Closing the borwser
            [TestCleanup]
            public void CloseDown()
            {
                driver.Quit();
            }
        }
    }
}
