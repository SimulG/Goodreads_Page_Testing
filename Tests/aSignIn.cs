using Framework;
using NUnit.Framework;
using Framework.Pages;
using Tests.BaseClasess;


namespace Tests
{
    internal class aSignIn : BaseTest
    {
        [SetUp]
        public static void openPage()
        {
            Driver.open($"{Constants.Urls.Goodreads.Login}");
        }

        [Test]

        public static void signIn()
        {
            string expectedMessage = "Testas";

            LoginPage.clickSignWithEmail();
            LoginPage.enterEmail();
            LoginPage.enterPassword();
            LoginPage.clickSignIn();
            string actualMessage =
            LoginPage.checkUser();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }
    }  
}
