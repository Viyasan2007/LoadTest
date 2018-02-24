using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.WebDriverCore;

namespace FreshStartTestCases.FreshStartpageObjectModelPages
{
    public class PipelineSearch:MyPipeline
    {

        public IWebDriver driver;


        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public PipelineSearch(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public PipelineSearch()
        {
        }
        #endregion

        #region Components


        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/div[1]/h3")]
        public IWebElement FreshStartPipelineSearch_Subheading;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/div[2]/div[1]/label")]
        public IWebElement FreshStartPipelineSearchSearchForMultipleClients_RadioButtonLabel;


        [FindsBy(How = How.XPath, Using = "//body/div[1]/div/div/form/div[2]/div[1]/label/input")]
        public IWebElement FreshStartPipelineSearchSearchForMultipleClients_RadioButton;
        

        #endregion
    }
}
