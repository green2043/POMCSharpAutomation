using OpenQA.Selenium;
using POMCSharpAutomation.Utils;

namespace POMCSharpAutomation.Pages
{
    public class RegPage
    {
        private IWebDriver driver;
        private ElementUtil elementUtil;

        public RegPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementUtil = new ElementUtil(driver);
        }

        public string GetRegPageTitle()
        {
            return driver.Title;
        }

        // Additional methods for registration page actions can be added here
    }
}
