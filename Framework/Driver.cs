using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Framework
{
    public class Driver
    {
        public static IWebDriver driver;
        
        public static void setDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");          
            driver = new ChromeDriver(options);
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }
        public static void takeScreenshot()
        {
            string screenshotPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{screenshotPath}\\src-{Guid.NewGuid()}.png";

            Directory.CreateDirectory(screenshotPath);
            Screenshot screenshot = ((ITakesScreenshot)Driver.getDriver()).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }
        public static void closeDriver()
        {
            driver.Close();
        }
    }
}
