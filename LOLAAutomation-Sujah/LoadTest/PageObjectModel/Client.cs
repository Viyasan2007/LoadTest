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
    public class Client
    {

        public IWebElement webElement;
        public IWebDriver driver;
        WebObjectFunctions common = new WebObjectFunctions();

        public Client(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public Client()
        {

        }

        #region Components

        [FindsBy(How = How.Id, Using = "login_username_txt")]
        public IWebElement LOLAAdminLoginUserName_TextBox;
        #endregion

    }
}
