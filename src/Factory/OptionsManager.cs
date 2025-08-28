using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace POMCSharpAutomation.Factory
{
    public class OptionsManager
    {
        public ChromeOptions GetChromeOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return options;
        }

        public FirefoxOptions GetFirefoxOptions()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--width=1920");
            options.AddArgument("--height=1080");
            return options;
        }
    }
}
