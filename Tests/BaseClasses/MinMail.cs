using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Framework.Pages
{
    internal class MinMail
    {
        [SetUp]
        public static void email()
        {
            Driver.setDriver();

            string url = "https://temp-mail.org/en/10minutemail",
                locator = "/html/body/div[1]/div/div/div[2]/div[1]/form/div[2]/button";
            Driver.open(url);
            Driver.wait(10000);
            Common.click(locator);
            Driver.closeDriver();
            Driver.setDriver();
        }
        [TearDown]
        public static void close()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.takeScreenshot();
            }
            Driver.closeDriver();
        }
    }
}
