using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class LoggedInUserPage
    {
        public static void inputSearchBoxText()
        {
            string locator = "/html/body/div[2]/div/header/div[2]/div/div[2]/form/input[1]",//laikinas xpath
                text = "1984";
            Common.sendKeysToElement(locator, text);
        }

        public static void clickSearch()
        {
            string locator = "/html/body/div[2]/div/header/div[2]/div/div[2]/form/button";//laikinas xpath
            Common.click(locator);
        }

        public static string checkSearchResult()
        {
            string locator = "/html/body/div[2]/div[3]/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[2]/a/span";//laikinas xpath
            return Common.getElementText(locator);
        }

        public static void clickMyBooks()
        {
            string locator = "/html/body/div[2]/div/header/div[2]/div/nav/ul/li[2]/a";//laikinas xpath
            Common.click(locator);
        }

        public static void clickAddShelf()
        {
            string locator = "/html/body/div[2]/div[3]/div[1]/div[1]/div[3]/div[1]/div/div/div[2]/a";//Laikinas xpath
            Common.click(locator);
        }

        public static void inputBookshelfName()
        {
            string bookshelfName = "ownedbooks",
                locator = "//*[@id='user_shelf_name']",
                locatorAdd = "/html/body/div[2]/div[3]/div[1]/div[1]/div[3]/div[1]/div/div/div[2]/div/form/input[2]";//laikinai

            Common.sendKeysToElement(locator, bookshelfName);
            Common.click(locatorAdd);
        }

        public static string checkShelfs()
        {

            string locator = "/html/body/div[2]/div[3]/div[1]/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[5]/a";//laikinai
            return Common.getElementText(locator);
        }

        public static void removeShelf()
        {
            string locatorEdit = "/html/body/div[2]/div[3]/div[1]/div[1]/div[3]/div[1]/div/div/div[1]/div[1]/a",
                locatorDel = "/html/body/div[1]/div[3]/div[1]/div[1]/div[2]/div[3]/a";
            Common.click(locatorEdit);
            Common.click(locatorDel);
            Common.okAllert();          
            
        }

        public static void addBookToWantToReadBookshelf()
        {
            throw new NotImplementedException();
        }

        public static void goToMyBooks()
        {
            throw new NotImplementedException();
        }

        public static string checkAddedBooks()
        {
            throw new NotImplementedException();
        }

        public static void removeBook()
        {
            throw new NotImplementedException();
        }
    }
}
