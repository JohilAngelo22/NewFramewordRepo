using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFW;
using UiUtilities.BrowserUtilities;

namespace AutomationUtilities.BrowserUtilities
{
    public class FirefoxBrowserFactory : BrowserFactory
    {
        public override IBrowserHandler CreateBrowser()
        {
            return new FirefoxBrowser();
        }
    }

    public class Dummy
    {
        public void Navigate()
        { 
            IBrowserHandler browser = new ChromeBrowser();
            IWebDriver driver =  browser.CreateBrowserInstance();
        }
    }
}
