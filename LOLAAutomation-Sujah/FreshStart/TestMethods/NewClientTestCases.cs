using Microsoft.VisualStudio.TestTools.UnitTesting;
using UITestAutomationFrameWork.Pages;
using System.Configuration;
using TestAutomationFrameWork.PageObjectModelPages;
using OpenQA.Selenium;
using FreshStartTestCases.FreshStartpageObjectModelPages;
using UITestAutomationFrameWork.WebDriverCore;
using APIUtility.APIHelper;
using System.Collections.Generic;

namespace TestAutomationFrameWork.TestCases.FreshStart
{
    [TestClass]
    public class NewClientTestCases
    {
        private static TestContext testContext;
        private static string url;
        public static IWebDriver driver;
        public static FreshStartHome freshStart;
        public static WebObjectFunctions commonhelper;
        public static NewEnrollClient newEnroll;
        public static MyPipeline myPipeline;
        public static CommonAPIHelper apiHelper;
        public static PipelineSearch pipelineSearch;
        public static Panorama_ClientDetails clientDetail;
        public static Panorama_SecondClientDetails secondClientDetail;
        #region Initialize

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            testContext = context;
            driver = Driver.Initialize(testContext.Properties["BrowserIEName"].ToString());
            freshStart = new FreshStartHome(driver);
            commonhelper = new WebObjectFunctions(driver);
            newEnroll = new NewEnrollClient(driver);
            myPipeline = new MyPipeline(driver);
            apiHelper = new CommonAPIHelper(driver);
            pipelineSearch = new PipelineSearch(driver);
            string freshStartUrl = ConfigurationManager.AppSettings["FreshStartUrl"];
            newEnroll.NavigateToFreshStartHome(driver, freshStartUrl);
            newEnroll.EnterLoanNumber(driver, ConfigurationManager.AppSettings["LoanNumber"]);
            newEnroll.NavigateToClientOption(driver);
            newEnroll.SelectFirstClient(driver);
        }
        #endregion Initialize

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_NewClientLookAndFeel")]
        public void GivenNavigateToNewClient_WhenSelectingOneClient_ThenCheckForAllElementsExistance()
        {
            IList<IWebElement> items = freshStart.CreateListOfAllElements();
            for (int i = 0; i < items.Count; i++)
            {
                commonhelper.ValidatateWebElementDisplayed(items[i]);
            }
        }

       //Closing the borwser
       [TestCleanup]
        public void CloseDown()
        {
            driver.Quit();
        }

    }
}
