using NUnit.Framework;
using POMCSharpAutomation.Base;
using POMCSharpAutomation.Pages;
using Allure.NUnit;




namespace POMCSharpAutomation.Tests
{
    [AllureNUnit]
    [TestFixture]
    public class LoginPageTest : BaseTest
    {
        private LoginPage loginPage;

        [SetUp]
        public void TestSetup()
        {
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void VerifyLoginPageTitle()
        {
            loginPage.NavigateTo("https://example.com/login");
            string title = loginPage.GetPageTitle();
            Assert.AreEqual("Login - My Store", title);
        }

        [Test]
        public void VerifyLoginFunctionality()
        {
            loginPage.NavigateTo("https://example.com/login");
            loginPage.Login("test@example.com", "password");
            // Additional assertions to verify login success can be added here
        }
    }
}
