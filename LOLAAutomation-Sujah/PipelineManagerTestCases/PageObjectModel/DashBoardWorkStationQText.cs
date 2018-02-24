using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.WebDriverCore;


using System.Collections;
using UITestAutomationFrameWork.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAutomationFrameWork.Pages
{
    public class DashBoardWorkStationQText
    {
        public IWebDriver driver;


        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public DashBoardWorkStationQText(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public DashBoardWorkStationQText()
        {
        }

        #endregion Constructors
        #region Components

        [FindsBy(How = How.Id, Using = "msgText")]
        public IWebElement LOLAQTextMessage_TextBox;

        [FindsBy(How = How.Id, Using = "sendButton")]
        public IWebElement LOLAQTextMessageSend_Button;

        [FindsBy(How = How.XPath, Using = "//input[@name='h_pPassword']")]
        public IWebElement WorkStationQtextSubScreenQtextHeading_Text;

        [FindsBy(How = How.XPath, Using = "//form[@id='qtext_form']/div/div/div/h2")]
        public IWebElement LOLAAdminLoginLogin_Button;

        [FindsBy(How = How.Id, Using = "QtextHelpLink")]
        public IWebElement WorkStationQTextOptInOut_Link;


        [FindsBy(How = How.XPath, Using = "//div[@id='panelClient']/div[contains(@class,'panel-heading')]")]
        public IWebElement WorkStationQTextClientSubHeading_Text;

        [FindsBy(How = How.XPath, Using = "//div[@id='panelClient']/div[2]/div")]
        public IWebElement WorkStationQTextClientNameSubHeading_Text;


        [FindsBy(How = How.XPath, Using = "//div[@id='panelClient']/div[2]/div[2]")]
        public IWebElement WorkStationQTextClientPhoneSubHeading_Text;

        [FindsBy(How = How.XPath, Using = "//div[@id='panelClient']/div[2]/div")]
        public IWebElement WorkStationQTextClientLastTextSubHeading_Text;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'container')]/div[2]/div[3]/div/div")]
        public IWebElement WorkStationQTextLoanInformationSubHeading_Text;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'container')]/div[2]/div[2]/div[2]/div/div/h3")]
        public IWebElement WorkStationQTextRecentTextChatsSubHeading_Text;

        [FindsBy(How = How.XPath, Using = "//div[@id='panelClient']/div[2]/div[2]")]
        public IWebElement WorkStationQTextRecentTextChatsPlus_Button;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'container')]/div[2]/div[3]/div[2]/div/div/div")]
        public IWebElement ViewConversationSubheadingAndClientAndEveryone_Text;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'container')]/div[2]/div[3]/div[3]/div/div")]
        public IWebElement ClientConversationSubheadingAndTextbox_Text;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'container')]/div[2]/div[3]/div[4]/div/div/div")]
        public IWebElement ClientPhoneSubheadingAndDropDown_Text;


        [FindsBy(How = How.Id, Using = "qtextIcon2")]
        public IWebElement CannedResponseSubheadingAndDropdownWithOptions_Text;

        [FindsBy(How = How.Id, Using = "msgText")]
        public IWebElement ConfirmTextBoxForTexting_TextBox;

        [FindsBy(How = How.Id, Using = "sendButton")]
        public IWebElement ConfirmTheSendButton_Button;

        [FindsBy(How = How.XPath, Using = "//div[@id='divOtherLeads']/table/tbody/tr/td")]
        public IWebElement WorkStationQTextRecentTextChatsPlus_List;

        [FindsBy(How = How.XPath, Using = "//select[@id='flyerSelect']/option[4]")]
        public IWebElement CannedResponseIntroduction_Dropdown;

        [FindsBy(How = How.Id, Using = "msgText")]
        public IWebElement CannedResponseIntroductionMessage_Text;

       
        #endregion

      

        #region Methods

        public DashBoardWorkStationQText EnterClientOutboundMessage(string message)
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            LOLAQTextMessage_TextBox.SendKeys(message);
            LOLAQTextMessageSend_Button.Click();
            return new DashBoardWorkStationQText();
        }
        #endregion

        #region Validations
        public DashBoardWorkStationQText ValidateQTextHeadingExist()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            
            string s = WorkStationQtextSubScreenQtextHeading_Text.Text;
            Assert.IsTrue(s.Equals("QText"));
            return new DashBoardWorkStationQText();
        }
        public DashBoardWorkStationQText ValidateQTextOptInOutLinkExist()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            
            string s = WorkStationQTextOptInOut_Link.Text;
            Assert.IsTrue(s.Equals("Click here to learn about Qtext Opt In/Out"));
            return new DashBoardWorkStationQText();
        }


        public DashBoardWorkStationQText ValidateQTextClientPane()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
      
            string s = WorkStationQTextClientSubHeading_Text.Text;
            Assert.IsTrue(s.Equals("Client"));
            string s1 = WorkStationQTextClientNameSubHeading_Text.Text;
            Assert.IsTrue(s1.Equals("Name: Sujah TestOne"));
            string s2 = WorkStationQTextClientPhoneSubHeading_Text.Text;
            Assert.IsTrue(s2.Equals("Phone:"));
            string s3 = WorkStationQTextClientLastTextSubHeading_Text.Text;
            Assert.IsTrue(s3.Equals("Last Text: N/A"));
            return new DashBoardWorkStationQText();
        }
        public DashBoardWorkStationQText ValidateQTextLoanInformationPane()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            string s = WorkStationQTextLoanInformationSubHeading_Text.Text;
            Assert.IsTrue(s.Contains("5317877252"));
            return new DashBoardWorkStationQText();
        }
        public DashBoardWorkStationQText ValidateRecentTextChatsSubheading()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string s = WorkStationQTextRecentTextChatsSubHeading_Text.Text;
            Assert.IsTrue(s.Contains("Recent Text Chats"));
            return new DashBoardWorkStationQText();
        }

        public DashBoardWorkStationQText ValidateViewConversationSubheadingAndClientAndEveryoneDropdown()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            string s = ClientPhoneSubheadingAndDropDown_Text.Text;
            return new DashBoardWorkStationQText();
        }


        public DashBoardWorkStationQText ValidateClientConversationSubheadingAndTextbox()
        {
           driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            string s = ClientConversationSubheadingAndTextbox_Text.Text;
            Assert.IsTrue(s.Contains("Client Conversation"));
            return new DashBoardWorkStationQText();
        }
        public DashBoardWorkStationQText ValidateClientPhoneSubheadingAndDropDown()
        {
           driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            string s = ClientPhoneSubheadingAndDropDown_Text.Text;
           Assert.IsTrue(s.Contains("Client Phone: 586-713-8129 Sujah TestOne"));
            return new DashBoardWorkStationQText();
        }

        public DashBoardWorkStationQText ValidateCannedResponseSubheadingAndDropdownWithOptions()
        {
           driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            string s = CannedResponseSubheadingAndDropdownWithOptions_Text.Text;
            Assert.IsTrue(s.Contains("Canned Responses:"));
            return new DashBoardWorkStationQText();
        }

        public bool ConfirmTextBoxForTexting()
        {
           driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            if (ConfirmTextBoxForTexting_TextBox.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConfirmTheSendButton()
        {
           driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            if (ConfirmTheSendButton_Button.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DashBoardWorkStationQText ConfirmRecentTextChatsPlusIsFunctional()
        {
           driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            WorkStationQTextRecentTextChatsPlus_Button.Click();
            string s = WorkStationQTextRecentTextChatsPlus_List.Text;
           Assert.IsTrue(s.Contains("Sujah TestTwo"));
            return new DashBoardWorkStationQText();
        }

        public DashBoardWorkStationQText ConfirmCannedResponseChooseOneOptionFromDropdown()
        {
           driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            CannedResponseIntroduction_Dropdown.Click();
           
            string s = CannedResponseIntroductionMessage_Text.Text;
            Assert.IsTrue(s.Contains("Hey there. Its QABANKER1 Test from Quicken Loans. Feel free to text me if you need anything."));
            return new DashBoardWorkStationQText();
        }
        #endregion
    }
}
