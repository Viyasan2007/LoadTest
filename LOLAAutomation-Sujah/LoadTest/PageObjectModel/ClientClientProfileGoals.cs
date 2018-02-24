using UITestAutomationFrameWork.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork
{
    public class ClientClientProfileGoals : ClientClientProfile
    {



        #region Constructor
        #endregion
        #region Components

        /*  public IWebElement LOLAClientClientProfileClient1SaveMyData_Button
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
          }*/

        public IWebElement LOLAClientClientProfileGoalHowlongBeInHome_DropDownBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//option[@value='1-3 years']"));
            }
        }
        
        public IWebElement LOLAClientClientProfileGoalFirstTimeHomeBuyer_CheckBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@id='CheckBox']"));
            }
        }
        public IWebElement LOLAClientClientProfileProperty_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Property')]"));
            }
        }

        public IWebElement LOLAClientClientProfileGoals_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Goals')]"));
            }
        }
        #endregion
        #region Methods

        public ClientClientProfileProperty FillGoal()
        {
           
                LOLAClientClientProfileGoalHowlongBeInHome_DropDownBox.Click();

                LOLAClientClientProfileGoalFirstTimeHomeBuyer_CheckBox.Click();

                LOLAClientClientProfileClient1SaveMyData_Button.Click();

                LOLAClientClientProfileClient1SaveAndNext_Button.Click();

            return new ClientClientProfileProperty();
        }
        #endregion
        #region Validations

        public Boolean ValidateClientClientProfilePropertyPage()
        {
            if (LOLAClientClientProfileProperty_Label.Text.Equals("Property"))
            {
                ValidateClientProfileGoalsColor();
               return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateClientProfileGoalsColor()
        {
            if (LOLAClientClientProfileGoals_Label.Text.Equals("Goals"))
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
