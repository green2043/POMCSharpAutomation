using NUnit.Framework;
using POMCSharpAutomation.Base;
using POMCSharpAutomation.Pages;
using POMCSharpAutomation.Utils;
using Allure.NUnit;

namespace POMCSharpAutomation.Tests
{
    [AllureNUnit]
    [TestFixture]
    public class AccountsPageTest : BaseTest
    {
        private LoginPage loginPage;
        private AccountsPage accountsPage;

        [SetUp]
        public void SetUpTest()
        {
            loginPage = new LoginPage(driver);
            accountsPage = new AccountsPage(driver);
        }

        [Test]
        public void VerifyAccountsPageTitle()
        {
            loginPage.NavigateTo("https://example.com/login");
            loginPage.Login("test@example.com", "password");
            string title = accountsPage.GetAccountsPageTitle();
            Assert.AreEqual(Constants.HomePageTitle, title);
        }
    }
}
