using FreshStartTestCases.FreshStartpageObjectModelPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using UITestAutomationFrameWork.WebDriverCore;

namespace TestAutomationFrameWork.PageObjectModelPages
{
    public class FreshStartHome:NewEnrollClient
    {

        public IWebDriver driver;
        public IList<IWebElement> AllElements = new List<IWebElement>();

        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public FreshStartHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            
        }

        public FreshStartHome()
        {
               
        }
        #endregion

        #region Components

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[3]/div/h4")]
        public IWebElement FreshStartClientSummary_Subheading;

        [FindsBy(How = How.Id, Using = "lbl_loan_number")]
        public IWebElement FreshStartLoanNumber_Label;
        
        [FindsBy(How = How.Id, Using = "loan_Number")]
        public IWebElement FreshStartLoanNumber_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_first_name")]
        public IWebElement FreshStartFirstName_Label;

        [FindsBy(How = How.Id, Using = "first_name")]
        public IWebElement FreshStartFirstName_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_last_name")]
        public IWebElement FreshStartLastName_Label;

        [FindsBy(How = How.Id, Using = "last_name")]
        public IWebElement FreshStartLastName_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_email")]
        public  IWebElement FreshStartEmail_Label;

        [FindsBy(How = How.Id, Using = "email_address")]
        public IWebElement FreshStartEmail_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_phone")]
        public IWebElement FreshStartPhone_Label;

        [FindsBy(How = How.Id, Using = "phone_number")]
        public IWebElement FreshStartPhone_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_current_fico")]
        public IWebElement FreshStartCurrentFICO_Label;

        [FindsBy(How = How.Id, Using = "current_fico")]
        public IWebElement FreshStartCurrentFICO_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_state")]
        public IWebElement FreshStartState_Label;

        [FindsBy(How = How.Id, Using = "state")]
        public IWebElement FreshStartState_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[2]/div/div[2]/div[1]/select/option[4]")]
        public IWebElement FreshStartStateOption_DropDown;

        [FindsBy(How = How.Id, Using = "lbl_status")]
        public IWebElement FreshStartStatus_Label;

        [FindsBy(How = How.Id, Using = "loan_status")]
        public IWebElement FreshStartStatus_DropDown;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[2]/div/div[2]/div[2]/select/option[3]")]
        public IWebElement FreshStartStatusOption_DropDown;

        [FindsBy(How = How.Id, Using = "lbl_loan_program")]
        public IWebElement FreshStartDesiredLoanProgram_Label;

        [FindsBy(How = How.Id, Using = "loan_program")]
        public IWebElement FreshStartDesiredLoanProgram_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[2]/div/div[2]/div[3]/select/option[4]")]
        public IWebElement FreshStartDesiredLoanProgramOption_DropDown;

        [FindsBy(How = How.Id, Using = "lbl_loan_purpose")]
        public IWebElement FreshStartLoanPurpose_Label;

        [FindsBy(How = How.Id, Using = "loan_purpose")]
        public IWebElement FreshStartLoanPurpose_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[2]/div/div[2]/div[4]/select/option[2]")]
        public IWebElement FreshStartLoanPurposeOption_DropDown;

        [FindsBy(How = How.Id, Using = "lbl_target_fico")]
        public IWebElement FreshStartTargetFICO_Label;

        [FindsBy(How = How.Id, Using = "goal_fico")]
        public IWebElement FreshStartTargetFICO_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='lbl_referral']/label")]
        public IWebElement FreshStartReferral_Label;

        [FindsBy(How = How.Id, Using = "is_referral")]
        public IWebElement FreshStartReferral_DropDown;

        [FindsBy(How = How.XPath, Using = "//select[@name='IsReferral']/option[@label='Yes']")]
        public IWebElement FreshStartReferralYes_DropDown;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[2]/div/div[2]/div[6]/select/option[2]")]
        public IWebElement FreshStartReferralNo_DropDown;

        [FindsBy(How = How.Id, Using = "lbl_strategies")]
        public IWebElement FreshStartStrategies_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='planned_action_codes']")]
        public IWebElement FreshStartStrategies_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='planned_action_codes']/div[1]/input")]
        public IWebElement FreshStartStrategiesInside_TextBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='ui-select-choices-row-0-1']/a/span")]
        public IWebElement FreshStartStrategiesAddAuthorisedUser_Option;

        [FindsBy(How = How.XPath, Using = "//div[@id='ui-select-choices-row-0-2']/a/span")]
        public IWebElement FreshStartStrategiesPayDownCreditCard_Option;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[3]/div/div[3]/div[2]/label")]
        public IWebElement FreshStartDateEntrolled_Label;

        [FindsBy(How = How.Id, Using = "date_enrolled")]
        public IWebElement FreshStartDateEntrolled_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_banker")]
        public IWebElement FreshStartMortgageBanker_Label;

        [FindsBy(How = How.Id, Using = "banker_name")]
        public IWebElement FreshStartMortgageBanker_TextBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='panel-body']/div[3]/div[3]/ul/li[2]/a")]
        public IWebElement FreshStartMortgageBankerOption_TextBox;
        
       [FindsBy(How = How.Id, Using = "lbl_lola_status")]
        public IWebElement FreshStartLOLAAMPLoanStatus_Label;

        [FindsBy(How = How.Id, Using = "lola_status")]
        public IWebElement FreshStartLOALAMPLoanStatus_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[2]/div/div[4]/div[1]/select/option[2]")]
        public IWebElement FreshStartLOALAMPLoanStatusOption_DropDown;

        [FindsBy(How = How.Id, Using = "lbl_qlms")]
        public IWebElement FreshStartQLMSLoan_Label;

        [FindsBy(How = How.Id, Using = "is_qlms")]
        public IWebElement FreshStartQLMSLoan_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form[1]/div/div/div[2]/div/div[4]/div[2]/select/option[2]")]
        public IWebElement FreshStartQLMSLoanOption_DropDown;

        [FindsBy(How = How.Id, Using = "col_header_Notes")]
        public IWebElement FreshStartNotes_Label;

        [FindsBy(How = How.Id, Using = "comment_other")]
        public IWebElement FreshStartNotes_TextBox;

        [FindsBy(How = How.Id, Using = "btn_save_info")]
        public IWebElement FreshStartSave_Button;

        [FindsBy(How = How.XPath, Using = "//input[@required='required']")]
        public IWebElement FreshStartEmailRequired_TextBox;
        
        [FindsBy(How = How.Id, Using = "lbl_client_info")]
        public IWebElement FreshStartClientInfo_SubHeading;

        [FindsBy(How = How.Id, Using = "lbl_client1")]
        public IWebElement FreshStartClientInfoClientOne_SubHeading;
        
        [FindsBy(How = How.Id, Using = "lbl_client_firstname")]
        public IWebElement FreshStartClientInfoClientOneFirstName_Label;
        
        [FindsBy(How = How.Id, Using = "client_first_name")]
        public IWebElement FreshStartClientInfoClientOneFirstName_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_client_lastname")]
        public IWebElement FreshStartClientInfoClientOneLastName_Label;

        [FindsBy(How = How.Id, Using = "client_last_name")]
        public IWebElement FreshStartClientInfoClientOneLastName_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_home_phone")]
        public IWebElement FreshStartClientInfoClientOneHomePhone_Label;

        [FindsBy(How = How.Id, Using = "client_phone_number")]
        public IWebElement FreshStartClientInfoClientOneHomePhone_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_client_email")]
        public IWebElement FreshStartClientInfoClientOneEmail_Label;

        [FindsBy(How = How.Id, Using = "client_email_address")]
        public IWebElement FreshStartClientInfoClientOneEmail_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_team_member")]
        public IWebElement FreshStartClientInfoClientOneTeamMember_Label;

        [FindsBy(How = How.Id, Using = "is_team_member")]
        public IWebElement FreshStartClientInfoClientOneTeamMember_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapseClientinfo']/div/label[2]")]
        public IWebElement FreshStartClientInfoClientTwo_SubHeading;

        [FindsBy(How = How.Id, Using = "lbl_coclient_firstname")]
        public IWebElement FreshStartClientInfoClientTwoFirstName_Label;

        [FindsBy(How = How.Id, Using = "coclient_first_Name")]
        public IWebElement FreshStartClientInfoClientTwoFirstName_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapseClientinfo']/div/div[3]/div[2]/label")]
        public IWebElement FreshStartClientInfoClientTwoLastName_Label;

        [FindsBy(How = How.Id, Using = "coclient_lastname")]
        public IWebElement FreshStartClientInfoClientTwoLastName_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_coclient_homephone")]
        public IWebElement FreshStartClientInfoClientTwoHomePhone_Label;

        [FindsBy(How = How.Id, Using = "coclient_phone_number")]
        public IWebElement FreshStartClientInfoClientTwoHomePhone_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_coclient_email")]
        public IWebElement FreshStartClientInfoClientTwoEmail_Label;

        [FindsBy(How = How.Id, Using = "coclient_email")]
        public IWebElement FreshStartClientInfoClientTwoEmail_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_coclient_teammember")]
        public IWebElement FreshStartClientInfoClientTwoTeamMember_Label;

        [FindsBy(How = How.Id, Using = "coclient_teammember")]
        public IWebElement FreshStartClientInfoClientTwoTeamMember_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='goalspanel']/div[1]/h4")]
        public IWebElement FreshStartGoals_SubHeading;

        [FindsBy(How = How.Id, Using = "lbl_client_target_fico")]
        public IWebElement FreshStartGoalsTargetFICO_Label;

        [FindsBy(How = How.Id, Using = "client_goal_fico")]
        public IWebElement FreshStartGoalsTargetFICO_TextBox;
        
        [FindsBy(How = How.Id, Using = "lbl_client_loan_program")]
        public IWebElement FreshStartGoalsDesiredLoanProgram_Label;

        [FindsBy(How = How.Id, Using = "client_loan_program")]
        public IWebElement FreshStartGoalsDesitredLoanProgram_DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='creditPanel']/div[1]/h4")]
        public IWebElement FreshStartCredit_SubHeading;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapseCredit']/div/label[1]")]
        public IWebElement FreshStartCreditClientOne_Label;

        [FindsBy(How = How.Id, Using = "lbl_credit_target_fico")]
        public IWebElement FreshStartCreditClientOneTargetFICO_Label;

        [FindsBy(How = How.Id, Using = "credit_goal_fico")]
        public IWebElement FreshStartCreditClientOneTargetFICO_TextBox;
        
        [FindsBy(How = How.Id, Using = "lbl_credit_current_fico")]
        public IWebElement FreshStartCreditClientOneCurrentFICO_Label;

        [FindsBy(How = How.Id, Using = "credit_current_fico")]
        public IWebElement FreshStartCreditClientOneCurrentFICO_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_client_Strategies")]
        public IWebElement FreshStartCreditClientOneStrategies_Label;

        [FindsBy(How = How.Id, Using = "client_planned_action_codes")]
        public IWebElement FreshStartCreditClientOneStrategies_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapseCredit']/div/label[2]")]
        public IWebElement FreshStartCreditClientTwo_Label;

        [FindsBy(How = How.Id, Using = "lbl_coclient_target_fico")]
        public IWebElement FreshStartCreditClientTwoTargetFICO_Label;

        [FindsBy(How = How.Id, Using = "credit_coclient_goal_fico")]
        public IWebElement FreshStartCreditClientTwoTargetFICO_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_coclient_current_fico")]
        public IWebElement FreshStartCreditClientTwoCurrentFICO_Label;

        [FindsBy(How = How.Id, Using = "credit_coclient_current_fico")]
        public IWebElement FreshStartCreditClientTwoCurrentFICO_TextBox;
        
        [FindsBy(How = How.Id, Using = "lbl_coclient_strategies")]
        public IWebElement FreshStartCreditClientTwoStrategies_Label;

        [FindsBy(How = How.XPath, Using = "//*[@id='coclient_planned_action_Codes']/div[1]")]
        public IWebElement FreshStartCreditClientTwoStrategies_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='propertypanel']/div[1]/h4")]
        public IWebElement FreshStartProperty_SubHeading;

        [FindsBy(How = How.Id, Using = "lbl_address")]
        public IWebElement FreshStartPropertyAddress_Label;

        [FindsBy(How = How.Id, Using = "property_address")]
        public IWebElement FreshStartPropertyAddress_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_unit")]
        public IWebElement FreshStartPropertyUnit_Label;

        [FindsBy(How = How.Id, Using = "property_unit")]
        public IWebElement FreshStartPropertyUnit_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_zipcode")]
        public IWebElement FreshStartPropertyZipCode_Label;

        [FindsBy(How = How.Id, Using = "property_zip_code")]
        public IWebElement FreshStartPropertyZipCode_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_city")]
        public IWebElement FreshStartPropertyCity_Label;

        [FindsBy(How = How.Id, Using = "property_city")]
        public IWebElement FreshStartPropertyCity_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_property_state")]
        public IWebElement FreshStartPropertyState_Label;

        [FindsBy(How = How.Id, Using = "property_state")]
        public IWebElement FreshStartPropertyState_DropDown;

        [FindsBy(How = How.Id, Using = "lbl_property_type")]
        public IWebElement FreshStartPropertyPropertyType_Label;

        [FindsBy(How = How.Id, Using = "property_type")]
        public IWebElement FreshStartPropertyPropertyType_DropDown;

        [FindsBy(How = How.Id, Using = "lbl_property_value")]
        public IWebElement FreshStartPropertyValue_Label;

        [FindsBy(How = How.Id, Using = "property_value")]
        public IWebElement FreshStartPropertyValue_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_Loan_amount")]
        public IWebElement FreshStartPropertyLoanAmount_Label;

        [FindsBy(How = How.Id, Using = "property_loan_amount")]
        public IWebElement FreshStartPropertyLoanAmount_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='IncomePanel']/div[1]/h4")]
        public IWebElement FreshStartPropertyIncomeAssets_SubHeading;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapseIncome']/div/label[1]")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOne_Label;
        
        [FindsBy(How = How.Id, Using = "lbl_employer")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOneEmployer_Label;

        [FindsBy(How = How.Id, Using = "asset_employer")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOneEmployer_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_monthly_income")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOneMonthlyIncome_Label;

        [FindsBy(How = How.Id, Using = "asset_income")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOneMonthlyIncome_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_position")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOnePosition_Label;

        [FindsBy(How = How.Id, Using = "asset_position")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOnePosition_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_liquid_assets")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOneLiquidAssets_Label;

        [FindsBy(How = How.Id, Using = "asset_liquid")]
        public IWebElement FreshStartPropertyIncomeAssetsClientOneLiquidAssets_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapseIncome']/div/label[2]")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwo_Label;

        [FindsBy(How = How.Id, Using = "lbl_coclient_employer")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwoEmployer_Label;

        [FindsBy(How = How.Id, Using = "asset_coclient_employer")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwoEmployer_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_coclient_monthly_income")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwoMonthlyIncome_Label;

        [FindsBy(How = How.Id, Using = "asset_coclient_income")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwoMonthlyIncome_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_coclient_position")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwoPosition_Label;

        [FindsBy(How = How.Id, Using = "asset_coclient_position")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwoPosition_TextBox;

        [FindsBy(How = How.Id, Using = "lbl_coclient_liquid_assets")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwoLiquidAssets_Label;

        [FindsBy(How = How.Id, Using = "asset_coclient_liquid")]
        public IWebElement FreshStartPropertyIncomeAssetsClientTwoLiquidAssets_TextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='lbl_client_info']/a")]
        public IWebElement FreshStartClientInfoCollapsed_Button;


        [FindsBy(How = How.XPath, Using = "//*[@id='creditPanel']/div[1]/h4/a")]
        public IWebElement FreshStartCreditCollapsed_Button;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='IncomePanel']/div[1]/h4/a")]
        public IWebElement FreshStartPropertyCollapsed_Button;


        [FindsBy(How = How.XPath, Using = "//*[@id='IncomePanel']/div[1]/h4/a")]
        public IWebElement FreshStartIncomeAssetCollapsed_Button;


        [FindsBy(How = How.XPath, Using = "//*[@id='NotesPanel']/div[1]/h4/a")]
        public IWebElement FreshStartNotesCollapsed_Button;

        
        #endregion
        #region Methods

        public MyPipeline NavigateToMyPipelineHome(IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(FreshStartMyPipeline_Button).Click().Perform();
            MyPipeline myPipeline = new MyPipeline(driver);
            action.MoveToElement(myPipeline.FreshStartGlobalSearch_Subheading).Perform();
            return new MyPipeline();
        }

        public FreshStartHome NegativeTestForDataType(IWebDriver dreiver,IWebElement element,string data)
        {
            common.WaitUntilElementSelected(driver,element, 1).SendKeys(data);
           return new FreshStartHome();
        }

        public FreshStartHome NegativeTestForMaxLength(string maxString)
        {
            common.WaitUntilElementSelected(driver,FreshStartLoanNumber_TextBox, 1).SendKeys(maxString);
            return new FreshStartHome();

        }
        public FreshStartHome SelectMultipleStrategies(IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(FreshStartStrategiesInside_TextBox).Click().Perform();
            action.MoveToElement(FreshStartStrategiesAddAuthorisedUser_Option).Click().Perform();
            Actions action2 = new Actions(driver);
            action2.MoveToElement(FreshStartStrategiesInside_TextBox).Click().Perform();
            action2.MoveToElement(FreshStartStrategiesPayDownCreditCard_Option).Click().Perform();
            return new FreshStartHome();
        }


        public FreshStartHome ValidateReferralAndMortgageBanker(IWebDriver driver, string Option)
        {
            
            if(common.WaitUntilElementSelected(driver, FreshStartReferralYes_DropDown, 1).Text.Equals(Option))
            {
                Actions action = new Actions(driver);
                action.MoveToElement(FreshStartMortgageBanker_TextBox).Click().Perform();
                action.MoveToElement(FreshStartMortgageBanker_TextBox).SendKeys("ada").Perform();
                Actions action2 = new Actions(driver);
                action2.MoveToElement(FreshStartMortgageBankerOption_TextBox).Click().Perform();
            }else 
            {
                common.ValidatateWebElementAttributeCheck(FreshStartMortgageBanker_TextBox, "disabled=\"disabled\"");
            }

            return new FreshStartHome();
        }

        public FreshStartHome FillNewClient(IWebDriver driver)
        {

            common.ValidatateWebElementAttributeCheck(FreshStartSave_Button, "disabled=\"disabled\"");
            Actions actionLoanNumber = new Actions(driver);
            string loanNumber = common.RandomDigits(10);
            actionLoanNumber.MoveToElement(FreshStartLoanNumber_TextBox).Click().Perform();
            actionLoanNumber.MoveToElement(FreshStartLoanNumber_TextBox).SendKeys(loanNumber).Perform();
            Actions actionFirstName = new Actions(driver);
            actionFirstName.MoveToElement(FreshStartFirstName_TextBox).Click().Perform();
            actionFirstName.MoveToElement(FreshStartFirstName_TextBox).SendKeys("QAFirstname").Perform();
            Actions actionLastName = new Actions(driver);
            actionLastName.MoveToElement(FreshStartLastName_TextBox).Click().Perform();
            actionLastName.MoveToElement(FreshStartLastName_TextBox).SendKeys("QALastname").Perform();
            Actions actionEmail = new Actions(driver);
            actionEmail.MoveToElement(FreshStartEmail_TextBox).Click().Perform();
            actionEmail.MoveToElement(FreshStartEmail_TextBox).SendKeys("QAEmail@test.com").Perform();
            Actions actionPhone = new Actions(driver);
            actionPhone.MoveToElement(FreshStartPhone_TextBox).Click().Perform();
            actionPhone.MoveToElement(FreshStartPhone_TextBox).SendKeys("5868542986").Perform();
            Actions actionCurrentFICO = new Actions(driver);
            actionCurrentFICO.MoveToElement(FreshStartCurrentFICO_TextBox).Click().Perform();
            actionCurrentFICO.MoveToElement(FreshStartCurrentFICO_TextBox).SendKeys("123").Perform();
            Actions actionState = new Actions(driver);
            actionState.MoveToElement(FreshStartState_DropDown).Click().Perform();
            Actions actionState2 = new Actions(driver);
            actionState2.MoveToElement(FreshStartStateOption_DropDown).SendKeys("ARIZONA").Perform();
            actionState2.MoveToElement(FreshStartStateOption_DropDown).SendKeys(Keys.Return).Perform();
            Actions actionStatus = new Actions(driver);
            actionStatus.MoveToElement(FreshStartStatus_DropDown).Click().Perform();
            Actions actionStatus2 = new Actions(driver);
            actionStatus2.MoveToElement(FreshStartStatusOption_DropDown).SendKeys("Back to Banker").Perform();
            actionStatus2.MoveToElement(FreshStartStatusOption_DropDown).SendKeys(Keys.Return).Perform();
            Actions actionDLP = new Actions(driver);
            actionDLP.MoveToElement(FreshStartDesiredLoanProgram_DropDown).Click().Perform();
            Actions actionDLP2 = new Actions(driver);
            actionDLP2.MoveToElement(FreshStartDesiredLoanProgramOption_DropDown).SendKeys("HARP").Perform();
            actionDLP2.MoveToElement(FreshStartDesiredLoanProgramOption_DropDown).SendKeys(Keys.Return).Perform();
            Actions actionLoanpurpose = new Actions(driver);
            actionLoanpurpose.MoveToElement(FreshStartLoanPurpose_DropDown).Click().Perform();
            Actions actionLoanpurpose2 = new Actions(driver);
            actionLoanpurpose2.MoveToElement(FreshStartLoanPurposeOption_DropDown).SendKeys("Purchase").Perform();
            actionLoanpurpose2.MoveToElement(FreshStartLoanPurposeOption_DropDown).SendKeys(Keys.Return).Perform();
            Actions actionTargetFICO = new Actions(driver);
            actionTargetFICO.MoveToElement(FreshStartTargetFICO_TextBox).Click().Perform();
            actionTargetFICO.MoveToElement(FreshStartTargetFICO_TextBox).SendKeys("123").Perform();
            SelectMultipleStrategies(driver);
            Actions actionMortgageBanker = new Actions(driver);
            actionMortgageBanker.MoveToElement(FreshStartMortgageBanker_TextBox).Click().Perform();
            actionMortgageBanker.MoveToElement(FreshStartMortgageBanker_TextBox).SendKeys("ada").Perform();
            Actions actionMortgageBanker2 = new Actions(driver);
            actionMortgageBanker2.MoveToElement(FreshStartMortgageBankerOption_TextBox).Click().Perform();
            Actions actionLOLALoanStatus = new Actions(driver);
            actionLOLALoanStatus.MoveToElement(FreshStartLOALAMPLoanStatus_DropDown).Click().Perform();
            Actions actionLOLALoanStatus2 = new Actions(driver);
            actionLOLALoanStatus2.MoveToElement(FreshStartLOALAMPLoanStatusOption_DropDown).SendKeys("Initial Contact").Perform();
            actionLOLALoanStatus2.MoveToElement(FreshStartLOALAMPLoanStatusOption_DropDown).SendKeys(Keys.Return).Perform();
            Actions actionQLMSLoan = new Actions(driver);
            actionQLMSLoan.MoveToElement(FreshStartQLMSLoan_DropDown).Click().Perform();
            Actions actionQLMSLoan2 = new Actions(driver);
            actionQLMSLoan2.MoveToElement(FreshStartLOALAMPLoanStatusOption_DropDown).SendKeys("Yes").Perform();
            actionQLMSLoan2.MoveToElement(FreshStartLOALAMPLoanStatusOption_DropDown).SendKeys(Keys.Return).Perform();
            Actions actionNotes = new Actions(driver);
            actionNotes.MoveToElement(FreshStartNotes_TextBox).Click().Perform();
            actionNotes.MoveToElement(FreshStartNotes_TextBox).SendKeys("This is a test to validate the Save button become able after filling all fields in the new client page").Perform();
            common.ValidatateWebRemovedElementAttributeCheck(FreshStartSave_Button, "disabled=\"disabled\"");
            Actions actionSave = new Actions(driver);
            actionSave.MoveToElement(FreshStartSave_Button).Click().Perform();
            
            return new FreshStartHome(driver);
        }

        public IList<IWebElement> CreateListOfAllElements()
        {
            // Client Summary
            AllElements.Add(FreshStartClientSummary_Subheading);
            AllElements.Add(FreshStartLoanNumber_Label);
            AllElements.Add(FreshStartLoanNumber_TextBox);
            AllElements.Add(FreshStartFirstName_Label);
            AllElements.Add(FreshStartFirstName_TextBox);
            AllElements.Add(FreshStartLastName_Label);
            AllElements.Add(FreshStartLastName_TextBox);
            AllElements.Add(FreshStartEmail_Label);
            AllElements.Add(FreshStartEmail_TextBox);
            AllElements.Add(FreshStartPhone_Label);
            AllElements.Add(FreshStartPhone_TextBox);
            AllElements.Add(FreshStartCurrentFICO_Label);
            AllElements.Add(FreshStartCurrentFICO_TextBox);
            AllElements.Add(FreshStartState_Label);
            AllElements.Add(FreshStartState_DropDown);
            AllElements.Add(FreshStartStatus_Label);
            AllElements.Add(FreshStartStatus_DropDown);
            AllElements.Add(FreshStartDesiredLoanProgram_Label);
            AllElements.Add(FreshStartLoanPurpose_Label);
            AllElements.Add(FreshStartLoanPurpose_DropDown);
            AllElements.Add(FreshStartTargetFICO_Label);
            AllElements.Add(FreshStartTargetFICO_TextBox);
            AllElements.Add(FreshStartReferral_Label);
            AllElements.Add(FreshStartReferral_DropDown);
            AllElements.Add(FreshStartStrategies_Label);
            AllElements.Add(FreshStartStrategies_TextBox);
            AllElements.Add(FreshStartDateEntrolled_Label);
            AllElements.Add(FreshStartMortgageBanker_Label);
            AllElements.Add(FreshStartMortgageBanker_TextBox);
            AllElements.Add(FreshStartLOLAAMPLoanStatus_Label);
            AllElements.Add(FreshStartLOALAMPLoanStatus_DropDown);
            AllElements.Add(FreshStartQLMSLoan_DropDown);
            //Notes
            AllElements.Add(FreshStartNotes_Label);
            AllElements.Add(FreshStartNotes_TextBox);
            AllElements.Add(FreshStartSave_Button);
            AllElements.Add(FreshStartEmailRequired_TextBox);
            //ClientInfo
            AllElements.Add(FreshStartClientInfo_SubHeading);
            AllElements.Add(FreshStartClientInfoClientOne_SubHeading);
            AllElements.Add(FreshStartClientInfoClientOneFirstName_Label);
            AllElements.Add(FreshStartClientInfoClientOneFirstName_TextBox);
            AllElements.Add(FreshStartClientInfoClientOneLastName_Label);
            AllElements.Add(FreshStartClientInfoClientOneLastName_TextBox);
            AllElements.Add(FreshStartClientInfoClientOneHomePhone_Label);
            AllElements.Add(FreshStartClientInfoClientOneHomePhone_TextBox);
            AllElements.Add(FreshStartClientInfoClientOneEmail_Label);
            AllElements.Add(FreshStartClientInfoClientOneEmail_TextBox);
            AllElements.Add(FreshStartClientInfoClientOneTeamMember_Label);
            AllElements.Add(FreshStartClientInfoClientOneTeamMember_DropDown);
            AllElements.Add(FreshStartClientInfoClientTwo_SubHeading);
            AllElements.Add(FreshStartClientInfoClientTwoFirstName_Label);
            AllElements.Add(FreshStartClientInfoClientTwoFirstName_TextBox);
            AllElements.Add(FreshStartClientInfoClientTwoLastName_Label);
            AllElements.Add(FreshStartClientInfoClientTwoLastName_TextBox);
            AllElements.Add(FreshStartClientInfoClientTwoHomePhone_Label);
            AllElements.Add(FreshStartClientInfoClientTwoHomePhone_TextBox);
            AllElements.Add(FreshStartClientInfoClientTwoEmail_Label);
            AllElements.Add(FreshStartClientInfoClientTwoEmail_TextBox);
            AllElements.Add(FreshStartClientInfoClientTwoTeamMember_Label);
            AllElements.Add(FreshStartClientInfoClientTwoTeamMember_DropDown);
            //Credit
            AllElements.Add(FreshStartCredit_SubHeading);
            AllElements.Add(FreshStartCreditClientOne_Label);
            AllElements.Add(FreshStartCreditClientOneTargetFICO_Label);
            AllElements.Add(FreshStartCreditClientOneTargetFICO_TextBox);
            AllElements.Add(FreshStartCreditClientOneCurrentFICO_Label);
            AllElements.Add(FreshStartCreditClientOneCurrentFICO_TextBox);
            AllElements.Add(FreshStartCreditClientOneStrategies_Label);
            AllElements.Add(FreshStartCreditClientOneStrategies_TextBox);
            AllElements.Add(FreshStartCreditClientTwo_Label);
            AllElements.Add(FreshStartCreditClientTwoTargetFICO_Label);
            AllElements.Add(FreshStartCreditClientTwoTargetFICO_TextBox);
            AllElements.Add(FreshStartCreditClientTwoCurrentFICO_Label);
            AllElements.Add(FreshStartCreditClientTwoCurrentFICO_TextBox);
            AllElements.Add(FreshStartCreditClientTwoStrategies_Label);
            AllElements.Add(FreshStartCreditClientTwoStrategies_TextBox);
            //property
            AllElements.Add(FreshStartProperty_SubHeading);
            AllElements.Add(FreshStartPropertyAddress_Label);
            AllElements.Add(FreshStartPropertyAddress_TextBox);
            AllElements.Add(FreshStartPropertyUnit_Label);
            AllElements.Add(FreshStartPropertyUnit_TextBox);
            AllElements.Add(FreshStartPropertyZipCode_Label);
            AllElements.Add(FreshStartPropertyZipCode_TextBox);
            AllElements.Add(FreshStartPropertyCity_Label);
            AllElements.Add(FreshStartPropertyCity_TextBox);
            AllElements.Add(FreshStartPropertyState_Label);
            AllElements.Add(FreshStartPropertyState_DropDown);
            AllElements.Add(FreshStartPropertyPropertyType_Label);
            AllElements.Add(FreshStartPropertyPropertyType_DropDown);
            AllElements.Add(FreshStartPropertyValue_Label);
            AllElements.Add(FreshStartPropertyValue_TextBox);
            AllElements.Add(FreshStartPropertyLoanAmount_Label);
            AllElements.Add(FreshStartPropertyLoanAmount_TextBox);

            //Income/Asset
            AllElements.Add(FreshStartPropertyIncomeAssets_SubHeading);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOne_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOneEmployer_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOneEmployer_TextBox);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOneMonthlyIncome_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOneMonthlyIncome_TextBox);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOnePosition_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOnePosition_TextBox);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOneLiquidAssets_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientOneLiquidAssets_TextBox);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwo_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwoEmployer_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwoEmployer_TextBox);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwoMonthlyIncome_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwoMonthlyIncome_TextBox);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwoPosition_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwoPosition_TextBox);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwoLiquidAssets_Label);
            AllElements.Add(FreshStartPropertyIncomeAssetsClientTwoLiquidAssets_TextBox);

            //Collapsed Button
            AllElements.Add(FreshStartClientInfoCollapsed_Button);
            AllElements.Add(FreshStartCreditCollapsed_Button);
            AllElements.Add(FreshStartPropertyCollapsed_Button);
            AllElements.Add(FreshStartIncomeAssetCollapsed_Button);
            AllElements.Add(FreshStartNotesCollapsed_Button);

            return AllElements;
        }

        #endregion
        #region Validations
        public bool validateNotesAreAddeddInHistory(string TestData)
        {
            common.WaitUntilElementSelected(driver, FreshStartNotes_TextBox, 1).SendKeys(TestData);
            common.WaitUntilElementSelected(driver, FreshStartCurrentFICO_TextBox, 1).SendKeys("123");
            common.WaitUntilElementSelected(driver, FreshStartStatus_DropDown, 1).SendKeys("Back to Banker");
            common.WaitUntilElementSelected(driver, FreshStartDesiredLoanProgram_DropDown, 1).SendKeys("HARP");
            common.WaitUntilElementSelected(driver, FreshStartTargetFICO_TextBox, 1).SendKeys("111");
            SelectMultipleStrategies(driver);
            ValidateReferralAndMortgageBanker(driver, "Yes");
           common.WaitUntilElementSelected(driver, FreshStartSave_Button, 1).Click();

            return true;
        }
       public bool ValidateCollapsedButtonIsWorking(IWebElement element1, IWebElement element2)
        {
            
            common.WaitUntilElementSelected(driver, element1, 1).Click();
            common.ValidatateWebElementDisplayed(element2);
            common.WaitUntilElementSelected(driver, element1, 1).Click();
            return common.ValidatateWebElementDisplayed(element2);
            
        }
        #endregion
     }
}
