using APIHelper.Utility;
using APIUtility.APIHelper;
using FreshStartTestCases.FreshStartpageObjectModelPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Configuration;
using System.Text.RegularExpressions;
using TestAutomationFrameWork;
using TestAutomationFrameWork.PageObjectModelPages;
using UITestAutomationFrameWork.Pages;
using UITestAutomationFrameWork.WebDriverCore;

namespace FreshStart.TestMethods
{
    public class ClientSummaryAutoFill
    {
        private static string url;
        public static IWebDriver driver;
        public static FreshStartHome freshStart;
        public static WebObjectFunctions commonhelper;
        public static NewEnrollClient newEnroll;
        public static MyPipeline myPipeline;
        public static CommonAPIHelper apiHelper;
        public static PipelineSearch pipelineSearch;
        public static Panorama_ClientDetails clientDetail;
        public static Panorama_SecondClientDetails secondClientDetails;
        public static APIUtilityFunctions ApiUtilityFunction;
        public static string value = null;
        public static string valueClientTwoFirstName = null;
        public static string valueClientTwoLastName = null;
        public static string valueFirstName = null;
        public static string valueLastName = null;
        public static string valueEmail = null;
        public static string valuePhone = null;
        public static string pattern = @"[\(\)\s\-)]";
        public static string valueClientOneFirstName = null;
        public static string valueClientOneLastName = null;
        public static string valueClientOnePhone = null;
        public static string valueClientOneEmail = null;
        public static string valuePropertyAddress = null;
        public static string substringValue = null;
        public static string valuePropertyCity = null;
        public ClientSummaryAutoFill(IWebDriver driver)
        {
            driver = Driver.Initialize("IE");
            PageFactory.InitElements(driver, this);
        }

        public ClientSummaryAutoFill()
        {
        }

        public void GetAllAPIForClientOne(IWebDriver driver)
        {

            ApiUtilityFunction = new APIUtilityFunctions(driver);
            string response = apiHelper.GetAPIGetMethodResponse(driver,"http://mobiusbttest/api/loans/", "","3291199122");
            string gcid = ApiUtilityFunction.findGCidFormGcidMappingItem(driver,response);
            string panoramanResponse = apiHelper.GetAPIGetMethodResponse(driver,"http://panoramatest/api/clients/","", gcid);
            clientDetail = apiHelper.clientDetailsResult(panoramanResponse);
        }
        public string GetAPIClientFirstname()
        {
            return clientDetail.FirstName;
        }

        public string GetAPIClientLastname()
        {
            return clientDetail.LastName;
        }

        public string GetAPIClientEmail()
        {
            return clientDetail.CurrentEmailAddress.EmailAddress;
        }
        public string GetAPIClientPhone()
        {
            return clientDetail.CommunicationPreferences[4].CommunicationAddress;
        }

        public string GetAPIClientOneFirstname()
        {
            return clientDetail.FirstName;
        }

        public string GetAPIClientOneLastname()
        {
            return clientDetail.LastName;
        }

        public string GetAPIClientOneEmail()
        {
            return clientDetail.CurrentEmailAddress.EmailAddress;
        }
        public string GetAPIClientOnePhone()
        {
            return clientDetail.CommunicationPreferences[4].CommunicationAddress;
        }
        public string GetAPIPropertyAddress()
        {
            return clientDetail.MailingAddress.Address1;
        }
        public string GetAPIPropertyCity()
        {
            return clientDetail.MailingAddress.City;
        }
        public void GetAllAPIForClientTwo(IWebDriver driver)
        {
            apiHelper = new CommonAPIHelper(driver);
            ApiUtilityFunction = new APIUtilityFunctions(driver);
            string response = apiHelper.GetAPIGetMethodResponse(driver, "http://mobiusbttest/api/loans/", "3", "3396686053");
            string gcid = ApiUtilityFunction.findGCidFormSourceReferenceId(driver, response);
            string panoramanResponse = apiHelper.GetAPIGetMethodResponse(driver, "http://panoramatest/api/clients/", "", gcid);
            secondClientDetails = apiHelper.SecondClientDetailsResult(panoramanResponse);
        }
        public string GetAPIClientTwoEmailAddress()
        {
            return secondClientDetails.CommunicationPreferences[0].CommunicationAddress;
        }
        public string GetAPIClientTwoFirstName()
        {
            return secondClientDetails.FirstName;
        }
        public string GetAPIClientTwoLastName()
        {
            return secondClientDetails.LastName;
        }
        public void GetAllValueForClientTwo(IWebDriver driver)
        {
            freshStart = new FreshStartHome(driver);
            commonhelper = new WebObjectFunctions(driver);
            newEnroll = new NewEnrollClient(driver);
            myPipeline = new MyPipeline(driver);
            apiHelper = new CommonAPIHelper(driver);
            pipelineSearch = new PipelineSearch(driver);
            string freshStartUrl = ConfigurationManager.AppSettings["FreshStartUrl"];
            newEnroll.NavigateToNewClient(driver, ConfigurationManager.AppSettings["LoanForTwo"]);
            newEnroll.NavigateToClientOption(driver);
            newEnroll.SelectMutipleClient(driver);
            value = freshStart.FreshStartClientInfoClientTwoEmail_TextBox.GetAttribute("value");
            valueClientTwoFirstName = freshStart.FreshStartClientInfoClientTwoFirstName_TextBox.GetAttribute("value");
            valueClientTwoLastName = freshStart.FreshStartClientInfoClientTwoLastName_TextBox.GetAttribute("value");
        }
        public void GetAllValueForClientOne(IWebDriver driver)
        {
            freshStart = new FreshStartHome(driver);
            commonhelper = new WebObjectFunctions(driver);
            newEnroll = new NewEnrollClient(driver);
            myPipeline = new MyPipeline(driver);
            apiHelper = new CommonAPIHelper(driver);
            pipelineSearch = new PipelineSearch(driver);
            //secondClientDetails = new Panorama_SecondClientDetails(driver);
            newEnroll.NavigateToFreshStartHome(driver, ConfigurationManager.AppSettings["FreshStartUrl"]);
            newEnroll.EnterLoanNumber(driver, ConfigurationManager.AppSettings["LoanNumber"]);
            newEnroll.NavigateToClientOption(driver);
            newEnroll.SelectFirstClient(driver);
            valueFirstName = freshStart.FreshStartFirstName_TextBox.GetAttribute("value");
            valueLastName = freshStart.FreshStartLastName_TextBox.GetAttribute("value");
            valueEmail = freshStart.FreshStartEmail_TextBox.GetAttribute("value");
            valuePhone = freshStart.FreshStartPhone_TextBox.GetAttribute("value");
            valueClientOneFirstName = freshStart.FreshStartClientInfoClientOneFirstName_TextBox.GetAttribute("value");
            valueClientOneLastName = freshStart.FreshStartClientInfoClientOneLastName_TextBox.GetAttribute("value");
            valueClientOnePhone = freshStart.FreshStartClientInfoClientOneHomePhone_TextBox.GetAttribute("value");
            valueClientOneEmail = freshStart.FreshStartClientInfoClientOneEmail_TextBox.GetAttribute("value");
            valuePropertyAddress = freshStart.FreshStartPropertyAddress_TextBox.GetAttribute("value");
            valuePropertyCity = freshStart.FreshStartPropertyCity_TextBox.GetAttribute("value");
            substringValue = valuePropertyAddress.Substring(0, 11);
        }
         public string GetValueClientTwoEmailAddress()
        {
            return value;
        }
        public string GetValueClientTwoFirstName()
        {
            return valueClientTwoFirstName;
        }
        public string GetValueClientTwoLastName()
        {
            return valueClientTwoLastName;
        }
        public string GetValueClientFirstname()
        {
            return valueFirstName;
        }
        public string GetValueClientLastname()
        {
            return valueLastName;
        }
        public string GetValueClientEmail()
        {
            return valueEmail;
        }
        public string GetValueClientPhone()
        {
            string d = Regex.Replace(valuePhone, pattern, "").Trim();
            return d;
        }
        public string GetValueClientOneFirstname()
        {
            return valueClientOneFirstName;
        }
        public string GetValueClientOneLastname()
        {
            return valueClientOneLastName;
        }
        public string GetValueClientOnePhone()
        {
            string d = Regex.Replace(valueClientOnePhone, pattern, "").Trim();
            return d;
        }
        public string GetValueClientOneEmail()
        {
            return valueClientOneEmail;
        }
        public string GetValuePropertyAddress()
        {
            return substringValue;
        }
        public string GetValuePropertyCity()
        {
            return valuePropertyCity;
        }
    }
}
