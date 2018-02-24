using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using UITestAutomationFrameWork.WebDriverCore;

namespace FreshStartTestCases.FreshStartpageObjectModelPages
{
    public class NewEnrollClient
    {

        public IWebDriver driver;
        public IList<IWebElement> AllElements = new List<IWebElement>();


        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public NewEnrollClient(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public NewEnrollClient()
        {
           
        }
        #endregion

        #region Components


        [FindsBy(How = How.XPath, Using = "//a[@class='navbar-brand'and @href='#']")]
        public IWebElement FreshStartFreshStart_Heading;
        
        [FindsBy(How = How.Id, Using = "btn_new_client")]
        public IWebElement FreshStartNewClient_Button;

        [FindsBy(How = How.Id, Using = "btn_pipeline")]
        public IWebElement FreshStartMyPipeline_Button;

        [FindsBy(How = How.Id, Using = "btn_referral_allocation")]
        public IWebElement FreshStartReferralAllocation_Button;

        [FindsBy(How = How.XPath, Using = "//form[@name='initialForm']/div/div/div/h4")]
        public IWebElement newEnroll_Subheading;

        [FindsBy(How = How.XPath, Using = "//form[@name='initialForm']/div/div/div/div/div/label")]
        public IWebElement newEnrollLoanNumber_Label;

        [FindsBy(How = How.Id, Using = "loan_number_initial")]
        public IWebElement newEnrollLoanNumber_TextBox;

        [FindsBy(How = How.Id, Using = "btn_enroll_loan")]
        public IWebElement newEnrollEntroll_Button;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[1]/div[4]/div")]
        public IWebElement newEnrollClientCheckBoxewes_CheckBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='main']/div/form[1]/div/div/div[1]/div[4]/div[1]")]
        public IWebElement newEnrollClientOnePre_CheckBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='main']/div/form[1]/div/div/div[1]/div[4]/div[1]/input")]
        public IWebElement newEnrollClientOne_CheckBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='main']/div/form[1]/div/div/div[1]/div[4]/div[2]/input")]
        public IWebElement newEnrollClientTwo_CheckBox;

        [FindsBy(How = How.Id, Using = "btn_enroll_clients")]
        public IWebElement newEnrollEntrollClient_Button;

       



        public IList<IWebElement> GetCheckBoxes()
        {
            return driver.FindElements(By.XPath("//input[@*='checkbox']"));
        }
        #endregion
        #region Methods
        public NewEnrollClient NavigateToFreshStartHome(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(6000);
            return new NewEnrollClient(driver);
        }
        public NewEnrollClient EnterLoanNumber(IWebDriver driver, string loanNumber) {
            common.WaitUntilElementSelected(driver, newEnrollLoanNumber_TextBox).SendKeys(loanNumber);
            return new NewEnrollClient(driver);
        }


        public NewEnrollClient NavigateToNewClient(IWebDriver driver, string loanNumber)
        {
            common.WaitUntilElementSelected(driver, FreshStartNewClient_Button, 50, 3).Click();
            common.WaitUntilElementSelected(driver, newEnrollLoanNumber_TextBox).SendKeys(loanNumber);
            return new NewEnrollClient(driver);
        }
        public NewEnrollClient NavigateToClientOption(IWebDriver driver)
        {
            common.WaitUntilElementSelected(driver, newEnrollEntroll_Button, 50, 3).SendKeys(Keys.Return);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return new NewEnrollClient(driver);
        }

        public NewEnrollClient SelectMutipleClient(IWebDriver driver)
        {
            IList<IWebElement> chkBoxes = GetCheckBoxes();
            int counter = chkBoxes.Count;
            foreach (var chkBox in chkBoxes)
            {
                common.WaitUntilElementSelected(driver, chkBox, 50, 3).Click();
            }
            newEnrollEntrollClient_Button.Click();
            return new NewEnrollClient(driver);
        }

        public NewEnrollClient SelectFirstClient(IWebDriver driver)
        {
            common.WaitUntilElementSelected(driver, newEnrollClientOne_CheckBox, 20, 1).Click();
            common.WaitUntilElementSelected(driver, newEnrollEntrollClient_Button, 50, 3).Click();
            return new NewEnrollClient(driver);
        }
        public NewEnrollClient SelectSecondClient(IWebDriver driver)
        {
            common.WaitUntilElementSelected(driver, newEnrollClientTwo_CheckBox, 20, 1).Click();
            common.WaitUntilElementSelected(driver, newEnrollEntrollClient_Button, 20, 1).Click();
            return new NewEnrollClient(driver);
        }


       public IList<IWebElement> CreateListOfAllElements()
        {
            AllElements.Add(FreshStartFreshStart_Heading);
            AllElements.Add(FreshStartNewClient_Button);
            AllElements.Add(FreshStartMyPipeline_Button);
            AllElements.Add(FreshStartReferralAllocation_Button);
            AllElements.Add(newEnroll_Subheading);
            AllElements.Add(newEnrollLoanNumber_Label);
            AllElements.Add(newEnrollLoanNumber_TextBox);
            AllElements.Add(newEnrollEntroll_Button);
            AllElements.Add(newEnrollClientOne_CheckBox);
            AllElements.Add(newEnrollClientTwo_CheckBox);
            AllElements.Add(newEnrollEntrollClient_Button);
            return AllElements;
        }
        
        #endregion
    }
}
