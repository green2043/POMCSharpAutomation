using OpenQA.Selenium;

namespace POMCSharpAutomation.Utils
{
    /// <summary>
    /// Utility class to execute JavaScript commands within the context of the browser.
    /// Provides methods for clicking elements, scrolling and executing custom scripts.
    /// </summary>
    public class JavaScriptUtil
    {
        private readonly IWebDriver driver;

        public JavaScriptUtil(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Clicks the specified element using JavaScript.
        /// </summary>
        public void ClickElementByJS(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", element);
        }

        /// <summary>
        /// Scrolls the page until the specified element is into view.
        /// </summary>
        public void ScrollIntoView(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        /// <summary>
        /// Scrolls to the bottom of the page.
        /// </summary>
        public void ScrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        /// <summary>
        /// Executes a custom JavaScript command.
        /// </summary>
        public object ExecuteScript(string script, params object[] args)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            return js.ExecuteScript(script, args);
        }
    }
}
