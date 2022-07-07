using System;

namespace Framework.Pages
{
    public class LoginPage
    {
        public static void clickSignWithEmail()
        {
            string locator = "//*[@id='choices']/div/a[2]/button";
            Common.click(locator);
        }

        public static void enterEmail()
        {
            string locator = "//*[@id='ap_email']",
                email = "mehev57278@meidir.com";
            Common.sendKeysToElement(locator, email);
        }

        public static void enterPassword()
        {
            string locator = "//*[@id='ap_password']",
                 password = "Testas";
            Common.sendKeysToElement(locator, password);
        }

        public static void clickSignIn()
        {
            string locator = "//*[@id='signInSubmit']";
            Common.click(locator);
        }

        public static string checkUser()
        {
            string locator = "//header/div[2]/div/div[3]/ul/li[5]/div/a/span/img";//Nerandu geresnio Xpath
            return Common.getElementAttribute(locator);
        }

    }
}
