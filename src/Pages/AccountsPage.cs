using OpenQA.Selenium;
using POMCSharpAutomation.Utils;

namespace POMCSharpAutomation.Pages
{
    public class AccountsPage
    {
        private readonly IWebDriver driver;
        private readonly ElementUtil elementUtil;

        public AccountsPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementUtil = new ElementUtil(driver);
        }

        public string GetAccountsPageTitle()
        {
            return driver.Title;
        }
    }
}
