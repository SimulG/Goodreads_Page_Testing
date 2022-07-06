using Framework;
using NUnit.Framework;
using Framework.Pages;
using Tests.BaseClasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Login : BaseTest
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
