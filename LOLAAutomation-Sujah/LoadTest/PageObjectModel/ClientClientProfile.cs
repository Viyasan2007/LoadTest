using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFrameWork.Pages;
using UITestAutomationFrameWork.Pages;

namespace UITestAutomationFrameWork.Pages
{
    public class ClientClientProfile : ClientClientProfileBase
    {

        #region Constructor
        #endregion
        #region Components
        public IWebElement LOLAClientClientProfileClient1FirstName_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBFName']"));
            }
        }


        public IWebElement LOLAClientClientProfileClient1MiddleName_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBMName']"));
            }
        }


        public IWebElement LOLAClientClientProfileClient1LastName_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBLName']"));
            }
        }


        public IWebElement LOLAClientClientProfileClient1Title_DropDownBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//select[@name='h_tBSuffix']"));
            }
        }


        public IWebElement LOLAClientClientProfileClient1NickName_TextBox
        {
            get
            {
                
                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBNickName']"));
            }
        }


        public IWebElement LOLAClientClientProfileClient1HomePhone_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBHomePh']"));
            }
        }


        public IWebElement LOLAClientClientProfileClient1HomePhoneExtension_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBHomePhExt']"));
            }
        }


        public IWebElement LOLAClientClientProfileClient1WorkPhone_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBEmpPh']"));
            }
        }
        public IWebElement LOLAClientClientProfileClient1WorkPhoneExtension_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBEmpPhExt']"));
            }
        }
        public IWebElement LOLAClientClientProfileClient1CellPhone_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBCellPage']"));
            }
        }

        public IWebElement LOLAClientClientProfileClient1Email_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tBEMail']"));
            }
        }


        public IWebElement LOLAClientClientProfileClientLoanPurpose_DropDownBox
        {
            get
            {

               
                return Driver.Instance.FindElement(By.XPath("//option[contains(.,'Purchase')]"));
            }
        }

        public IWebElement LOLAClientClientProfileClient1LeadInteractWithChatYes_RadioButton
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_rChatLead' and @value='Yes']"));
            }
        }




        public IWebElement LOLAClientClientProfileClient1VeteranNo_RadioButton
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@value='1']"));
            }
        }


        public IWebElement LOLAClientClientProfileClient1PrimaryLanguage_RadioButton
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_rSpanish' and @value='No']"));
            }
        }
        public IWebElement LOLAClientClientProfileGoal_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Goals')]"));
            }
        }

        public IWebElement LOLAClientClientProfileClient_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Client')]"));
            }
        }

        public IWebElement Error_Image
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//img[contains(.,'/images/rock/error.gif')]"));
            }
        }
        public IWebElement LOLAClientClientProfileClientAppNumberSearch_TextBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@name='h_tAppSearch']"));
            }
        }
        public IWebElement LOLAClientClientProfileClientGo_Button
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//input[@type='submit' and @value='go']"));
            }
        }

        public IWebElement LOLAClientClientProfileClientOptedIn_Image
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//img[@id='qtextIcon2']"));
            }
        }
        public IWebElement LOLAClientClientProfileCreateNewLead_Form2
        {
            get
            {
                IWebElement form2 = Driver.Instance.FindElement(By.Id("formz2"));
                IWebElement td = form2.FindElement(By.TagName("td"));
                return Driver.Instance.FindElement(By.XPath("//input[@value='Start a new lead']"));
            }
        }
        public IWebElement LOLAClientClientProfileCreateNewLead_Button
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//div[contains(.,'Create New Lead')]"));
            }
        }


       

       
        #endregion
        #region Methods

        public ClientClientProfileGoals FillClient1(string firstName,string middleName,string lastName,string title,string nickName,string homePhone, string homePhoneExt,string workPhone, string workPhoneExt, string cellPhone, string email)
        {

            //LOLAClientClientProfileCreateNewLead_Button_Beta.Click();


            LOLAClientClientProfileCreateNewLead_Button.Click();



            LOLAClientClientProfileClient1FirstName_TextBox.SendKeys(firstName);

            LOLAClientClientProfileClient1LastName_TextBox.SendKeys(lastName);

            LOLAClientClientProfileClient1HomePhone_TextBox.SendKeys(homePhone);

            LOLAClientClientProfileClient1HomePhoneExtension_TextBox.SendKeys(homePhoneExt);

            LOLAClientClientProfileClient1WorkPhone_TextBox.SendKeys(workPhone);

            LOLAClientClientProfileClient1WorkPhoneExtension_TextBox.SendKeys(workPhoneExt);

            LOLAClientClientProfileClient1CellPhone_TextBox.SendKeys(cellPhone);

            LOLAClientClientProfileClient1Email_TextBox.SendKeys(email);
            
           // LOLAClientClientProfileClient1LeadInteractWithChatYes_RadioButton.Click();

            LOLAClientClientProfileClient1VeteranNo_RadioButton.Click();

            LOLAClientClientProfileClient1PrimaryLanguage_RadioButton.Click();

            LOLAClientClientProfileClientLoanPurpose_DropDownBox.Click();


            LOLAClientClientProfileClient1SaveMyData_Button.Click();

            LOLAClientClientProfileClient1SaveAndNext_Button.Click();

            return new ClientClientProfileGoals();

        }
        public ClientClientProfile SeachParticularLead(string leadNumber)
        {
            Driver.Instance.Wait(4000);
            LOLAClientClientProfileClientAppNumberSearch_TextBox.SendKeys(leadNumber);
            Driver.Instance.Wait(2000);
            LOLAClientClientProfileClientGo_Button.SendKeys(Keys.Return);
            Driver.Instance.Wait(4000);
            return new ClientClientProfile();
        }


        public DashBoardWorkStationQText NavigateToOptedInQtext()
        {

            Driver.Instance.Wait(200);
            LOLAClientClientProfileClientOptedIn_Image.Click();

            return new DashBoardWorkStationQText(Driver.Instance);
        }



        #endregion
        #region Validations


        public bool ValidateClientClientProfileGoalsPage()
        {

            if(LOLAClientClientProfileGoal_Label.Text.Equals("Goals"))
            {
                ValidateClientProfileClientColor();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool ValidateClientProfileClientColor()
        {
            if (LOLAClientClientProfileClient_Label.Text.Equals("Client"))
            {
                ValidateTheTitleColor();
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool ValidateOptedInImageExsist()
        {
            if(LOLAClientClientProfileClientOptedIn_Image.Displayed)
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
