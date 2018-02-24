
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomationFrameWork.PageObjectModelPages;
using PipelineManagerTestCases.PipelineManagerPageObjectModelPages;
using UITestAutomationFrameWork.WebDriverCore;

namespace UITestAutomationFrameWork.Pages
{
    public class AdminLoginPage
    {


        public IWebDriver driver;


        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public AdminLoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        public AdminLoginPage()
        {
        }

        #endregion Constructors
        #region Components

        [FindsBy(How = How.Id, Using = "login_username_txt")]
        public IWebElement LOLAAdminLoginUserName_TextBox;

        [FindsBy(How = How.XPath, Using = "//input[@name='h_pPassword']")]
        public IWebElement LOLAAdminLoginPassword_TextBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='login_save']//input[@type='submit']")]
        public IWebElement LOLAAdminLoginLogin_Button;
        
        #endregion Components


        #region Method
        public DashBoardBankerAction LoadLOLAHomePage(IWebDriver driver,string url)
        {
           
         driver.Navigate().GoToUrl(url);
         return new DashBoardBankerAction();

        }
        public LOLAHome LOLALogin(IWebDriver driver,string username, string password)
        {
            
            common.WaitUntilElementSelected(driver,LOLAAdminLoginUserName_TextBox, 1).SendKeys(username);
            common.WaitUntilElementSelected(driver,LOLAAdminLoginPassword_TextBox, 1).SendKeys(password);
            common.WaitUntilElementSelected(driver,LOLAAdminLoginLogin_Button, 1).SendKeys(Keys.Return);
            return new LOLAHome();
        }
        #endregion Method

      
    }
}
