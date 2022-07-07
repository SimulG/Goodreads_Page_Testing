using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    internal class ExternalSite
    {
        [SetUp]
        public static void email()
        {
            Driver.setDriver();
            string url = "https://temp-mail.org/en/10minutemail",
                locator = "/html/body/div[1]/div/div/div[2]/div[1]/form/div[2]/button";
            Driver.open(url);
            Common.click(locator);
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
