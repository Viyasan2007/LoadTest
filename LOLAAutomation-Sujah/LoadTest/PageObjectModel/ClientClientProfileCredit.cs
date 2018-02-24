using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork.Pages
{
   public class ClientClientProfileCredit : ClientClientProfileAsset
    {
        #region Constructor
        #endregion
        #region Components
        public IWebElement LOLAClientClientProfileGetPrograms_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Get Programs')]"));
            }
        }
        public IWebElement LOLAClientClientProfileCredit_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Credit')]"));
            }
        }
        #endregion
        #region Methods

        public ClientClientProfileGetPrograms FillCredit()
        {
            LOLAClientClientProfileClient1SaveMyData_Button.Click();

            LOLAClientClientProfileClient1SaveAndNext_Button.Click();

            
            return new ClientClientProfileGetPrograms();
        }



        #endregion
        #region Validations

        public bool ValidateClientProfileCredit()
        {
            if (LOLAClientClientProfileGetPrograms_Label.Text.Equals("Get Programs"))
            {
                ValidateClientProfileAssetsColor();
                return true;
            }
            else
            {
                return false;
            }

        }



        public bool ValidateClientProfileCreditColor()
        {
            if (LOLAClientClientProfileCredit_Label.Text.Equals("Credit"))
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
