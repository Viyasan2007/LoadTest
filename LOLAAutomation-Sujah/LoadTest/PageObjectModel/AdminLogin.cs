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
    public class AdminLogin
    {

        public IWebElement webElement;
        public IWebDriver driver;
        WebObjectFunctions common = new WebObjectFunctions();

        public AdminLogin(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public AdminLogin()
        {

        }

        #region Components

        [FindsBy(How = How.Id, Using = "login_username_txt")]
        public IWebElement LOLAAdminLoginUserName_TextBox;

        [FindsBy(How = How.XPath, Using = "//input[@name='h_pPassword']")]
        public IWebElement LOLAAdminLoginPassword_TextBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='login_save']//input[@type='submit']")]
        public IWebElement LOLAAdminLoginLogin_Button;

        #endregion Components


        #region Method

        public AdminLogin NavigateToLoginPage(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            return new AdminLogin(driver);
        }
        public DashBoard NavigateToDashBoard(IWebDriver driver, string userName,string password)
        {
            common.WaitUntilElementSelected(driver, LOLAAdminLoginUserName_TextBox).SendKeys(userName);
            common.WaitUntilElementSelected(driver, LOLAAdminLoginPassword_TextBox).SendKeys(password);
            common.WaitUntilElementSelected(driver, LOLAAdminLoginLogin_Button).Click();

            return new DashBoard(driver);
        }

        //public DashboardBankerAction LoadLOLAHomePage(string url)
        //{

        //    Driver.Instance.Navigate().GoToUrl(url);
        //    return new DashboardBankerAction();

        //}
        //public ClientClientProfile LOLALogin(string username, string password)
        //{
        //    // Driver.Instance.Navigate().Refresh();

        //    LOLAAdminLoginUserName_TextBox.SendKeys(username);

        //    //LOLAAdminLoginPassword_TextBox.Clear();

        //    LOLAAdminLoginPassword_TextBox.SendKeys(password);
        //    //Driver.Instance.Wait(2000);

        //    LOLAAdminLoginLogin_Button.SendKeys(Keys.Return);

        //    Driver.Instance.Wait(5000);

        //    //LOLAAdminLoginLogin_Button.SendKeys(Keys.Return);

        //    /*Actions builder = new Actions(Driver.Instance);
        //    IAction action = builder.Click(LOLAAdminLoginLogin_Button);
        //    action.Perform();*/

        //    //LOLAAdminLoginLogin_Button.Click();

        //    return new ClientClientProfile();
        //}
        //#endregion Method

        //#region Validation

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public bool ValidateClientProfileClientColor()
        //{
        //    if (LOLAClientClientProfileClient_Label.Text.Equals("Client"))
        //    {
        //        ValidateTheTitleColor();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}



        #endregion Validation

    }
}
