using OpenQA.Selenium;

namespace POMCSharpAutomation.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly By emailField = By.Id("input-email");
        private readonly By passwordField = By.Id("input-password");
        private readonly By loginButton = By.CssSelector("input[type='submit']");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public void Login(string username, string password)
        {
            driver.FindElement(emailField).Clear();
            driver.FindElement(emailField).SendKeys(username);
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
            driver.FindElement(loginButton).Click();
        }
    }
}
