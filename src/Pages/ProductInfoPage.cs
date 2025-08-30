using OpenQA.Selenium;
using POMCSharpAutomation.Utils;

namespace POMCSharpAutomation.Pages
{
    public class ProductInfoPage
    {
        private IWebDriver driver;
        private ElementUtil elementUtil;

        public ProductInfoPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementUtil = new ElementUtil(driver);
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        // Additional methods such as retrieving product details can be added here
    }
}
