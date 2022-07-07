using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class SignUpPage
    {
        //private string password = "Testas";

        public static void enterName()
        {
            string locator = "//*[@id='ap_customer_name']",
                name = "Testauskas";
            Common.sendKeysToElement(locator, name);
        }

        public static void enterEmail()
        {
            string locator = "//*[@id='ap_email']";

            Common.click(locator);
            Common.pasteClipboard();
        }

        public static void clickSignUpWithEmail()
        {
            string locator = "/html/body/div[1]/div[1]/div[2]/div/div/div/div/div/a[2]/button";
            Common.click(locator);
        }

        public static void enterPasword()
        {
            string password = "Testas",
                locator = "//*[@id='ap_password']";
            Common.sendKeysToElement(locator, password);
        }

        public static void repeatPassword()
        {
            string password = "Testas",
                locator = "//*[@id='ap_password_check']";
            Common.sendKeysToElement(locator, password);
        }

        public static void clickCreate()
        {
            string locator = "//*[@id='continue']";
            Common.click(locator);
        }

        public static string checkForCaptcha()
        {
            string locator = "/html/body/div[1]/div[2]/div/div/div/div/div/div/div[1]/span";
            return Common.getElementText(locator);
        }
    }
}
