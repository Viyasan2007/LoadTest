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

namespace TestAutomationFrameWork.PageObjectModelPages
{
    public class DashBoardBankerAction
    {

        public IWebElement webElement;
       
        public WebDriverWait webDriverWait;
        public IWebDriver driver;


        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public DashBoardBankerAction()
        {
        }

        public DashBoardBankerAction(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        #endregion

    }
}
