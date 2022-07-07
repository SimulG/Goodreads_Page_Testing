using Framework;
using NUnit.Framework;
using Framework.Pages;
using Tests.BaseClasess;

namespace Tests
{
    internal class aSignUp : MinMail
    {

        [SetUp]
        public static void Preparation()
        { 
            Driver.open($"{Constants.Urls.Goodreads.SignUp}");            
        }

        [Test]
        public static void signingUp()
        {
            string expectedResult = "Solve this puzzle to protect your account",
                actualResult;
            SignUpPage.clickSignUpWithEmail();
            SignUpPage.enterName();
            SignUpPage.enterEmail();
            SignUpPage.enterPasword();
            SignUpPage.repeatPassword();
            SignUpPage.clickCreate();
            actualResult = 
                SignUpPage.checkForCaptcha();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
