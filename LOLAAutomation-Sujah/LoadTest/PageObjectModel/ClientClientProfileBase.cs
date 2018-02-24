using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork.Pages
{
    public class ClientClientProfileBase
    {


        #region Constructor
        #endregion
        #region Components
        public IWebElement LOLAClientClientProfileClient1SaveMyData_Button
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@value='Save my data']"));
            }
        }
        public IWebElement LOLAClientClientProfileClient1SaveAndNext_Button
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@value='Save and Next']"));
            }
        }

        public IWebElement LOLAClientClientProfileClientColor_Attribute
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[@class='tab_main_s']"));
            }
        }


        #endregion
        #region Methods
        #endregion
        #region Validations


        public bool ValidateTheTitleColor()
        {
            string colorString = LOLAClientClientProfileClientColor_Attribute.GetAttribute("class");
            if (colorString.Equals("tab_main_s"))
            {
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
