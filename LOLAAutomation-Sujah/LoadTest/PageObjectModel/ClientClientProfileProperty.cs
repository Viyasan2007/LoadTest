using UITestAutomationFrameWork.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UITestAutomationFrameWork
{
   public  class ClientClientProfileProperty :ClientClientProfileGoals
    {
        private readonly object[] input;
       


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

        public IWebElement LOLAClientClientProfilePropertyoccupancy_DropDownBox
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//select[@name='h_sResIDType']/option[@value='Primary Residence']"));
            }
        }
        public IWebElement LOLAClientClientProfileEmploymentIncome_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Employment / Income')]"));
            }
        }

        public IWebElement LOLAClientClientProfileProperty_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Property')]"));
            }
        }


        public IWebElement LOLAClientClientProfilePropertyQuickPal_Label
        {
            get
            {

                return Driver.Instance.FindElement(By.XPath("//a[contains(.,'Quick PAL')]"));
            }
        }

        #endregion
        #region Methods
        public ClientClientProfileEmploymentIncome FillProperty()
        {
                Driver.Instance.Wait(1000);
               // LOLAClientClientProfilePropertyoccupancy_DropDownBox.Click();
                Driver.Instance.Wait(1000);
           
                 LOLAClientClientProfilePropertyQuickPal_Label.SendKeys(Keys.Return);
            /*Actions builder = new Actions(Driver.Instance);
            builder.MoveToElement(LOLAClientClientProfilePropertyQuickPal_Label).Click();
            builder.Perform();*/
            Driver.Instance.Wait(4000);
               // LOLAClientClientProfileClient1SaveMyData_Button.Click();

              //  LOLAClientClientProfileClient1SaveAndNext_Button.Click();
                return new ClientClientProfileEmploymentIncome();
        }




        public QuickPal navigateQuickpal()
        {
            Driver.Instance.Wait(1000);
            // LOLAClientClientProfilePropertyoccupancy_DropDownBox.Click();
            Driver.Instance.Wait(1000);

            //LOLAClientClientProfilePropertyQuickPal_Label.SendKeys(Keys.Return);

            //Driver.Instance.SwitchTo().Alert();

            IWebDriver dri = Driver.Instance;
            IJavaScriptExecutor js =  dri as IJavaScriptExecutor;
           LOLAClientClientProfilePropertyQuickPal_Label.SendKeys(Keys.Return);



           // Console.WriteLine(Driver.Instance.SwitchTo().ActiveElement().FindElement(By.Id("h_tPurchasePrice")));

           //List<String> beforePopup = Driver.Instance.WindowHandles.ToList();

           // List<String> afterPopup = Driver.Instance.WindowHandles.ToList();
           //  Console.WriteLine("before"+beforePopup[0]);
           
            String f = Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.LastOrDefault()).PageSource;
           // Console.WriteLine(" the page source" + f);
            foreach (string defwindow in Driver.Instance.WindowHandles)
            {
                Driver.Instance.SwitchTo().Window(defwindow);
                if (Driver.Instance.Title == "Quick PAL")
                {
                    String f2 = Driver.Instance.SwitchTo().Window(defwindow).PageSource;


                    Driver.Instance.FindElement(By.Name("moving_selling_home")).Click();

                    Console.WriteLine(" the page source"+f2);

                }

            }

            //Driver.Instance.FindElement(By.Id("h_tPurchasePrice")).SendKeys("sujah");
            //      Console.WriteLine("after"+afterPopup[0]);

            /* if (afterPopup.Count() == 1)
             {
                 Console.WriteLine(afterPopup.ToArray()[0]);
             }*/

            // Console.WriteLine(Driver.Instance.SwitchTo().Window(afterPopup.ToArray()[0]).PageSource.ToString());

            // Driver.Instance.SwitchTo().Window(Driver.Instance.CurrentWindowHandle).FindElement(By.Id("h_tPurchasePrice")).Click();
            // js.ExecuteScript("window.showModalDialog('PALCheckList', '', 'dialogHeight:900px;dialogWidth:550px');pgRefresh('');");
            //  js.ExecuteScript("window.showModalDialog = window.open;");


            // Driver.Instance.SwitchTo().DefaultContent();
            //ScriptManager.RegisterStartupScript(this.page, this.GetType(), "text", "window.showModalDialog('PALCheckList', '', 'dialogHeight:900px;dialogWidth:550px');pgRefresh('');", true);
            // Driver.Instance.SwitchTo().Alert().Accept();
            // IWebElement e1 = Driver.Instance.FindElement(By.Id("h_tPurchasePrice"));
            // e1.GetAttribute("Id");
            // Console.WriteLine(" the purchase price" + e1);
            /// js.ExecuteScript("document.getElementById('h_tPurchasePrice').value='10000';",input);
            return new QuickPal();
        }
        #endregion
        #region Validations
        public bool ValidateClientClientProfileEmploymentIncome()
        {

            if(LOLAClientClientProfileEmploymentIncome_Label.Text.Equals("Employment / Income"))
            {
                ValidateClientProfilePropertyColor();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateClientProfilePropertyColor()
        {
            if (LOLAClientClientProfileProperty_Label.Text.Equals("Property"))
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
