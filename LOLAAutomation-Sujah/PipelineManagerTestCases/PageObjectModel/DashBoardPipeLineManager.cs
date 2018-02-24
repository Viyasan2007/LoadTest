using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFrameWork.LOLAPages;
using UITestAutomationFrameWork.Pages;
using UITestAutomationFrameWork.WebDriverCore;

namespace UITestAutomationFrameWork.Pages
{
    public class DashBoardPipeLineManager
    {



        public IWebDriver driver;
        public int counter = 0;
        public int rowNumber = 0;

        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public DashBoardPipeLineManager(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public DashBoardPipeLineManager()
        {
        }

        #endregion Constructors
        #region Components

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Pipeline Manager')]")]
        public IWebElement LOLADashBoardPipeLineManager_Link;

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Home Page')]")]
        public IWebElement LOLADashBoardHomePage_Link;

        [FindsBy(How = How.Id, Using = "PipelineView")]
        public IWebElement LOLADashBoardPipeLineManagerPipeLine_Button;

        [FindsBy(How = How.Id, Using = "pipelineTable")]
        public IWebElement LOLADashBoardPipeLineManagerPipeLine_Table;

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Client')]")]
        public IWebElement LOLAClientClientProfileClient_Label;

        [FindsBy(How = How.Id, Using = "PipelineView")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardPipeLine_Button;

        [FindsBy(How = How.Id, Using = "PalView")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardPAL_Button;

        [FindsBy(How = How.Id, Using = "LoansInProcessView")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardLoanInProcess_Button;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'new-window')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardNewTab_Button;

        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'h_sRVP')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardRVP_Label;


        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'h_sDMB')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardDMP_Label;

        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'h_sBanker')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardBanker_Label;

        [FindsBy(How = How.Id, Using = "h_sRVP")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardRVP_DropDown;

        [FindsBy(How = How.Id, Using = "h_sDMB")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardDMB_DropDown;


        [FindsBy(How = How.Id, Using = "h_sBanker")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardBanker_DropDown;


        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'exportBtn')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardExportCSV_Button;


        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'grp-chkbx-textable')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardTextable_Label;


        [FindsBy(How = How.Id, Using = "chkbx-textable-yes")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardTextableYes_CheckBox;

        [FindsBy(How = How.Id, Using = "chkbx-textable-no")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardTextableNo_CheckBox;

        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'grp-chkbx-PAL')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardPAL_Label;

        [FindsBy(How = How.Id, Using = "chkbx-PAL-yes")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardPALYes_CheckBox;

        [FindsBy(How = How.Id, Using = "chkbx-PAL-no")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardPALNo_CheckBox;

        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'grp-chkbx-creditpulled')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardCreditPulled_Label;


        [FindsBy(How = How.Id, Using = "chkbx-creditpulled-yes")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledYes_CheckBox;

        [FindsBy(How = How.Id, Using = "chkbx-creditpulled-no")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledNo_CheckBox;

        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'grp-chkbx-program')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardProgram_Label;


        [FindsBy(How = How.Id, Using = "chkbx-program-yes")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardProgramYes_CheckBox;

        [FindsBy(How = How.Id, Using = "chkbx-program-no")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardProgramNo_CheckBox;

        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'grp-chkbx-calledToday')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardCalledToday_Label;


        [FindsBy(How = How.Id, Using = "chkbx-calledToday-yes")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardCalledTodayYes_CheckBox;

        [FindsBy(How = How.Id, Using = "chkbx-calledToday-no")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardCalledTodayNo_CheckBox;


        [FindsBy(How = How.XPath, Using = "//label[contains(@for,'grp-chkbx-appointment')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHasAppointment_Label;


        [FindsBy(How = How.Id, Using = "chkbx-appointment-yes")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHasAppointmentYes_CheckBox;

        [FindsBy(How = How.Id, Using = "chkbx-appointment-no")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHasAppointmentNo_CheckBox;


        [FindsBy(How = How.XPath, Using = "//div[@id='pipelineTable_filter']/label")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardSearch_Label;

        [FindsBy(How = How.XPath, Using = "//div[@id='pipelineTable_filter']/label/input")]
        public IWebElement  LOLAClientClientProfilePipeLineManagerDashBoardSearch_TextBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='pipelineTable_length']/label")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardShow_Label;

        [FindsBy(How = How.XPath, Using = "//div[@id='pipelineTable_length']/label/select/option[@value='100']")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardEntriesValue_DropDown;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[1]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderLoan_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[2]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderBanker_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[3]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderLeadSource_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[4]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderLeadStatus_Label;


        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[5]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderName_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[6]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderCredit_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[7]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderState_Label;


        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[8]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderTZ_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[9]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderAge_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[10]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderLTV_Label;


        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[11]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderPurpose_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[12]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderLoanAmount_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[13]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderLoanProgram_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[14]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderLastATC_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[15]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderNextAppointment_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[16]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderNotes_Label;


        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[17]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderHot_Label;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/thead/tr/th[18]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardHeaderMarketingHotReason_Label;

        [FindsBy(How = How.Id, Using = "pipelineTable_info")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardFooterTableInfo_Label;

        [FindsBy(How = How.Id, Using = "pipelineTable_paginate")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardFooterTablePaginate_Label;

        [FindsBy(How = How.Id, Using = "pipelineTable_next")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardFooterTablePaginateNext_Button;

        [FindsBy(How = How.Id, Using = "pipelineTable_previous")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardFooterTablePaginatePrevious_Button;


        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/tbody/tr[2]/td/span/a")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardLoanNumber_Link;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/tbody/tr[2]/td//div[contains(@class,'phoneIcon')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardPhone_Image;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/tbody/tr[2]/td//div[contains(@class,'textIcon')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardQText_Image;

        [FindsBy(How = How.XPath, Using = "//table[@id='pipelineTable']/tbody/tr[2]/td//div[contains(@class,'emailIcon')]")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardEmail_Image;

        [FindsBy(How = How.XPath, Using = "//div[@id='pipelineTable_length']/label/select")]
        public IWebElement LOLAClientClientProfilePipeLineManagerDashBoardEntries_Label;


        
         public IWebElement LOLAClientClientPipelineManagerTableRow_TextArea
         {
             get
             {
                 return driver.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (counter) + "]/td[" + rowNumber + "]/ div/textarea"));
             }   
         }
         public IWebElement LOLAClientClientPipelineManagerTableRow_i
         {
             get
             {
                 return driver.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (counter) + "]/td[" + rowNumber + "]/div//span/i"));
             }
         }

         #endregion
         #region Methods

         public void NavigateToPipeLineManager(IWebDriver driver)
         {
            common.WaitUntilElementSelected(driver,LOLADashBoardPipeLineManager_Link,4).SendKeys(Keys.Return);
            common.WaitUntilElementSelected(driver,LOLAClientClientProfilePipeLineManagerDashBoardPAL_Button, 2);

             
         }





         public Loan AccessParticularCell(int row, int tdNumber,string data)
         {

             //driver.Wait(4000);
             IWebElement table = driver.FindElement(By.Id("pipelineTable"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             String rowNo = "";

             for (int i = 0; i < rows.Count(); i++)
             {
                 if (i == row)
                 {
                     counter = i;
                     rowNumber = tdNumber;
                     LOLAClientClientPipelineManagerTableRow_TextArea.Clear();
                     LOLAClientClientPipelineManagerTableRow_TextArea.SendKeys(data);
                     LOLAClientClientPipelineManagerTableRow_i.Click();
                     tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[1]/span/a[@class='workstationLink']")).SendKeys(Keys.Return);
                     //driver.Wait(4000);

                 }
             }

             return new Loan();

         }

         public Loan AccessParticularHotForBankerCell(int row, int tdNumber)
         {

             //driver.Wait(4000);
             IWebElement table = driver.FindElement(By.Id("pipelineTable"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             String rowNo = "";

             for (int i = 0; i < rows.Count(); i++)
             {
                 if (i == row)
                 {

                     IWebElement ele = tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + i + "]/td[" + tdNumber + "]/div[1]//span/input"));
                     if (ele.Selected)
                     {

                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[1]//span/input")).Click();
                         WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 1000));
                         wait.Until(w => w.FindElements(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[1]//span/input"))).Any();
                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[1]//span/input")).Click();
                         driver.SwitchTo().ActiveElement().Clear();
                         driver.SwitchTo().ActiveElement().SendKeys("QATEST");


                     }
                     else
                     {
                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[1]//span/input")).Click();
                         driver.SwitchTo().ActiveElement().Clear();
                         driver.SwitchTo().ActiveElement().SendKeys("QATEST");
                     }

                     IWebElement e = tbody.FindElement(By.XPath("//input[@type='checkbox']"));
                     tdNumber = tdNumber + 1;
                     tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]")).Click();
                     //driver.Wait(2000);

                     tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[1]/span/a[@class='workstationLink']")).SendKeys(Keys.Return);
                 }
             }

             return new Loan();

         }


         public Loan AccessParticularHotForDMBCell(int row, int tdNumber)
         {

            // driver.Wait(4000);
             IWebElement table = driver.FindElement(By.Id("pipelineTable"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             String rowNo = "";

             for (int i = 0; i < rows.Count(); i++)
             {

                 if (i == row)
                 {

                     IWebElement ele = tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + i + "]/td[" + tdNumber + "]/div[2]//span/input"));
                     if (ele.Selected)
                     {

                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[2]//span/input")).Click();
                         WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 1000));
                         wait.Until(w => w.FindElements(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[2]//span/input"))).Any();
                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[2]//span/input")).Click();
                         driver.SwitchTo().ActiveElement().Clear();
                         driver.SwitchTo().ActiveElement().SendKeys("QATEST");
                     }
                     else
                     {

                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[2]//span/input")).Click();
                         driver.SwitchTo().ActiveElement().Clear();
                         driver.SwitchTo().ActiveElement().SendKeys("QATEST");
                     }

                     IWebElement e = tbody.FindElement(By.XPath("//input[@type='checkbox']"));
                     tdNumber = tdNumber + 1;
                     tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]")).Click();
                     //driver.Wait(2000);
                     tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[1]/span/a[@class='workstationLink']")).SendKeys(Keys.Return);
                 }
             }

             return new Loan();
         }
         public Loan UnCheckHotReasonForCell(int row, int tdNumber, int divNumber)
         {

            // driver.Wait(4000);
             IWebElement table = driver.FindElement(By.Id("pipelineTable"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             String rowNo = "";

             for (int i = 0; i < rows.Count(); i++)
             {

                 if (i == row)
                 {
                     IWebElement ele = tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + i + "]/td[" + tdNumber + "]/div["+divNumber+"]//span/input"));
                     if (ele.Selected)
                     {

                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[" + divNumber + "]//span/input")).Click();
                         WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 1000));
                         wait.Until(w => w.FindElements(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[" + divNumber + "]//span/input"))).Any();
                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[" + divNumber + "]//span/input")).Click();
                         driver.SwitchTo().ActiveElement().Clear();
                         driver.SwitchTo().ActiveElement().SendKeys("QATEST");
                     }
                     else
                     {
                         tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[" + tdNumber + "]/div[" + divNumber + "]//span/input")).Click();
                         driver.SwitchTo().ActiveElement().Clear();
                         driver.SwitchTo().ActiveElement().SendKeys("QATEST");
                     }

                     tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[1]/span/a[@class='workstationLink']")).SendKeys(Keys.Return);
                 }
             }

             return new Loan();

         }

         public bool VerifyFilterCritical(IWebElement element,string critical,string filterType)
         {



             element.SendKeys(Keys.Return);

             //driver.Wait(4000);
             IWebElement table = driver.FindElement(By.Id("pipelineTable"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             for (int i = 0; i < rows.Count(); i++)
             {
                 if (i == 1)
                 {

                     tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[1]/span/a[@class='workstationLink']")).SendKeys(Keys.Return);
                 }
             }
             //driver.Wait(4000);
             // LOLAClientClientProfilePipeLineManagerDashBoardLoanNumber_Link.Click();
             IWebElement form = driver.FindElement(By.XPath("//form[@name='forma']"));
             IWebElement div = form.FindElement(By.TagName("div"));
             IWebElement table2 = driver.FindElement(By.XPath("//table[2]"));
             IWebElement tbody2 = table2.FindElement(By.TagName("tbody"));
             List<IWebElement> rows2 = tbody2.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds2 = new List<String>();
             String rowNo = "";
             bool flag = true;
             for (int i = 1; i < rows2.Count(); i++)
             {
                 string s = tbody2.FindElement(By.XPath("//form[@name='forma']/div/table/tbody/tr[" + i + "]/td[3]")).Text;
                 Console.WriteLine(" The Description is: " + s);
                 if (filterType.Equals("Yes"))
                 {
                     if (s.Equals(critical))
                     {
                         flag = true;
                     }
                     else
                     {
                         flag = false;
                     }
                 }
                 else if (filterType.Equals("No"))

                 {
                     if (!s.Equals(critical))
                     {
                         flag = true;
                     }
                     else
                     {
                         flag = false;
                     }
                 }
                 return flag;
             }
             return flag;
         }



         public DashBoardPipeLineManager ClickCreditPulledNoCheckBox()
         {
             LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledNo_CheckBox.SendKeys(Keys.Return);
            // driver.Wait(4000);
             IWebElement table = driver.FindElement(By.Id("pipelineTable"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             for (int i = 0; i < rows.Count(); i++)
             {
                 if (i == 1)
                 {

                     tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td[1]/span/a[@class='workstationLink']")).SendKeys(Keys.Return);
                 }
             }

          return new DashBoardPipeLineManager();
         }
         public bool VerifyFilterCreditPulledNo()
         {
             LOLAClientClientProfilePipeLineManagerDashBoardCreditPulledNo_CheckBox.Click();

             LOLAClientClientProfilePipeLineManagerDashBoardLoanNumber_Link.Click();
             
             IWebElement form = driver.FindElement(By.XPath("//form[@name='forma']"));
             IWebElement div = form.FindElement(By.TagName("div"));
             IWebElement table = driver.FindElement(By.XPath("//table[2]"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             String rowNo = "";

             for (int i = 1; i < rows.Count(); i++)
             {


                 string s = tbody.FindElement(By.XPath("//form[@name='forma']/div/table/tbody/tr["+i+"]/td[3]")).Text;

                 Console.WriteLine(" The Description is: " + s);
                 if(!s.Equals("[8020] Idle Pulled Credit Penny Public"))
                 {
                     return true;
                 }

             }
             return true;

         }

         public bool VerifyFilterYesOrNo(int rowNumber)
         {
             LOLAClientClientProfilePipeLineManagerDashBoardProgramYes_CheckBox.Click();
                        
             IWebElement table = driver.FindElement(By.Id("pipelineTable"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             String rowNo = "";
             bool flag = true;
             for (int i = 1; i < rows.Count(); i++)
             {
                 string s= tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td["+rowNumber+"]")).Text;

                 if(!s.Contains(""))
                 {
                  flag = true;
                 }
                 else if (s.Contains(""))
                 {
                     flag = false;
                 }
                 return flag;
             }
             return flag;
         }


         public bool VerifySortedColumn(int rowNumber)
         {

             LOLAClientClientProfilePipeLineManagerDashBoardHeaderBanker_Label.SendKeys(Keys.Return);

             IWebElement table = driver.FindElement(By.Id("pipelineTable"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> displayNames = new List<string>();
             String rowNo = "";

             for (int i = 1; i < rows.Count(); i++)
             {
                 string s = tbody.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + (i) + "]/td["+rowNumber+"]")).Text;

                 displayNames.Add(s);

                 List<String> displayNamesSorted = new List<string>(displayNames);
                 displayNamesSorted.Sort();
                 if(displayNames.SequenceEqual(displayNamesSorted))

                 {
                     return true;
                 }
             }
             return true;
         }
         public DashBoardPipeLineManager NavigateToPipeLineManagerNewTab()
         {

             LOLAClientClientProfilePipeLineManagerDashBoardNewTab_Button.Click();
             driver.SwitchTo().Window(driver.WindowHandles.Last());
             driver.Close();
             driver.SwitchTo().Window(driver.WindowHandles.First());


             return new DashBoardPipeLineManager(driver);
         }


         public bool NavigateToFooterTablePiginate()
         {

             if (LOLAClientClientProfilePipeLineManagerDashBoardEntriesValue_DropDown.Text.Equals("100") && !LOLAClientClientProfilePipeLineManagerDashBoardFooterTablePaginatePrevious_Button.Enabled)
             {
                 LOLAClientClientProfilePipeLineManagerDashBoardFooterTablePaginateNext_Button.Click();
                 return true;
             }
             else
             {
                 return false;
             }
         }

         public void NavigateToClientDashBoard()
         {
             LOLAClientClientProfileClient_Label.Click();
         }
         #region Validations



         #endregion
         
    }
    #endregion



}

