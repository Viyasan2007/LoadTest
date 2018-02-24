using System.IO;
using System.Collections.Generic;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITestAutomationFrameWork.WebDriverCore
{
    public class WebObjectFunctions
    {
        public WebDriverWait wait;
        protected StreamWriter sw;
        public enum ComponentType { XPath = 0, Css = 1, Name = 2, Id = 3, Link = 4, TagName = 5 };
        public IWebDriver driver;
        #region Contructors
        public WebObjectFunctions(IWebDriver driver)
        {
            this.driver = driver;
        }
        public WebObjectFunctions()
        {
        }
        #endregion

        #region Method

        public IWebElement WaitUntilElementSelected(IWebDriver  driver, IWebElement element, long timeout = 20,long poll = 2)
        {
            IWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromSeconds(timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(poll);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
           if (wait.Until(e => e.Displayed))
            {
                return element;
            }
            return element;
        }




        public IWebElement CheckDisplayed(IWebElement element)
    {

        if (element.Displayed)
        {
            return element;
        }
        return element;
    }
    public bool ValidatateWebElementDisplayed(IWebElement nameOfElement)
        {
            if (nameOfElement.Displayed)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


       
        public bool ValidatateWebElementTextDisplayed(IWebElement nameOfElement, string text)
        {
            if (nameOfElement.Text.Equals(text))
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        public bool ValidatateWebElementAttributeCheck(IWebElement nameOfElement, string attributeoutput)
        {
                         
            if (nameOfElement.GetAttribute("outerHTML").Contains(attributeoutput))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool ValidatateWebRemovedElementAttributeCheck(IWebElement nameOfElement, string attributeoutput)
        {
           
            if (!nameOfElement.GetAttribute("outerHTML").Contains(attributeoutput))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool ConfirmTheNegativeTestForDataType(IWebElement element)
        {
            if (element.Text.Equals(""))
            {
                return true;
            }
             else
            {
                return false;
            }
        }

       public bool ValidateDropDown(IWebElement element)
        {
            SelectElement oSelect = new SelectElement(element);
            IList<IWebElement> elementCount=oSelect.Options;
            int iSize = elementCount.Count;
            if (iSize>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateDropDownIsMultipleOptions(IWebElement element)
        {
            SelectElement oSelect = new SelectElement(element);
           
        
            if (oSelect.IsMultiple)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }
        public void SelectGivenElementFromDropDownByText(IWebElement element,string text)
        {
            element.Click();
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }
        public void SelectGivenElementFromDropDownByIndex(IWebElement element, int index)
        {
            element.Click();
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(index);
        }
        public void SelectGivenElementFromDropDownByValue(IWebElement element, string value)
        {
            element.Click();
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }

        public void ListGivenElementFromDropDownByText(IWebElement element, string text)
        {
            //*[@id="leader_multi_select"]/div/ul/li[7]/a/div/label/input
            element.Click();
            IList<IWebElement> options = driver.FindElements(By.TagName("li"));
            foreach  (IWebElement option in  options)
            {
                if (option.Text.Equals(text))
                {
                    option.Click(); 
                    break;
                }
            }
        }

        public void ListGivenElementFromDropDownByTextUnCheck(IWebElement element, string text, string text2)
        {
            //*[@id="leader_multi_select"]/div/ul/li[7]/a/div/label/input
            element.Click();
            IList<IWebElement> options = driver.FindElements(By.TagName("li"));
            foreach (IWebElement option in options)
            {
                if (option.Text.Equals(text))
                {
                    option.Click();
                    break;
                }
            }
            foreach (IWebElement option in options)
            {
                if (option.Text.Equals(text2))
                {
                    option.Click();
                    break;
                }
            }

        }

        #endregion
    }

}