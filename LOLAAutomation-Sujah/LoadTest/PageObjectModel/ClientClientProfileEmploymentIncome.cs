using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork.Pages
{
    public class ClientClientProfileEmploymentIncome :ClientClientProfileProperty
    {


        #region Constructor


        #endregion
        #region Components
        public IWebElement LOLAClientClientProfileEmploymentIncomeEmployer_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tEmployer_1']"));
            }
        }
        public IWebElement LOLAClientClientProfileEmploymentIncome_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Employment / Income')]"));
            }
        }




        public IWebElement LOLAClientClientProfileEmploymentIncomeMonthlyIncomeBase_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBaseInc_1']"));
            }
        }

        #endregion
        #region Methods

        public ClientClientProfileNonEmploymentIncome FillEmploymentInCome()
        {


            LOLAClientClientProfileEmploymentIncomeEmployer_TextBox.SendKeys("Quicken Loans");

            LOLAClientClientProfileEmploymentIncomeMonthlyIncomeBase_TextBox.SendKeys("4000");

            LOLAClientClientProfileClient1SaveMyData_Button.Click();

            LOLAClientClientProfileClient1SaveAndNext_Button.Click();

            return new ClientClientProfileNonEmploymentIncome();
        }
        #endregion
        #region Validations
        public bool ValidateClientClientProfileNonEmploymentIncome()
        {

            if (LOLAClientClientProfileEmploymentIncome_Label.Text.Equals("Non-Employment Income"))
            {
                ValidateClientProfileEmploymentIncomeColor();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateClientProfileEmploymentIncomeColor()
        {
            if (LOLAClientClientProfileProperty_Label.Text.Equals("Employment / Income"))
            {
                ValidateTheTitleColor();
                return true;
            }
            else
            {
                return false;
            }

        }


        #endregion

    }
}
