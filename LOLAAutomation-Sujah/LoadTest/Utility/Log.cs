using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationFrameWork.Pages;
using UITestAutomationFrameWork.WebDriverCore;

namespace LoadTest.Utility
{
    public class Log: Driver
    {

        public IWebDriver driver;
        WebObjectFunctions common = new WebObjectFunctions();

        public Log(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);

        }

        public Log()
        {

        }
        public static void Write(string msg)
        {
           // var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            //Console.WriteLine(msg);
            //watch.Stop();
            //var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(msg);
        }

        public  static void WriteFormat(string msgFormat, params object[] args)
        {
            string formattedString = string.Format(msgFormat, args);
            Console.WriteLine(formattedString);
        }

        public static void WriteLineFormat(string msgFormat, params object[] args)
        {
            string formattedString = string.Format(msgFormat, args);
            Console.WriteLine(formattedString);
            Console.WriteLine();
        }

        public static void WriteStringLine()
        {
            Console.WriteLine(new string('-', 30));
        }

        public static void WriteLine()
        {

            Console.WriteLine();
        }
    }
}
