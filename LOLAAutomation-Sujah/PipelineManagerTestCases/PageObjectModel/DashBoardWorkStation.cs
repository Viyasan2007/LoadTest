using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFrameWork.Pages;
using UITestAutomationFrameWork.Pages;
using UITestAutomationFrameWork.WebDriverCore;

namespace TestAutomationFrameWork.LOLAPages
{
    public class DashBoardWorkStation
    {

        #region Constructor
        public IWebElement webElement;

        public WebDriverWait webDriverWait;
        public IWebDriver driver;


        WebObjectFunctions common = new WebObjectFunctions();

        public DashBoardWorkStation(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public DashBoardWorkStation()
        {
        }

        #endregion
        #region Components


        [FindsBy(How = How.Id, Using = "qtextIcon2")]
        public IWebElement LOLADashBoardWorkStationOptedIn_Image;

       
        #endregion
        #region Methods

        public DashBoardWorkStationQText NavigateToQtextSubScreen()
        {

            LOLADashBoardWorkStationOptedIn_Image.Click();
            //Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());
            return new DashBoardWorkStationQText();
        }
        #endregion
        #region Validations
        #endregion

    }
}
