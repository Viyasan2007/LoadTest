using LoadTest.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.WebDriverCore;

namespace LoadTest.PageObjectModel
{
    public class DashBoard
    {


        public IWebDriver driver;
        WebObjectFunctions common = new WebObjectFunctions();

        public DashBoard(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public DashBoard()
        {

        }

        #region Components

        [FindsBy(How = How.XPath, Using = "//div[contains(.,'Create New Lead')]")]
        public IWebElement LOLADashBoardCreateNewLead_Button;
        #endregion

        #region Methods
         public Client NavigateToClient(IWebDriver driver)
        {
          
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            common.WaitUntilElementSelected(driver, LOLADashBoardCreateNewLead_Button).Click();
           // watch.Stop();
           
            return new Client(driver);
        }

        #endregion



    }
}
