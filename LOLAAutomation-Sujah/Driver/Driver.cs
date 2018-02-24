using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace UITestAutomationFrameWork.Pages
{
    public class Driver
    {
        #region Constructors
        #endregion
        private static bool isInitialized = false;

        public static IWebDriver drivers;
        public By by;
        #region Methods
        public static IWebDriver Initialize(string browserName)
        {
            if (!isInitialized )
            {
                if (browserName.Equals("IE"))
                {
                    InternetExplorerOptions IEcaps = new InternetExplorerOptions();
                    IEcaps.IgnoreZoomLevel = true;
                    IEcaps.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    IWebDriver driverIE = new InternetExplorerDriver(IEcaps);
                    drivers = driverIE;
                    drivers.Manage().Window.Maximize();
                    isInitialized = true;
                    return drivers;
                }
                else if (browserName.Equals("Chrome"))
                {
                   IWebDriver driverChrome = new ChromeDriver();

                    drivers = driverChrome;
                    drivers.Manage().Window.Maximize();
                    isInitialized = true;
                    return drivers;
                }

                return drivers;
            }

            return drivers;
        }
        public static void Close()
        {
                isInitialized = false;
        }
        #endregion Methods
    }
}
 

