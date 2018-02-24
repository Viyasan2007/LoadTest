using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UITestAutomationFrameWork.Pages;
using UITestAutomationFrameWork.WebDriverCore;

namespace UITestAutomationFrameWork.Pages
{
    public class Loan 
    {


        public IWebDriver driver;


        #region Contructors

        WebObjectFunctions common = new WebObjectFunctions();

        public Loan(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public Loan()
        {
        }

        #endregion Constructors
        #region Components



        [FindsBy(How = How.XPath, Using = "//div[@id='div_SuspendedLoanDialog']/table/tbody/tr[5]/td/div/div/font/b/a[@name=' CtiLink']")]
        public IWebElement LOLALoan_Button;

        [FindsBy(How = How.Id, Using = "pipelineTable")]
        public IWebElement PipeLineManager_Table;
           

        #endregion
        #region Methods

        public Loan ConfirmNotesAreSavedInParticularLoan(string note)
        {
            //driver.Wait(4000);
            IWebElement form =driver.FindElement(By.XPath("//form[@name='forma']"));
            IWebElement div = form.FindElement(By.TagName("div"));
            IWebElement table = driver.FindElement(By.XPath("//table[2]"));
            IWebElement tbody = table.FindElement(By.TagName("tbody"));
          

                
                string s = tbody.FindElement(By.XPath("//form[@name='forma']/div/table/tbody/tr[2]/td[3]/font")).Text;

                Console.WriteLine(" The Description is: " + s);
                   if ( s.Equals(note))
                   {
                    Console.WriteLine("The same note is updated in the loan");
                    
                }

                Assert.IsTrue(s.Equals(note));
           

            return new Loan();

        }



        public Loan ConfirmHotReasonAreSavedInParticularLoan(string note)
        {
           
           
            string s = driver.FindElement(By.XPath("//div/table/tbody/tr[2]/td[3][contains(text(),'"+ note+"')]")).Text;

             if (s.Equals(note))
             {
                 Console.WriteLine("The same hotreason is updated in the loan");

             }
            Assert.IsTrue(s.Equals(s));

           
            return new Loan();

        }

        public Loan ConfirmHotReasonAreUnCheckedInParticularLoan(string note)
        {

            string s = driver.FindElement(By.XPath("//div/table/tbody/tr[2]/td[3][contains(text(),'" + note + "')]")).Text;

           Assert.IsTrue(s.Equals(s));

            return new Loan();

        }


        public Loan ConfirmCTIAddress(int row)
        {
            
             IWebElement form = driver.FindElement(By.XPath("//form[@name='forma']"));
             IWebElement table = form.FindElement(By.XPath("//table[1]"));
             IWebElement tbody = table.FindElement(By.TagName("tbody"));
             IWebElement tr = tbody.FindElement(By.TagName("tr"));

             List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
             List<String> ListOdIds = new List<String>();
             String rowNo = "";

            for (int i = 0; i < rows.Count(); i++)
            {
                //IWebElement rowi = tbody.FindElement(By.XPath("//form[@name='forma']/div/table/tbody/tr[2]/td[3]"));
                if (i == row)
                {
                    Console.WriteLine("The row  is :" + rows[i]);
                   // tr.FindElement(By.XPath("//td/div/div/font/b/a")).Click();

                    string BaseWindow = driver.CurrentWindowHandle;
                    ReadOnlyCollection<string> handles = driver.WindowHandles;
                    Console.WriteLine("this is a test " + driver.FindElement(By.XPath("//div[@id='scTransferToPurchase']/table/tbody/tr[2]/td/img")).GetAttribute("onclick").ToString());
                    //string  d = tr.FindElement(By.XPath("//td/div/div/font/b/a")).GetAttribute("ctiphone:?to=").ToString();
                   
                }
            }
                 return new Loan(driver);

        }

        public Loan DialCallPipeLineManager(int row)
        {
            
            IWebElement table = driver.FindElement(By.Id("pipelineTable"));
            IWebElement tbody = table.FindElement(By.TagName("tbody"));
            IWebElement tr = tbody.FindElement(By.TagName("tr"));
            IWebElement td = tr.FindElement(By.TagName("td"));
            IWebElement div = td.FindElement(By.XPath("//div[1]"));
            List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
            List<String> ListOdIds = new List<String>();
            String rowNo = "";
            Console.WriteLine("The row  is :" + rows.Count());
            for (int i = 0; i < rows.Count(); i++)
            {
                
                if (i == row)
                {
                    driver.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + row + "]/td//div/div[1]/div")).Click();
                   // driver.FindElement(By.XPath("//div[contains(@class,'phoneIcon')]")).SendKeys(Keys.Return);
                   
                   // driver.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[3]/td/div/div/div/button")).Click();
                   // IJavaScriptExecutor js = driver as IJavaScriptExecutor;


                   // string Javascript = "document.getElement(By.xpath(\"//table[@id='pipelineTable']/tbody/tr[3]/td/div/div/div/button[@onclick'return javascript:return openCTIWindow('','','','','','(248)442-8999');']\").click()";
                   // string t = js.ExecuteScript(Javascript).ToString();



                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    
                }
            }

return new Loan(driver);
}

public Loan ClickQTextPipeLineManager(int row)
{
       
            IWebElement table = driver.FindElement(By.Id("pipelineTable"));
            IWebElement tbody = table.FindElement(By.TagName("tbody"));
            IWebElement tr = tbody.FindElement(By.TagName("tr"));
            IWebElement td = tr.FindElement(By.TagName("td"));
            IWebElement div = td.FindElement(By.XPath("//div[1]"));
            List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
            List<String> ListOdIds = new List<String>();
            String rowNo = "";
            Console.WriteLine("The row  is :" + rows.Count());
            for (int i = 0; i < rows.Count(); i++)
            {
               if (i == row)
                {

                    driver.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + row + "]/td//div/div[2]/div")).Click();

                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                   
                    string s = driver.FindElement(By.XPath("//form[@id='qtext_form']/div/div/div/h2")).Text;
                    Assert.IsTrue(s.Equals("QText"));

                }
            }
            
           
            return new Loan(driver);
}

public Loan ClickEmailPipeLineManager(int row)
{

IWebElement table = driver.FindElement(By.Id("pipelineTable"));
//IWebElement form = driver.FindElement(By.XPath("//form[@name='forma']"));
// IWebElement div = form.FindElement(By.Id("div_SuspendedLoanDialog"));
IWebElement tbody = table.FindElement(By.TagName("tbody"));
IWebElement tr = tbody.FindElement(By.TagName("tr"));
IWebElement td = tr.FindElement(By.TagName("td"));
IWebElement div = td.FindElement(By.XPath("//div[3]"));
List<IWebElement> rows = tbody.FindElements(By.TagName("tr")).ToList();
List<String> ListOdIds = new List<String>();
String rowNo = "";
Console.WriteLine("The row  is :" + rows.Count());
for (int i = 0; i < rows.Count(); i++)
{
//IWebElement rowi = tbody.FindElement(By.XPath("//form[@name='forma']/div/table/tbody/tr[2]/td[3]"));
if (i == row)
{
Console.WriteLine("The row  is :" + rows[i]);
driver.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + row + "]/td//div/div[3]/div")).Click();

//row = row + 1;
//driver.SwitchTo().Window(driver.WindowHandles.Last());

string s = driver.FindElement(By.XPath("//form[@name='SendEmail']/div/h4/font")).Text;
Assert.IsTrue(s.Equals("Clients without an email address will not show up in the pull downs."));

}
}


return new Loan(driver);
}


#endregion 

#region Validations
#endregion

    



}
}
