using OpenQA.Selenium;
using POMCSharpAutomation.Utils;

namespace POMCSharpAutomation.Pages
{
    public class ResultsPage
    {
        private IWebDriver driver;
        private ElementUtil elementUtil;

        public ResultsPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementUtil = new ElementUtil(driver);
        }

        public string GetResultsPageTitle()
        {
            return driver.Title;
        }

        // Additional methods for results page actions can be added here
    }
}
