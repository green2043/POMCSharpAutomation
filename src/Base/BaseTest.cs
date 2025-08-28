using NUnit.Framework;
using OpenQA.Selenium;
using POMCSharpAutomation.Factory;

namespace POMCSharpAutomation.Base
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = DriverFactory.CreateDriver("chrome");
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
