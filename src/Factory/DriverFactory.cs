using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace POMCSharpAutomation.Factory
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    return new ChromeDriver();
                case "firefox":
                    return new FirefoxDriver();
                default:
                    throw new ArgumentException($"Unsupported browser: {browser}");
            }
        }
    }
}
