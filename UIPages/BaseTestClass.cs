using AutomationUtilities.BrowserUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using UiUtilities.BrowserUtilities;

namespace UIPages
{
    public class BaseTestClass
    {
        protected IWebDriver? driver;

        [OneTimeSetUp]
        public void TestSetup()
        {

            driver = new BrowserClient(new ChromeBrowserFactory()).GetBrowser().CreateBrowserInstance();

            Console.WriteLine($"Test Setup - Browser: {driver.GetType().Name}");
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            try
            {
                driver?.Quit();
            }
            finally
            {
                Console.WriteLine($"Driver quit command executed");
            }
            // Close and quit the WebDriver
          

        }

        [TestFixture]
        public class TestClass : BaseTestClass

        {
            [Test]
            public void Test()
            {
                try
                {
                    driver!.Navigate().GoToUrl("https://www.google.com");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
