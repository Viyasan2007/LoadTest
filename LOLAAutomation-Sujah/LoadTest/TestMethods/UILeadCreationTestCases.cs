using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UITestAutomationFrameWork.Pages;
using OpenQA.Selenium.Support.UI;



using OpenQA.Selenium;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using TestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork
{
    [TestClass]
    public class  UITestCases

    {

        #region Fields

        private static AdminLoginPage login;
        private static TestContext testContext;



        #endregion Fields

        #region Initialize

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            testContext = context;
            Driver.Initialize();

            //Assert.IsTrue(login.ValidateClientProfileClientColor());


        }


       
        #endregion Initialize

        [TestMethod]
        public void QTextSendingTextToClient_SendText_ClientConversationScreenwillBeGreen()
        {

            AdminLoginPage login = new AdminLoginPage(Driver.Instance);
            login.LoadLOLAHomePage(testContext.Properties["webAppTestUrl"].ToString());
            login.LOLALogin(testContext.Properties["webAppTestUserName"].ToString(), testContext.Properties["webAppTestPassword"].ToString());


            ClientClientProfile clientClientProfile = new ClientClientProfile();
            clientClientProfile.SeachParticularLead("5311862865");
            //Assert.IsTrue(clientClientProfile.ValidateOptedInImageExsist());


            clientClientProfile.NavigateToOptedInQtext();



            DashBoardWorkStationQText qtext = new DashBoardWorkStationQText(Driver.Instance);

            Driver.Instance.SwitchTo().DefaultContent();
            qtext.EnterClientOutboundMessage("Hi");



        }



        [TestMethod]

        public void LeadCreation_PurchaseLead_()
        {

            AdminLoginPage login = new AdminLoginPage(Driver.Instance);
            login.LoadLOLAHomePage(testContext.Properties["webAppTestUrl"].ToString());
            login.LOLALogin(testContext.Properties["webAppTestUserName"].ToString(), testContext.Properties["webAppTestPassword"].ToString());
            ClientClientProfile clientClientProfile = new ClientClientProfile();
            Random rnd = new Random();
            string rndNunmber = rnd.Next(0, 100000).ToString();
            clientClientProfile.FillClient1("John" + rndNunmber, "", "Homeowner" + rndNunmber, "", "", "3135454675", "54675", "", "", "6475244752", "SujahSivasubramaniam" + rndNunmber + "@quickenloans.com");
            //Assert.IsTrue(clientClientProfile.ValidateClientClientProfileGoalsPage());


            ClientClientProfileGoals clientClientProfileGoals = new ClientClientProfileGoals();
            clientClientProfileGoals.FillGoal();
            // Assert.IsTrue(clientClientProfileGoals.ValidateClientClientProfilePropertyPage());


            ClientClientProfileProperty clientClientProfileProperty = new ClientClientProfileProperty();
            clientClientProfileProperty.FillProperty();
            // Assert.IsTrue(clientClientProfileProperty.ValidateClientClientProfileEmploymentIncome());

            ClientClientProfileEmploymentIncome clientClientProfileEmploymentIncome = new ClientClientProfileEmploymentIncome();
            clientClientProfileEmploymentIncome.FillEmploymentInCome();
            //Assert.IsTrue(clientClientProfileEmploymentIncome.ValidateClientClientProfileEmploymentIncome());


            ClientClientProfileNonEmploymentIncome clientClientProfileNonEmploymentIncome = new ClientClientProfileNonEmploymentIncome();
            clientClientProfileNonEmploymentIncome.FillNonEmploymentIncome();
            // Assert.IsTrue(clientClientProfileNonEmploymentIncome.ValidateClientProfileNonEmploymentIncome());


            ClientClientProfileAsset clientClientProfileAssets = new ClientClientProfileAsset();
            clientClientProfileAssets.FillAssets();
            // Assert.IsTrue(clientClientProfileAssets.ValidateClientProfileAssets());


            ClientClientProfileCredit clientClientProfileCredit = new ClientClientProfileCredit();
            clientClientProfileCredit.FillCredit();
            // Assert.IsTrue(clientClientProfileCredit.ValidateClientProfileCreditColor());

            ClientClientProfileGetPrograms clientClientProfileGetPrograms = new ClientClientProfileGetPrograms();
            clientClientProfileGetPrograms.GetPrograms();
        }


        [TestMethod]

        public void PipeLineManagerNotesAddition_AddNotesInTheBankerPipeLineManager_ConfirmNotesAreAddedToTheClientWorkStation()
        {
            AdminLoginPage login = new AdminLoginPage(Driver.Instance);
            login.LoadLOLAHomePage(testContext.Properties["webAppTestUrl"].ToString());
            login.LOLALogin("QABANKER1", "Jul@2017");
            DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager();
            dashBoardPipeLineManager.NavigateToPipeLineManager();
            dashBoardPipeLineManager.AccessParticularCell(2,15);
            Loan loan = new Loan();
            loan.ConfirmNotesAreSavedInParticularLoan("QA");




        }

        [TestMethod]

        public void QuickPal_CheckingPopup()
        {
            AdminLoginPage login = new AdminLoginPage(Driver.Instance);
            login.LoadLOLAHomePage(testContext.Properties["webAppTestUrl"].ToString());
            login.LOLALogin(testContext.Properties["webAppTestUserName"].ToString(), testContext.Properties["webAppTestPassword"].ToString());

            ClientClientProfile clientClientProfile = new ClientClientProfile();
            Random rnd = new Random();
            string rndNunmber = rnd.Next(0, 100000).ToString();
            clientClientProfile.FillClient1("John" + rndNunmber, "", "Homeowner" + rndNunmber, "", "", "3135454675", "54675", "", "", "6475244752", "SujahSivasubramaniam" + rndNunmber + "@quickenloans.com");
            //Assert.IsTrue(clientClientProfile.ValidateClientClientProfileGoalsPage());


            ClientClientProfileGoals clientClientProfileGoals = new ClientClientProfileGoals();
            clientClientProfileGoals.FillGoal();
            // Assert.IsTrue(clientClientProfileGoals.ValidateClientClientProfilePropertyPage());


            ClientClientProfileProperty clientClientProfileProperty = new ClientClientProfileProperty();
            clientClientProfileProperty.navigateQuickpal();
        }
        [TestMethod]
        public void CTI()
        {
           

                AdminLoginPage login = new AdminLoginPage(Driver.Instance);
                login.LoadLOLAHomePage(testContext.Properties["webAppTestUrl"].ToString());
                login.LOLALogin("QABANKER1", "Jul@2017");
                DashBoardPipeLineManager dashBoardPipeLineManager = new DashBoardPipeLineManager();
                dashBoardPipeLineManager.NavigateToPipeLineManager();
                Loan loan = new Loan();
                loan.AccessParticularCell(2,15);
                loan.ConfirmCTIAddress(6);


               
            }

      

        [TestCleanup]
        public void CloseDown()
        {
            Driver.Instance.Quit();

        }
    }
}
