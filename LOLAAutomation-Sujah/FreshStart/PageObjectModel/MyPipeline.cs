using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using TestAutomationFrameWork.PageObjectModelPages;
using UITestAutomationFrameWork.WebDriverCore;

namespace FreshStartTestCases.FreshStartpageObjectModelPages
{
    public class MyPipeline : FreshStartHome
    {

        public IWebDriver driver;
        public IList<IWebElement> AllElements = new List<IWebElement>();
        public IList<IWebElement> AllElementsSearchPopup = new List<IWebElement>();
        public IList<IWebElement> AllElementsSearchForOneClient = new List<IWebElement>();
        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public MyPipeline(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public MyPipeline()
        {
        }
        #endregion

        #region Components


        [FindsBy(How = How.XPath, Using = "//div[@id='main']//h4[contains(text(),'Global Search')]")]
        public IWebElement FreshStartGlobalSearch_Subheading;

        [FindsBy(How = How.XPath, Using = "//*[@id='global_search']")]
        public IWebElement FreshStartGlobalSearch_TextBox;


        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/div/div[1]/div[2]/h4")]
        public IWebElement FreshStartRecordsPerPage_Subheading;

        [FindsBy(How = How.Id, Using = "items_by_page")]
        public IWebElement FreshStartRecordsPerPage_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/div/div[1]/div[3]/a")]
        public IWebElement FreshStartSearchClients_Hyperlink;

        [FindsBy(How = How.XPath, Using = "//*[@id='consultantsTable']/thead/tr[1]/th[1]")]
        public IWebElement FreshStartTeamMemberLoan_SubHeading;

        [FindsBy(How = How.XPath, Using = "//*[@id='consultantsTable']/thead/tr[1]/th[2]")]
        public IWebElement FreshStartQLMSLoan_SubHeading;

        [FindsBy(How = How.Id, Using = "clear_column_filters")]
        public IWebElement FreshStartClearColumnFilters_SubHeading;

        [FindsBy(How = How.Id, Using = "export_fields")]
        public IWebElement FreshStartExportPipelineRecordsToExcel_SubHeading;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='consultantsTable']/thead/tr[2]/td/div/div/table/tbody/tr/td[1]/label")]
        public IWebElement FreshStartMyPipelineFilters_Label;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='search_filters']/div")]
        public IWebElement FreshStartMyPipelineDateEnrolled_SubHeading;

        [FindsBy(How = How.Id, Using = "select_all_leads")]
        public IWebElement FreshStartMyPipelineSelectAllLeads_CheckBox;

        [FindsBy(How = How.Id, Using = "col_header_loan_number")]
        public IWebElement FreshStartMyPipelineLoanNumber_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='consultantsTable']/thead/tr[3]/th[3]/div[1]/div/button")]
        public IWebElement FreshStartMyPipelineLoanNumberFilter_button;
        
        [FindsBy(How = How.Id, Using = "col_search_loan_number")]
        public IWebElement FreshStartMyPipelineSearchLoanNumber_TextBox;

        [FindsBy(How = How.Id, Using = "col_header_date_enrolled")]
        public IWebElement FreshStartMyPipelineDateEnrolled_Label;
        
        [FindsBy(How = How.Id, Using = "col_header_date_enrolled")]
        public IWebElement FreshStartMyPipelineDateEnrolledFilter_Button;

        [FindsBy(How = How.XPath, Using = "//*[@id='col_search_date_enrolled']/div/label[1]")]
        public IWebElement FreshStartMyPipelineDateEnrolledSearchExact_Label;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='col_search_date_enrolled']/div/div[1]/input")]
        public IWebElement FreshStartMyPipelineDateEnrolledSearchExact_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='col_search_date_enrolled']/div/div[1]/span/button")]
        public IWebElement FreshStartMyPipelineDateEnrolledSearchExact_CalenderButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='col_search_date_enrolled']/div/label[2]")]
        public IWebElement FreshStartMyPipelineDateEnrolledDateRange_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='col_search_date_enrolled']/div/div[2]/input")]
        public IWebElement FreshStartMyPipelineDateEnrolledDateRangeFrom_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='col_search_date_enrolled']/div/div[2]/span/button")]
        public IWebElement FreshStartMyPipelineDateEnrolledDateRangeFrom_CalenderButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='col_search_date_enrolled']/div/div[3]/input")]
        public IWebElement FreshStartMyPipelineDateEnrolledDateRangeTo_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='col_search_date_enrolled']/div/div[3]/span/button")]
        public IWebElement FreshStartMyPipelineDateEnrolledDateRangeTo_CalenderButton;

        [FindsBy(How = How.Id, Using = "col_header_first_name")]
        public IWebElement FreshStartMyPipelineFirstName_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='consultantsTable']/thead/tr[3]/th[5]/div[1]/div/button")]
        public IWebElement FreshStartMyPipelineFirstNameFilter_Button;

        [FindsBy(How = How.Id, Using = "col_search_first_name")]
        public IWebElement FreshStartMyPipelineSearchFirstName_TextBox;

         [FindsBy(How = How.Id, Using = "col_header_last_name")]
        public IWebElement FreshStartMyPipelineLastName_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='consultantsTable']/thead/tr[3]/th[6]/div[1]/div/button")]
        public IWebElement FreshStartMyPipelineLastNameFilter_Button;

        [FindsBy(How = How.Id, Using = "col_search_last_name")]
        public IWebElement FreshStartMyPipelineSearchLastName_TextBox;

        //Search Popup
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/div[1]/h3")]
        public IWebElement MyPipelineSearchPopupPipelienSearch_SubHeading;

        [FindsBy(How = How.Id, Using = "search_mulitple_client")]
        public IWebElement MyPipelineSearchPopupSearchForMultipleClients_RadioButton;

        [FindsBy(How = How.Id, Using = "search_single_client")]
        public IWebElement MyPipelineSearchPopupSearchForOneClient_RadioButton;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[1]/div[1]")]
        public IWebElement MyPipelineSearchPopupDateEntrolled_label;

        [FindsBy(How = How.Id, Using = "date_enrolled_from")]
        public IWebElement MyPipelineSearchPopupDateEnrollFrom_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[1]/div[1]/div/span/button")]
        public IWebElement MyPipelineSearchPopupDateEnrollFromCalendar_Button;
       
        [FindsBy(How = How.Id, Using = "date_enrolled_to")]
        public IWebElement MyPipelineSearchPopupDateEnrollTo_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[1]/div[2]/div/span/button")]
        public IWebElement MyPipelineSearchPopupDateEnrollToCalendar_Button;

        [FindsBy(How = How.Id, Using = "chk_unassigned")]
        public IWebElement MyPipelineSearchPopupUnAssigned_CheckBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[1]/div[3]/div/label")]
        public IWebElement MyPipelineSearchPopupUnAssigned_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[2]/div[2]")]
        public IWebElement MyPipelineSearchPopupSearchByStrategies_Label;
                
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[2]/div[1]")]
        public IWebElement MyPipelineSearchPopupSearchByLeader_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[2]/div[3]")]
        public IWebElement MyPipelineSearchPopupIncludeTheseStatuses_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[3]/div[1]")]
        public IWebElement MyPipelineSearchPopupSearchByConsultant_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[3]/div[2]")]
        public IWebElement MyPipelineSearchPopupSearchByLoanPurpose_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[3]/div[2]")]
        public IWebElement MyPipelineSearchPopupSearchByPropertyState_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='leader_multi_select']/div/button")]
        public IWebElement MyPipelineSearchPopupSearchByLeader_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='consultant']")]
        public IWebElement MyPipelineSearchPopupSearchByConsultant_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='strategies_multi_select']/div/button")]
        public IWebElement MyPipelineSearchPopupSearchByStrategies_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='status_multi_select']/div/button")]
        public IWebElement MyPipelineSearchPopupIncludeTheseStatuses_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='loan_purpose']")]
        public IWebElement MyPipelineSearchPopupSearchByLoanPurpose_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='property_state']")]
        public IWebElement MyPipelineSearchPopupSearchByPropertyState_DropDown;
        
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[4]/div[1]")]
        public IWebElement MyPipelineSearchPopupCurrentFICORange_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[4]/div[1]")]
        public IWebElement MyPipelineSearchPopupCurrentFICORangeFrom_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[4]/div[2]")]
        public IWebElement MyPipelineSearchPopupCurrentFICORangeTo_TextBox;
        
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[5]/div[1]")]
        public IWebElement MyPipelineSearchPopupTargetFICORange_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[5]/div[1]")]
        public IWebElement MyPipelineSearchPopupTargetFICORangeFrom_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[5]/div[2]")]
        public IWebElement MyPipelineSearchPopupTargetFICORangeTo_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[6]/div[1]")]
        public IWebElement MyPipelineSearchPopupFICODiffRange_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[6]/div[1]")]
        public IWebElement MyPipelineSearchPopupFICODiffRangeFrom_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[6]/div[2]")]
        public IWebElement MyPipelineSearchPopupFICODiffRangeTo_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[7]/div[1]")]
        public IWebElement MyPipelineSearchPopupDesiredLoanProgram_Label;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='desired_loan_program']/div/button")]
        public IWebElement MyPipelineSearchPopupDesiredLoanProgram_DropDown;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[2]/div[7]/div[2]")]
        public IWebElement MyPipelineSearchPopupMortgageBanker_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='banker_name']")]
        public IWebElement MyPipelineSearchPopupMortgageBanker_TextBox;

        [FindsBy(How = How.Id, Using = "btn_search")]
        public IWebElement MyPipelineSearchPopupSubmit_Button;

        [FindsBy(How = How.Id, Using = "btn_cancel")]
        public IWebElement MyPipelineSearchPopupCancel_Button;

        // Search For One client
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[1]/div[1]/label")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientAtLeastOneFieldIsRequired_Label;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[1]/div[2]/div[1]")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientLoanNumber_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='loan_Number']")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientLoanNumber_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[1]/div[2]/div[2]")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientFirstName_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='client_first_name']")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientFirstName_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[1]/div[2]/div[3]")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientLastName_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='client_last_name']")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientLastName_TextBox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/fieldset[1]/div[3]/div[1]")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientPhoneNumber_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='client_phone_number']")]
        public IWebElement MyPipelineSearchPopupSearchForOneClientPhoneNumber_TextBox;

        
        #endregion

        #region Methods
        public PipelineSearch NavigateToPipelineSearchPopup(IWebDriver driver)
        {
            FreshStartSearchClients_Hyperlink.Click();
            return new PipelineSearch(driver);
        }


        public PipelineSearch NavigateToPipelineSearchPopupSelectSearchForOneClient(IWebDriver driver)
        {
            MyPipelineSearchPopupSearchForOneClient_RadioButton.Click();
            return new PipelineSearch(driver);
        }


        public IList<IWebElement> CreateListOfAllElements()
        {
            AllElements.Add(FreshStartGlobalSearch_Subheading);
            AllElements.Add(FreshStartGlobalSearch_TextBox);
            AllElements.Add(FreshStartRecordsPerPage_Subheading);
            AllElements.Add(FreshStartRecordsPerPage_TextBox);
            AllElements.Add(FreshStartSearchClients_Hyperlink);
            AllElements.Add(FreshStartTeamMemberLoan_SubHeading);
            AllElements.Add(FreshStartQLMSLoan_SubHeading);
            AllElements.Add(FreshStartClearColumnFilters_SubHeading);
            AllElements.Add(FreshStartExportPipelineRecordsToExcel_SubHeading);
            AllElements.Add(FreshStartMyPipelineFilters_Label);
            AllElements.Add(FreshStartMyPipelineDateEnrolled_SubHeading);
            AllElements.Add(FreshStartMyPipelineSelectAllLeads_CheckBox);
            AllElements.Add(FreshStartMyPipelineLoanNumber_Label);
            AllElements.Add(FreshStartMyPipelineLoanNumberFilter_button);
            AllElements.Add(FreshStartMyPipelineDateEnrolled_Label);
           
            return AllElements;
        }


        public IList<IWebElement> CreateListOfAllElementsForSearchPopup()
        {
            AllElementsSearchPopup.Add(MyPipelineSearchPopupPipelienSearch_SubHeading);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchForMultipleClients_RadioButton);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchForOneClient_RadioButton);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupDateEntrolled_label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupDateEnrollFrom_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupDateEnrollFromCalendar_Button);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupDateEnrollTo_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupDateEnrollToCalendar_Button);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupUnAssigned_CheckBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupUnAssigned_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByStrategies_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByLeader_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupIncludeTheseStatuses_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByConsultant_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByLoanPurpose_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByPropertyState_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByLeader_DropDown);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByConsultant_DropDown);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByStrategies_DropDown);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupIncludeTheseStatuses_DropDown);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByLoanPurpose_DropDown);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSearchByPropertyState_DropDown);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupCurrentFICORange_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupCurrentFICORangeFrom_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupCurrentFICORangeTo_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupTargetFICORange_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupTargetFICORangeFrom_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupTargetFICORangeTo_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupFICODiffRange_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupFICODiffRangeFrom_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupFICODiffRangeTo_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupDesiredLoanProgram_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupDesiredLoanProgram_DropDown);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupMortgageBanker_Label);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupMortgageBanker_TextBox);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupSubmit_Button);
            AllElementsSearchPopup.Add(MyPipelineSearchPopupCancel_Button);
            return AllElementsSearchPopup;
            }

        public IList<IWebElement> CreateListOfAllElementsForSearchForOneClient()
        {
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupPipelienSearch_SubHeading);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForMultipleClients_RadioButton);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClient_RadioButton);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientAtLeastOneFieldIsRequired_Label);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientLoanNumber_Label);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientLoanNumber_TextBox);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientFirstName_Label);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientFirstName_TextBox);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientLastName_Label);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientLastName_TextBox);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientPhoneNumber_Label);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSearchForOneClientPhoneNumber_TextBox);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupSubmit_Button);
            AllElementsSearchForOneClient.Add(MyPipelineSearchPopupCancel_Button);
            return AllElementsSearchForOneClient;
        }

            #endregion



        }
}
