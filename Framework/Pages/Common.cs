using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework.Pages
{
    public class Common
    {
        internal static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));
        }
        internal static void sendKeysToElement(string locator, string keys)
        {
            getElement(locator).SendKeys(keys);
        }
       public static void click(string locator)
        {
            getElement(locator).Click();
        }
        internal static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }
        internal static string getElementAttribute(string locator)
        {
            string element;
            return element = getElement(locator).GetAttribute("alt");
        }

        internal static void okAllert()
        {
            Driver.wait(3000);
            Driver.getDriver().SwitchTo().Alert().Accept();
        }
        
        internal static void waitForElementToBeVisable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        public static void pasteClipboard()
        {
            Actions action = new Actions(Driver.getDriver());

            action.KeyDown(Keys.Control);

            action.SendKeys("v");

            action.KeyUp(Keys.Control);

            action.Build().Perform();
        }
    }
}
