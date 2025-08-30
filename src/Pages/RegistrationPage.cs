using OpenQA.Selenium;
using POMCSharpAutomation.Utils;

namespace POMCSharpAutomation.Pages
{
    public class RegistrationPage
    {
        private IWebDriver driver;
        private ElementUtil elementUtil;

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementUtil = new ElementUtil(driver);
        }

        public string GetRegistrationPageTitle()
        {
            return driver.Title;
        }

        // Additional methods for registration page actions can be added here
    }
}
