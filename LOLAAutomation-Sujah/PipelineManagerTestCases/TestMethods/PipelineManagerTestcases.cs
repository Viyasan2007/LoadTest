using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UITestAutomationFrameWork.Pages;
using OpenQA.Selenium;
using System.Configuration;
using UITestAutomationFrameWork.WebDriverCore;

namespace TestAutomationFrameWork.PipeLineManager
{
    /// <summary>
    /// Summary description for PipeLineManagerTestcases
    /// </summary>
    [TestClass]
    public class PipeLineManagerTestcases
    {
        #region Fields
        private static TestContext testContext;
        private static string url;
        public static IWebDriver driver;
        #endregion
        #region Initialize

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            testContext = context;
            driver = Driver.Initialize(testContext.Properties["BrowserIEName"].ToString());


        }
        #endregion Initialize


        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginAsBanker_WhenVerifyTheBankerAbleToUpdateNotes_ThenConfirmTheCriticalOnWorkStation()
        {

            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.AccessParticularCell(1, 15, testContext.Properties["NotesData"].ToString());
            loan.ConfirmNotesAreSavedInParticularLoan("QA");

        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginAsDMB_WhenVerifyTheDMBAbleToUpdateNotes_ThenConfirmTheCriticalOnWorkStation()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["DMBUsername"].ToString(), testContext.Properties["DMBPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.AccessParticularCell(1, 16, testContext.Properties["NotesData"].ToString());
            loan.ConfirmNotesAreSavedInParticularLoan("QA");
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginAsBanker_WhenVerifyBankerAbleToUpdateHotReason_ThenConfirmTheCriticalOnWorkStation()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.AccessParticularHotForBankerCell(1, 16);
            loan.ConfirmHotReasonAreSavedInParticularLoan(testContext.Properties["BankerHotReason"].ToString());
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginAsDMB_WhenDMBAbleToUpdateHotReason_ThenConfirmTheCriticalOnWorkStation()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.AccessParticularHotForDMBCell(2, 17);
            loan.ConfirmHotReasonAreSavedInParticularLoan(testContext.Properties["DMBHotReason"].ToString());
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginAsRVP_WhenVerifyRVPIsAbleToCallClientOutOfPM_ThenItReturnsTrueForItsSuccess()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["RVPUserName"].ToString(), testContext.Properties["RVPPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            loan.DialCallPipeLineManager(2);
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginasRVP_WhenClickOnQTextIcon_ThenConfirmQtextPopupIsDisplayed()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["RVPUserName"].ToString(), testContext.Properties["RVPPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            loan.ClickQTextPipeLineManager(2);
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginasRVP_WhenClickedOnLinkToEmailInPM_ThenConfirmEmailPageAppear()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["RVPUserName"].ToString(), testContext.Properties["RVPPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            loan.ClickEmailPipeLineManager(2);
        }



        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginAsBanker_WhenBankerAbleToUncheckTheHotreasonCheckboxForBanker_ThenConfirmTheCriticalOnWorkStation()
        {

            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.UnCheckHotReasonForCell(1, 16, 1);
            loan.ConfirmHotReasonAreUnCheckedInParticularLoan(testContext.Properties["BankerHotReasonUnCheck"].ToString());
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoginAsDMB_WhenDMBAbleToUncheckTheHotreasonCheckboxBesideDMB_ThenConfirmTheCriticalOnWorkStation()
        {

            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.UnCheckHotReasonForCell(2, 17, 2);
            loan.ConfirmHotReasonAreUnCheckedInParticularLoan(testContext.Properties["DMBHotReasonUnCheck"].ToString());
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickingOpenPipeLineInNewTab_ThenConfirmTheNewTabShowsUp()
        {

            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.NavigateToPipeLineManagerNewTab();
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLogginAsDMB_WhenCheckingTablePiginate_ThenMoreThanHundredsLeadsAndNextButtonWillBeShowsUp()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.NavigateToFooterTablePiginate();
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickCreditPulledYesFilter_TheConfirm8020CriticalOnWorkStation()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            string critical = ConfigurationManager.AppSettings["Critical"];
            Console.WriteLine(" Teh critical is0" + critical);
            dashBoardPipeLineManager.VerifyFilterCritical(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledYes_CheckBox, critical, testContext.Properties["FilterTypeYes"].ToString());
        }


        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickCreditPulledNoFilter_ThenConfirmNo8020CriticalOnWorkStation()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);

            dashBoardPipeLineManager.VerifyFilterCritical(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledNo_CheckBox, testContext.Properties["Critical8020"].ToString(), testContext.Properties["FilterTypeNo"].ToString());
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickProgramYesFilter_ThenConfirmProgramsAreListedUnderPipelineManagerLoanProgramColumn()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifyFilterYesOrNo(13);
            dashBoardPipeLineManager.VerifyFilterCritical(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardProgramYes_CheckBox, testContext.Properties["Critical8020"].ToString(), testContext.Properties["FilterTypeNo"].ToString());
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickProgramNoFilter_ThenConfirmNoProgramsAreListedUnderPipelineManagerLoanProgramColumn()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifyFilterYesOrNo(13);
        }



        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickCalledTodayYesFilter_ThenConfirmLastCalledAreListedUnderPipelineManagerLastATCColumn()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifyFilterYesOrNo(14);
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickCalledTodayNoFilter_ThenConfirmNoLastCalledAreListedUnderPipelineManagerLastATCColumn()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifyFilterYesOrNo(14);
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickHasAppointmentYesFilter_ThenConfirmNoRecordFoundunderPipelineManager()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifyFilterYesOrNo(15);
        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickHasAppointmentNoFilter_ThenConfirmRecordFoundunderPipelineManager()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifyFilterYesOrNo(15);
        }



        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickPALYesFilter_ThenConfirm9610CriticalUnderDashBoardWorkStation()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifyFilterCritical(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPALYes_CheckBox, testContext.Properties["PALCritical9610"].ToString(), testContext.Properties["FilterTypeYes"].ToString());
        }
        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenClickPALNoFilter_ThenConfirmNo9610CriticalUnderDashBoardWorkStation()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifyFilterYesOrNo(3);
        }


        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByBanker_ThenConfirmBankerColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(2);

        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByLeadSource_ThenConfirmLeadSourceColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(3);

        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByLeadStatus_ThenConfirmLeadStatusColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(4);

        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByName_ThenConfirmNameColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(5);

        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByCredit_ThenConfirmCreditColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(6);

        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByState_ThenConfirmStateColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(7);

        }


        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByAge_ThenConfirmAgeColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(8);

        }


        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByLoanAmount_ThenLoanAmountColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(11);

        }
        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByLoanProgram_ThenConfirmLoanProgramColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(12);

        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByNextAppointment_ThenConfirmNextAppointmentColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(14);

        }

        [TestMethod]
        [TestCategory("Functional_PipeLineManager")]
        public void GivenLoggingAsDMB_WhenSortByHot_ThenConfirmHotColumnIsSorted()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            dashBoardPipeLineManager.VerifySortedColumn(16);

        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyButtonsPipelinePALLoansInProcessOpenPipelineInNewTab_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPipeLine_Button));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardLoanInProcess_Button));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardNewTab_Button));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPAL_Button));
        }
        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyDropDownsForRVPDMBBanker_ThenItConfirmsDropDownItems()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardRVP_DropDown));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardDMB_DropDown));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardBanker_DropDown));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardRVP_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardDMP_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardBanker_Label));



        }
        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyButtonForExportCSV_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardExportCSV_Button));
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyCheckBoxesForTextable_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardTextable_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardTextableNo_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardTextableNo_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardTextableNo_CheckBox, "No"));
        }


        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyCheckBoxesForPAL_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPAL_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPALYes_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPALNo_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPALYes_CheckBox, "Yes"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPALNo_CheckBox, "No"));
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyCheckBoxesForCreditPulled_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCreditPulled_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledYes_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledNo_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledYes_CheckBox, "Yes"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledNo_CheckBox, "No"));

        }


        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyCheckBoxesForProgram_ThenItsReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardProgram_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardProgramYes_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardProgramNo_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardProgramYes_CheckBox, "Yes"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardProgramNo_CheckBox, "No"));

        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyCheckBoxesForCalledToday_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCalledToday_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCalledTodayYes_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCalledTodayNo_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCalledTodayYes_CheckBox, "Yes"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardCalledTodayNo_CheckBox, "No"));

        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyCheckBoxesForHasAppointment_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHasAppointment_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHasAppointmentYes_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHasAppointmentNo_CheckBox));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHasAppointmentYes_CheckBox, "Yes"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHasAppointmentNo_CheckBox, "No"));

        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifySearchBox_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardSearch_Label, "Search"));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardSearch_TextBox));
        }


        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenVerifyShowNumberOfEntries_ThenItReturnsTrueItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardShow_Label, "Show"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardEntries_Label, "Entries"));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardEntries_Label));
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenTableHeaders_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLoan_Label, "Loan#"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderBanker_Label, "Banker"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLeadSource_Label, "Lead Source"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLeadStatus_Label, "Lead Status"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderName_Label, "Name"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderCredit_Label, "Credit"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderState_Label, "State label"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderTZ_Label, "TZ"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderAge_Label, "Age"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLTV_Label, "LTV"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLTV_Label, "Purpose"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLTV_Label, "Loan Amount"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLTV_Label, "Loan Program"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLastATC_Label, "Last ATC"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderLTV_Label, "Next Appointment"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderNotes_Label, "Notes"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderHot_Label, "Hot"));
            Assert.IsTrue(Handler.ValidatateWebElementTextDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardHeaderMarketingHotReason_Label, "Marketing Hot Reason"));
        }


        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenTableFooter_ItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardFooterTableInfo_Label));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardFooterTablePaginate_Label));
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingInAsDMBAndLoadingPipelineManager_WhenQLCopyright_ThenITReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_PipeLineManager")]
        public void GivenLoggingAsDMBAndLoadingPipelineManager_WhenTheLoanNumberColumnHasPhoneTextAndEmailImage_ThenItReturnsTrueForItsExsistance()
        {
            AdminLoginPage login = new AdminLoginPage(driver);
            login.LoadLOLAHomePage(driver, testContext.Properties["LOLAUrl"].ToString());
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager(driver);
            Loan loan = new Loan(driver);
            login.LOLALogin(driver, testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardPipeLineManager.NavigateToPipeLineManager(driver);
            WebObjectFunctions Handler = new WebObjectFunctions();
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardLoanNumber_Link));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardPhone_Image));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardQText_Image));
            Assert.IsTrue(Handler.ValidatateWebElementDisplayed(dashBoardPipeLineManager.LOLAClientClientProfilePipeLineManagerDashBoardEmail_Image));
        }


        [TestCleanup]
        public void CloseDown()
        {
            driver.Quit();
        }



    }
}
