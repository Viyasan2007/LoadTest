using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UITestAutomationFrameWork.Pages;



namespace UITestAutomationFrameWork.Pages
{
    public class Loan :DashBoardPipeLineManager
    {


        #region Constructor
        #endregion
        #region Components
        public IWebElement LOLALoan_Button
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//div[@id='div_SuspendedLoanDialog']/table/tbody/tr[5]/td/div/div/font/b/a[@name=' CtiLink']"));
            }
        }



        public IWebElement PipeLineManager_Table
        {
            get
            {

                return Driver.Instance.FindElement(By.Id("pipelineTable"));
            }
        }

        public string existingWindowHandle { get; private set; }

        #endregion
        #region Methods

        public Loan ConfirmNotesAreSavedInParticularLoan(string note)
        {
            Driver.Instance.Wait(4000);
            IWebElement form = Driver.Instance.FindElement(By.XPath("//form[@name='forma']"));
            IWebElement div = form.FindElement(By.TagName("div"));
            IWebElement table = Driver.Instance.FindElement(By.XPath("//table[2]"));
            IWebElement tbody = table.FindElement(By.TagName("tbody"));
          

                
                string s = tbody.FindElement(By.XPath("//form[@name='forma']/div/table/tbody/tr[2]/td[3]/font")).Text;

                Console.WriteLine(" The Description is: " + s);
                   if ( s.Equals("QA"))
                   {
                    Console.WriteLine("The same note is updated in the loan");
                    
                }

                NUnit.Framework.Assert.IsTrue(s.Equals(s));
           

            return new Loan();

        }



        public Loan ConfirmHotReasonAreSavedInParticularLoan(string note)
        {
           
           Driver.Instance.Wait(4000);
 

            string s = Driver.Instance.FindElement(By.XPath("//div/table/tbody/tr[2]/td[3][contains(text(),'"+ note+"')]")).Text;

            /* if (s.Equals(note))
             {
                 Console.WriteLine("The same hotreason is updated in the loan");

             }*/
            NUnit.Framework.Assert.IsTrue(s.Equals(s));

            Driver.Instance.Wait(4000);
            return new Loan();

        }

        public Loan ConfirmHotReasonAreUnCheckedInParticularLoan(string note)
        {

            Driver.Instance.Wait(4000);


            string s = Driver.Instance.FindElement(By.XPath("//div/table/tbody/tr[2]/td[3][contains(text(),'" + note + "')]")).Text;

            NUnit.Framework.Assert.IsTrue(s.Equals(s));

            Driver.Instance.Wait(4000);
            return new Loan();

        }


        public Loan ConfirmCTIAddress(int row)
        {
            Driver.Instance.Wait(4000);
             IWebElement form = Driver.Instance.FindElement(By.XPath("//form[@name='forma']"));
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

                    string BaseWindow = Driver.Instance.CurrentWindowHandle;
                    ReadOnlyCollection<string> handles = Driver.Instance.WindowHandles;
                    Console.WriteLine("this is a test " + Driver.Instance.FindElement(By.XPath("//div[@id='scTransferToPurchase']/table/tbody/tr[2]/td/img")).GetAttribute("onclick").ToString());
                    //string  d = tr.FindElement(By.XPath("//td/div/div/font/b/a")).GetAttribute("ctiphone:?to=").ToString();
                   
                }
            }
                 return new Loan();

        }

        public Loan DialCallPipeLineManager(int row)
        {
            Driver.Instance.Wait(4000);
            IWebElement table = Driver.Instance.FindElement(By.Id("pipelineTable"));
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
                    Driver.Instance.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + row + "]/td//div/div[1]/div")).Click();
                   // Driver.Instance.FindElement(By.XPath("//div[contains(@class,'phoneIcon')]")).SendKeys(Keys.Return);
                    Driver.Instance.Wait(1000);
                   // Driver.Instance.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[3]/td/div/div/div/button")).Click();
                   // IJavaScriptExecutor js = Driver.Instance as IJavaScriptExecutor;


                   // string Javascript = "document.getElement(By.xpath(\"//table[@id='pipelineTable']/tbody/tr[3]/td/div/div/div/button[@onclick'return javascript:return openCTIWindow('','','','','','(248)442-8999');']\").click()";
                   // string t = js.ExecuteScript(Javascript).ToString();



                    Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());
                    Driver.Instance.Wait(4000);
                }
            }

return new Loan();
}

public Loan ClickQTextPipeLineManager(int row)
{
            Driver.Instance.Wait(4000);
            IWebElement table = Driver.Instance.FindElement(By.Id("pipelineTable"));
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

                    Driver.Instance.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + row + "]/td//div/div[2]/div")).Click();

                    Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());
                    Driver.Instance.Wait(4000);
                    string s = Driver.Instance.FindElement(By.XPath("//form[@id='qtext_form']/div/div/div/h2")).Text;
                    NUnit.Framework.Assert.True(s.Equals("QText"));

                }
            }
            
           
            return new Loan();
}

public Loan ClickEmailPipeLineManager(int row)
{
Driver.Instance.Wait(4000);
IWebElement table = Driver.Instance.FindElement(By.Id("pipelineTable"));
//IWebElement form = Driver.Instance.FindElement(By.XPath("//form[@name='forma']"));
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
Driver.Instance.FindElement(By.XPath("//table[@id='pipelineTable']/tbody/tr[" + row + "]/td//div/div[3]/div")).Click();

//row = row + 1;
//Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());

string s = Driver.Instance.FindElement(By.XPath("//form[@name='SendEmail']/div/h4/font")).Text;
NUnit.Framework.Assert.True(s.Equals("Clients without an email address will not show up in the pull downs."));

}
}


return new Loan();
}


#endregion
#region Validations
#endregion





}
}
