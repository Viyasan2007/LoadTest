using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork.Pages
{
    public class ClientClientProfileAsset : ClientClientProfileNonEmploymentIncome
    {
        #region Constructor
        #endregion
        #region Components
        public IWebElement LOLAClientClientProfileCredit_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Credit')]"));
            }
        }
       
        #endregion
        #region Methods


        public ClientClientProfileCredit FillAssets()
        {
                LOLAClientClientProfileClient1SaveMyData_Button.Click();

                LOLAClientClientProfileClient1SaveAndNext_Button.Click();
         return new ClientClientProfileCredit();
        }
        #endregion
        #region Validations

        public bool ValidateClientProfileAssets()
        {
            if (LOLAClientClientProfileCredit_Label.Text.Equals("Credit"))
            {
                ValidateClientProfileAssetsColor();
                return true;
            }
            else
            {
                return false;
            }

        }



        public bool ValidateClientProfileAssetsColor()
        {
            if (LOLAClientClientProfileAssets_Label.Text.Equals("Assets"))
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
