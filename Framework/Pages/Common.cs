using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Pages
{
    internal class Common
    {
        internal static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));
        }
        internal static void sendKeysToElement(string locator, string keys)
        {
            getElement(locator).SendKeys(keys);
        }
        internal static void click(string locator)
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
            Driver.getDriver().SwitchTo().Alert().Accept();
        }

        internal static void waitForElementToBeVisable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }
        //internal static void waitForElementToBeVisible(string locator)
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
        //    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        //}
        //internal static void waitForElementToBeClickable(string locator)
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
        //    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        //}

    }
}
