using OpenQA.Selenium;
using POMCSharpAutomation.Utils;

namespace POMCSharpAutomation.Pages
{
    public class AmazonPage
    {
        private IWebDriver driver;
        private ElementUtil elementUtil;

        public AmazonPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementUtil = new ElementUtil(driver);
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        // Additional page-specific methods can be added here
    }
}
