using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork.Pages
{
   public class ClientClientProfileGetPrograms: ClientClientProfileCredit
    {
        #region Constructor
        #endregion
        #region Components



        public IWebElement LOLAClientClientProfileGetProgramsMonthlyDebt_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tOtherDebt']"));
            }
        }


        public IWebElement LOLAClientClientProfileGetProgramsSelfCreditRating_DropDown
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//select[@name='h_sCreditRating']/option[@value='721']"));
            }
        }


        public IWebElement LOLAClientClientProfileGetProgramsPropertyType_DropDown
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//select[@name='h_sPropType']/option[@value='Site Condominium']"));
            }
        }
        public IWebElement LOLAClientClientProfileGetPrograms_Button
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@id='Get Programs']"));
            }
        }



        public IWebElement LOLAClientClientProfileGetProgramsCounty_DropDown
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//select[@name='h_sPCounty']/option[@value='Alger']"));
            }
        }



        public IWebElement LOLAClientClientProfileGetProgramsPurchasePrice_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tPurchPr']"));
            }
        }
        #endregion
        #region Methods
        public void GetPrograms()
        {
            Driver.Instance.Wait(100);
            LOLAClientClientProfileGetProgramsMonthlyDebt_TextBox.SendKeys("500");
            Driver.Instance.Wait(100);
            LOLAClientClientProfileGetProgramsSelfCreditRating_DropDown.Click();
            Driver.Instance.Wait(100);

            LOLAClientClientProfileGetProgramsCounty_DropDown.Click();
            LOLAClientClientProfileGetProgramsPurchasePrice_TextBox.Clear();
            LOLAClientClientProfileGetProgramsPurchasePrice_TextBox.SendKeys("100000");
            LOLAClientClientProfileGetProgramsPropertyType_DropDown.Click();
            Driver.Instance.Wait(100);
            LOLAClientClientProfileGetPrograms_Button.Click();
        }

        #endregion
        #region Validations
        #endregion



    }
}
