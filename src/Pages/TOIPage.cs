using OpenQA.Selenium;
using POMCSharpAutomation.Utils;

namespace POMCSharpAutomation.Pages
{
    public class TOIPage
    {
        private IWebDriver driver;
        private ElementUtil elementUtil;

        public TOIPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementUtil = new ElementUtil(driver);
        }

        public string GetTOIPageTitle()
        {
            return driver.Title;
        }

        // Additional methods for TOI page actions can be added here
    }
}
