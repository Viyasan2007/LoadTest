using System.IO;
using System.Collections.Generic;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UITestAutomationFrameWork.Pages;
using System.Linq;


namespace UITestAutomationFrameWork.WebDriverCore
{
    public class CommonMethods
    {

        protected StreamWriter sw;
        public enum ComponentType { XPath = 0, Css = 1, Name = 2, Id = 3, Link = 4 ,TagName=5};

        #region Method

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


        #endregion




        #region Protected Method 


        public IWebElement GetComponent(string locator, ComponentType componentType,int time)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(time));

            
            IWebElement webElement = null;
            try
            {

                switch (componentType)
                {
                    case ComponentType.XPath:

                        webElement = wait.Until<IWebElement>((d) =>
                        {
                            return d.FindElement(By.XPath(locator));
                        });
                        break;
                    case ComponentType.Name:
                        webElement = wait.Until<IWebElement>((d) =>
                        {
                            return d.FindElement(By.Name(locator));
                        });
                        break;
                    case ComponentType.Id:
                        webElement = wait.Until<IWebElement>((d) =>
                        {
                            return d.FindElement(By.Id(locator));
                        });
                        break;
                    case ComponentType.Css:
                        webElement = wait.Until<IWebElement>((d) =>
                        {
                            return d.FindElement(By.CssSelector(locator));
                        });
                        break;
                }
            }
            catch (WebDriverTimeoutException)
            {
                sw.WriteLine("FAILED - " + locator);
            }
            catch (StaleElementReferenceException)
            {
                sw.WriteLine("STALED - " + locator);
            }
            catch (NoSuchElementException)
            {
                sw.WriteLine("NO SUCH ELEMENT - " + locator);
            }
            catch (NullReferenceException)
            {
                sw.WriteLine("NO SUCH ELEMENT - " + locator);
            }
            return webElement;
        }



        public List<IWebElement> GetComponentList(string locator, ComponentType componentType, int time)
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(time));
            List<IWebElement> webElementList = null;
            try
            {

                switch (componentType)
                {
                    case ComponentType.XPath:
                        wait.Until<List<IWebElement>>((d) =>
                        {
                            return d.FindElements(By.XPath(locator)).ToList();
                        });
                        break;
                    case ComponentType.Name:
                        wait.Until<List<IWebElement>>((d) =>
                        {
                            return d.FindElements(By.Name(locator)).ToList();
                        });
                        break;
                    case ComponentType.Id:
                        wait.Until<List<IWebElement>>((d) =>
                        {
                            return d.FindElements(By.Id(locator)).ToList();
                        });
                        break;
                    case ComponentType.Css:
                        wait.Until<List<IWebElement>>((d) =>
                        {
                            return d.FindElements(By.CssSelector(locator)).ToList();
                        });
                        break;
                }
            }
            catch (WebDriverTimeoutException)
            {
                sw.WriteLine("FAILED - " + locator);
            }
            catch (StaleElementReferenceException)
            {
                sw.WriteLine("STALED - " + locator);
            }
            catch (NoSuchElementException)
            {
                sw.WriteLine("NO SUCH ELEMENT - " + locator);
            }
            catch (NullReferenceException)
            {
                sw.WriteLine("NO SUCH ELEMENT - " + locator);
            }
            return webElementList;
        }


        #endregion Protected


    }
}