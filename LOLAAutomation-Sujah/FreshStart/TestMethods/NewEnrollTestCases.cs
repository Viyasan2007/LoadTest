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
    public class NewEnrollTestCases
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
            Assert.IsTrue(commonhelper.ValidatateWebElementDisplayed(newEnroll.newEnroll_Subheading));
            Assert.IsTrue(commonhelper.ValidatateWebElementTextDisplayed(newEnroll.newEnroll_Subheading, ConfigurationManager.AppSettings["NewEnrollText"]));
            Assert.IsTrue(commonhelper.ValidatateWebElementDisplayed(newEnroll.newEnrollLoanNumber_Label));
            Assert.IsTrue(commonhelper.ValidatateWebElementTextDisplayed(newEnroll.newEnrollLoanNumber_Label, ConfigurationManager.AppSettings["LoanNumberText"]));
            Assert.IsTrue(commonhelper.ValidatateWebElementDisplayed(newEnroll.newEnrollLoanNumber_TextBox)); 
            Assert.IsTrue(commonhelper.ValidatateWebElementAttributeCheck(newEnroll.newEnrollLoanNumber_TextBox, ConfigurationManager.AppSettings["MaxLengthTenText"])); 
            Assert.IsTrue(commonhelper.ValidatateWebElementAttributeCheck(newEnroll.newEnrollLoanNumber_TextBox, ConfigurationManager.AppSettings["NgPatternText"]));
            Assert.IsTrue(commonhelper.ValidatateWebElementAttributeCheck(newEnroll.newEnrollEntroll_Button, ConfigurationManager.AppSettings["DisabledText"])); 
            newEnroll.EnterLoanNumber(driver, ConfigurationManager.AppSettings["LoanNumber"]);
            Assert.IsTrue(commonhelper.ValidatateWebRemovedElementAttributeCheck(newEnroll.newEnrollEntroll_Button, ConfigurationManager.AppSettings["DisabledText"]));
            newEnroll.NavigateToClientOption(driver);
            newEnroll.SelectFirstClient(driver);
        }
        #endregion Initialize

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_NewEnrollLookAndFeel")]
        public void GivenEnrollClient_WhenSelectingOneClient_ThenCheckForAllElementsExistance()
        {
            IList<IWebElement> items = newEnroll.CreateListOfAllElements();
            for(int i=0; i< items.Count; i++)
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


