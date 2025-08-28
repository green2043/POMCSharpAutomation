using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace POMCSharpAutomation.Utils
{
    public class ElementUtil
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ElementUtil(IWebDriver driver, int timeoutInSeconds = Constants.DefaultWaitTime)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        }

        private IWebElement WaitForElement(By locator)
        {
            return wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public void DoClick(By locator)
        {
            WaitForElement(locator).Click();
        }

        public void DoSendKeys(By locator, string text)
        {
            var element = WaitForElement(locator);
            element.Clear();
            element.SendKeys(text);
        }

        public string DoGetText(By locator)
        {
            return WaitForElement(locator).Text;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }
    }
}
