using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UITestAutomationFrameWork.Pages;
using TestAutomationFrameWork.Pages;
using TestAutomationFrameWork.LOLAPages;
using OpenQA.Selenium;

namespace TestAutomationFrameWork.QText
{
    [TestClass]
    public class QTextTestCases
    {
        private static TestContext testContext;
        public static IWebDriver driver;
        #region Initialize

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            testContext = context;
            driver=Driver.Initialize(testContext.Properties["BrowserIEName"].ToString());

        }
        [TestInitialize]

        public void TestInit()
        {
            AdminLoginPage login = new AdminLoginPage();
            login.LoadLOLAHomePage(driver,testContext.Properties["LOLAUrl"].ToString());
        }

        #endregion Initialize

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmTheQTextHeadingAppearInTheScreen()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
            login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateQTextHeadingExist();
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmClickHereToLearnAboutQTextOptInOutLinkAppear()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateQTextOptInOutLinkExist();
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmClientSubheadingAndNamePhoneLastTextAndTheAppropriateValueAppear()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateQTextClientPane();
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmLoanInformationSubheadingClientLoanStateProgramLoanAmountPurposeLTVClientTZAndItsAppropriateValueAppear()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateQTextLoanInformationPane();
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmRecentTextChatsAndThePlusAppear()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateRecentTextChatsSubheading();
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLogInAsBanker_WhenClickQTextOptInImage_ThenConfirmViewConversationSubheadingAndClientAndEveryoneDropdown()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateViewConversationSubheadingAndClientAndEveryoneDropdown();
        }


        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmClientConversationSubheadingAndTextbox()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateClientConversationSubheadingAndTextbox();
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmClientPhoneSubheadingAndADropDown()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateClientPhoneSubheadingAndDropDown();
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmCannedResponseSubheadingAndDropdownWithOptions()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ValidateCannedResponseSubheadingAndDropdownWithOptions();
        }

        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmTextboxFortextingExists()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ConfirmTextBoxForTexting();
        }


        [TestMethod]
        [TestCategory("UILookAndFeel_QText")]
        public void GivenLogInAsBanker_WhenClickQTextOptInImage_ThenConfirmTheSendButton()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ConfirmTheSendButton();
        }

        [TestMethod]
        [TestCategory("Functional_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenConfirmRecentTextChatsPlusIsFunctional()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ConfirmRecentTextChatsPlusIsFunctional();
        }

        [TestMethod]
        [TestCategory("Functional_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImage_ThenCannedResponseChooseOneOptionFromDropdown()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ConfirmCannedResponseChooseOneOptionFromDropdown();
        }

        [TestMethod]
        [TestCategory("Functional_QText")]
        public void GivenLoginAsBanker_WhenClickQTextOptInImageEnterTextAndSendOutBoundText_ThenConfirmTheEntryInTheTextBox()
        {
            AdminLoginPage login = new AdminLoginPage();
            DashBoardHomePage dashBoardHomePage = new DashBoardHomePage();
            DashBoardWorkStationQText dashBoardWorkStationsQtext = new DashBoardWorkStationQText();
           login.LOLALogin(driver,testContext.Properties["BankerUserName"].ToString(), testContext.Properties["BankerPassword"].ToString());
            dashBoardHomePage.NavigateToParticularLead(testContext.Properties["LeadSearchNumber"].ToString()).NavigateToQtextSubScreen();
            dashBoardWorkStationsQtext.ConfirmCannedResponseChooseOneOptionFromDropdown();
        }

        [TestCleanup]
        public void CloseDown()
        {
            driver.Quit();
        }
    }
}
