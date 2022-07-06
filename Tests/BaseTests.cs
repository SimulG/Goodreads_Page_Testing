using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.BaseTests
{
    public class BaseTests
    {
        [SetUp]
        public static void setup()
        {
            Driver.getDriver();
        }
        [TearDown]
        public static void close()
        {
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.takeScreenshot();
            }
            Driver.closeDriver();
        }
            
    }
}
