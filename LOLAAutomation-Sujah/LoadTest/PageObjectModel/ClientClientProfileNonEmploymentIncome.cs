using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork.Pages
{
    public class ClientClientProfileNonEmploymentIncome :ClientClientProfileProperty
    {


        #region Constructor
        #endregion
        #region Components
        public IWebElement LOLAClientClientProfileAssets_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Assets')]"));
            }
        }
        public IWebElement LOLAClientClientProfileNonEmploymentIncome_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Non-Employment Income')]"));
            }
        }
        #endregion
        #region Methods
        public ClientClientProfileAsset FillNonEmploymentIncome()
        {
            

                LOLAClientClientProfileClient1SaveMyData_Button.Click();

                LOLAClientClientProfileClient1SaveAndNext_Button.Click();
          
            return new ClientClientProfileAsset();
        }
        #endregion
        #region Validations


        public bool ValidateClientProfileNonEmploymentIncome()
        {
            if (LOLAClientClientProfileAssets_Label.Text.Equals("Assets"))
            {
                ValidateClientProfileNonEmploymentIncomeColor();
                return true;
            }
            else
            {
                return false;
            }

        }



        public bool ValidateClientProfileNonEmploymentIncomeColor()
        {
            if (LOLAClientClientProfileNonEmploymentIncome_Label.Text.Equals("Non-Employment Income"))
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
