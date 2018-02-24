using APIUtility.APIHelper;
using OpenQA.Selenium;
using System;
using TestAutomationFrameWork;

namespace APIHelper.Utility
{
    public class APIUtilityFunctions
    {
        public IWebDriver driver;

        public APIUtilityFunctions(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string findGCidFormGcidMappingItem(IWebDriver driver,string response)
        {
            Console.WriteLine(" The Gcid  is" + response);

            CommonAPIHelper apiHelper = new CommonAPIHelper(driver);
            Mobius_LoanTable lt = apiHelper.LoanResult(response);

            var gcid = lt.gcidMappings;
            Console.WriteLine(" The Gcid  is" + gcid);
            foreach (var i in gcid)
            {
                if (i.isPrimaryBorrower && i.isActiveOnLoan)
                { 
                        Console.WriteLine(" The Gcid  is" + i.gcid.ToString());
                        return i.gcid.ToString();
                  
                }
            }
            throw new InvalidOperationException("Did not find value expected.");
        }
        public string findGCidFormSourceReferenceId(IWebDriver driver,string response)
        {

            Console.WriteLine(" The Gcid  is" + response);
            CommonAPIHelper apiHelper = new CommonAPIHelper(driver);
            Mobius_ClientMapping lt = apiHelper.ClientMappingResult(response);
            var gcid = lt.clientMappings;
            Console.WriteLine(" The Gcid  isXXXXXXX" + gcid);
            foreach (var i in gcid)
            {
                if (i.isActiveOnLoan && !i.isPrimaryBorrower)
                {
                    Console.WriteLine(" The Gcid  is" + i.sourceReferenceId.ToString());
                    return i.sourceReferenceId.ToString();
                }
            }
            throw new InvalidOperationException("Did not find value expected.");
        }
    }
}
