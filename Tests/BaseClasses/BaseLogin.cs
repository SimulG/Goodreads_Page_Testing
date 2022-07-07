using Framework;
using Framework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.BaseClasses
{
    internal class BaseLogin
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open($"{Constants.Urls.Goodreads.Login}");
            LoginPage.clickSignWithEmail();
            LoginPage.enterEmail();
            LoginPage.enterPassword();
            LoginPage.clickSignIn();
        }


        [TearDown]
        public static void close()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.takeScreenshot();
                LoggedInUserPage.removeShelf();
                LoggedInUserPage.removeBook();
            }
            Driver.closeDriver();
        }
    }
}
