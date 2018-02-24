using Microsoft.VisualStudio.TestTools.UnitTesting;
using UITestAutomationFrameWork.Pages;
using TestAutomationFrameWork.PageObjectModelPages;
using UITestAutomationFrameWork.WebDriverCore;
using FreshStartTestCases.FreshStartpageObjectModelPages;
using TestAutomationFrameWork;
using APIUtility.APIHelper;
using System.Configuration;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace FreshStart.TestMethods
{
    [TestClass]
    public class MyPipelineTestCases
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
        public static string freshStartUrl = null;
        #region Initialize

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            testContext = context;
            driver = Driver.Initialize(testContext.Properties["BrowserChromeName"].ToString());
            freshStart = new FreshStartHome(driver);
            commonhelper = new WebObjectFunctions(driver);
            newEnroll = new NewEnrollClient(driver);
            myPipeline = new MyPipeline(driver);
            apiHelper = new CommonAPIHelper(driver);
            pipelineSearch = new PipelineSearch(driver);
            freshStartUrl = ConfigurationManager.AppSettings["FreshStartUrl"];
            freshStart.NavigateToFreshStartHome(driver, freshStartUrl);
            freshStart.NavigateToMyPipelineHome(driver);
        }
        #endregion Initialize


        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineLookAndFeel")]
        public void GivenMyPipeline_WhenSelectingOneClient_ThenCheckForAllElementsExistance()
        {
            IList<IWebElement> items = myPipeline.CreateListOfAllElements();
            for (int i = 0; i < items.Count; i++)
            {
                commonhelper.ValidatateWebElementDisplayed(items[i]);
            }
        }


        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineLookAndFeel")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenCheckForAllElementsExistance()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            IList<IWebElement> items = myPipeline.CreateListOfAllElementsForSearchPopup();
            for (int i = 0; i < items.Count; i++)
            {
                commonhelper.ValidatateWebElementDisplayed(items[i]);
            }
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenCheckAllSearchByLeaderDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupSearchByLeader_DropDown, ConfigurationManager.AppSettings["CheckAllText"]);
        }


        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenUncheckAllSearchByLeaderDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByTextUnCheck(myPipeline.MyPipelineSearchPopupSearchByLeader_DropDown, ConfigurationManager.AppSettings["CheckAllText"], ConfigurationManager.AppSettings["UncheckAllText"]);
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenGivenNameSearchByLeaderDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupSearchByLeader_DropDown, "Abraham Yeihey");
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenCheckAllSearchByStrategiesDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupSearchByStrategies_DropDown, ConfigurationManager.AppSettings["CheckAllText"]);
        }


        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenUncheckAllSearchByStrategiesDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByTextUnCheck(myPipeline.MyPipelineSearchPopupSearchByStrategies_DropDown, ConfigurationManager.AppSettings["CheckAllText"], ConfigurationManager.AppSettings["UncheckAllText"]);
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenGivenValueSearchByStrategiesDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle); 
            commonhelper.ListGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupSearchByStrategies_DropDown, ConfigurationManager.AppSettings["AddAuthorizedUserText"]);
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenCheckAllIncludeTheseStatusesDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupIncludeTheseStatuses_DropDown, ConfigurationManager.AppSettings["CheckAllText"]);
        }


        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenUncheckAllIncludeTheseStatusesDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByTextUnCheck(myPipeline.MyPipelineSearchPopupIncludeTheseStatuses_DropDown, ConfigurationManager.AppSettings["CheckAllText"], ConfigurationManager.AppSettings["UncheckAllText"]);
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenGivenValueIncludeTheseStatusesDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupIncludeTheseStatuses_DropDown, ConfigurationManager.AppSettings["PALText"]);
        }


        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenGivenValueSearchByConsultantDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.SelectGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupSearchByConsultant_DropDown, ConfigurationManager.AppSettings["OptionName"]);
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenGivenValueSearchByLoanPurposeDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.SelectGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupSearchByLoanPurpose_DropDown, ConfigurationManager.AppSettings["OptionType"]);
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenGivenValueSearchByPropertyStateDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.SelectGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupSearchByPropertyState_DropDown, ConfigurationManager.AppSettings["State"]);
        }


        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenCheckAllDesiredLoanProgramDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupDesiredLoanProgram_DropDown, ConfigurationManager.AppSettings["CheckAllText"]);
        }


        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenUncheckAllDesiredLoanProgramDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByTextUnCheck(myPipeline.MyPipelineSearchPopupDesiredLoanProgram_DropDown, ConfigurationManager.AppSettings["CheckAllText"], ConfigurationManager.AppSettings["UncheckAllText"]);
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLink_ThenGivenValueDesiredLoanProgramDropDown()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            commonhelper.ListGivenElementFromDropDownByText(myPipeline.MyPipelineSearchPopupDesiredLoanProgram_DropDown, ConfigurationManager.AppSettings["FHAText"]);
        }

        [TestMethod]
        [TestCategory("FreshStart_RegressionTestCase_MyPipelineFunctionalTest")]
        public void GivenMyPipeline_WhenClickingTheSearchClientLinkAndChooseSearchForONeClient_ThenCheckForAllElementsExistance()
        {
            myPipeline.NavigateToPipelineSearchPopup(driver);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            myPipeline.NavigateToPipelineSearchPopupSelectSearchForOneClient(driver);
            IList<IWebElement> items = myPipeline.CreateListOfAllElementsForSearchForOneClient();
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
