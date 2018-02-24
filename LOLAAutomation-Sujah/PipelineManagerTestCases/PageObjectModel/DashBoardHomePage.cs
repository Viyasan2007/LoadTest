using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;
using UITestAutomationFrameWork.WebDriverCore;

namespace TestAutomationFrameWork.LOLAPages
{
    public class DashBoardHomePage
    {


        #region Constructor
        WebObjectFunctions common = new WebObjectFunctions();
        public IWebElement webElement;

        public WebDriverWait webDriverWait;
        public IWebDriver driver;

        public DashBoardHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public DashBoardHomePage()
        {
        }
        #endregion
        #region Components

        [FindsBy(How = How.XPath, Using = "//input[@name='h_tAppSearch']")]
        public IWebElement LOLADashBoardHomePageLeadSearch_TextBox;


        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement LOLADashBoardHomePageLEadSearchGo_Button;

      
        #endregion
        #region Methods

        public DashBoardWorkStation NavigateToParticularLead(string leadNumber)
        {
            LOLADashBoardHomePageLeadSearch_TextBox.SendKeys(leadNumber);

            LOLADashBoardHomePageLEadSearchGo_Button.Click();

            return new DashBoardWorkStation();
        }

        #endregion
        #region Validations
        #endregion




    }
}
