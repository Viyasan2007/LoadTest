using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using APIUtility.APIHelper;
using TestAutomationFrameWork.PageObjectModelPages;
using UITestAutomationFrameWork.WebDriverCore;
using FreshStartTestCases.FreshStartpageObjectModelPages;
using TestAutomationFrameWork;
using UITestAutomationFrameWork.Pages;
using APIHelper.Utility;

namespace FreshStart.TestMethods
{
    [TestClass]
    public class NewClientAutoFillTestCases
    {
        #region Initialize
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
        public static Panorama_SecondClientDetails secondClientDetails;
        public static APIUtilityFunctions ApiUtilityFunction;
        public static string value = null;
        public static ClientSummaryAutoFill clientSummarryApi;
        public static ClientSummaryAutoFill clientSummaryValue;
        public static ClientSummaryAutoFill clientSummarryApiOne;
        public static ClientSummaryAutoFill clientSummaryValueOne;

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
            clientSummarryApi = new ClientSummaryAutoFill(driver);
            clientSummaryValue = new ClientSummaryAutoFill(driver);
            clientSummarryApiOne = new ClientSummaryAutoFill(driver);
            clientSummaryValueOne = new ClientSummaryAutoFill(driver);
            ApiUtilityFunction = new APIUtilityFunctions(driver);
            clientSummaryValueOne.GetAllValueForClientOne(driver);
            clientSummarryApiOne.GetAllAPIForClientOne(driver);
            clientSummaryValue.GetAllValueForClientTwo(driver);
            clientSummarryApi.GetAllAPIForClientTwo(driver);
        }
        #endregion

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonClientInfoForSecondClientEmailAddress_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApi.GetValueClientTwoEmailAddress(), clientSummaryValue.GetValueClientTwoEmailAddress());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonClientInfoForSecondClientFirstName_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApi.GetAPIClientTwoFirstName(), clientSummaryValue.GetValueClientTwoFirstName());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonClientInfoForSecondClientLastName_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApi.GetAPIClientTwoLastName(), clientSummaryValue.GetValueClientTwoLastName());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonFirstName_TheValidateTheMobiusDataIsEqualToUIData()
        {

            Console.WriteLine(" The Api Value "+ clientSummarryApi.GetAPIClientFirstname());
            Console.WriteLine(" The UI  value "+ clientSummaryValue.GetValueClientFirstname());
            Assert.AreEqual(clientSummarryApi.GetAPIClientFirstname(), clientSummaryValue.GetValueClientFirstname());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonLastName_TheValidateTheMobiusDataIsEqualToUIData()
        {
           Assert.AreEqual(clientSummarryApiOne.GetAPIClientLastname(), clientSummaryValueOne.GetValueClientLastname());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonEmailAddress_TheValidateTheMobiusDataIsEqualToUIData()
        {
           Assert.AreEqual(clientSummarryApiOne.GetAPIClientEmail(), clientSummaryValueOne.GetValueClientEmail());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonPhoneNumber_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApiOne.GetAPIClientPhone(), clientSummaryValueOne.GetValueClientPhone());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonClientInfoFirstName_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApiOne.GetAPIClientOneFirstname(), clientSummaryValueOne.GetValueClientOneFirstname());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonClientInfoLastName_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApiOne.GetAPIClientOneLastname(), clientSummaryValueOne.GetValueClientOneLastname());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonClientInfoPhoneNumber_TheValidateTheMobiusDataIsEqualToUIData()
        {
           Assert.AreEqual(clientSummarryApiOne.GetAPIClientOnePhone(), clientSummaryValueOne.GetValueClientOnePhone());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonClientInfoEmailAddress_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApiOne.GetAPIClientOneEmail(), clientSummaryValueOne.GetValueClientOneEmail());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonPropertyAddress_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApiOne.GetAPIPropertyAddress(), clientSummaryValueOne.GetValuePropertyAddress());
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTest_AutoFill")]
        public void GivenLoadingMobiusPanorama__WhenEnteringLoanNumberAndGcidReadPersonPropertyZipCode_TheValidateTheMobiusDataIsEqualToUIData()
        {
            Assert.AreEqual(clientSummarryApiOne.GetAPIPropertyCity(), clientSummaryValueOne.GetValuePropertyCity());
        }

        //Closing the borwser
        [TestCleanup]
        public void CloseDown()
        {
            driver.Quit();
        }
    }
}