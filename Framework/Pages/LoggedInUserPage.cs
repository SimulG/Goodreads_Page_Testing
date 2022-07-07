namespace Framework.Pages
{
    public class LoggedInUserPage
    {
        public static void inputSearchBoxText()
        {
            string locator = "//header/div[2]/div/div[2]/form/input[1]",
                text = "1984";
            Common.sendKeysToElement(locator, text);
        }

        public static void clickSearch()
        {
            string locator = "//header/div[2]/div/div[2]/form/button";
            Common.click(locator);
        }

        public static string checkSearchResult()
        {
            string locator = "//table/tbody/tr[1]/td[2]/a/span"; 
            return Common.getElementText(locator);
        }

        public static void clickMyBooks()
        {
            string locator = "//header/div[2]/div/nav/ul/li[2]/a";//laikinas xpath
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
                locatorAdd = "//*[@id='shelf_name_form']//input[@type='submit']";

            Common.sendKeysToElement(locator, bookshelfName);
            Common.click(locatorAdd);
        }

        public static void waitForElement()
        {
            string locator = "//table/tbody/tr[1]/td[2]/div[2]/div/div[1]/span";
            Common.waitForElementToBeVisable(locator);
        }

        public static string checkShelfs()
        {

            string locator = "//*[@id='paginatedShelfList']//*[contains(text(),'ownedbooks')]";
            return Common.getElementText(locator);
        }

        public static void removeShelf()
        {
            string locatorEdit = "/html/body/div[2]/div[3]/div[1]/div[1]/div[3]/div[1]/div/div/div[1]/div[1]/a",
                locatorDel = "/html/body/div[1]/div[3]/div[1]/div[1]/div[2]/div[3]/a";
            Common.click(locatorEdit);
            Common.click(locatorDel);
            Common.okAllert();
            Driver.wait(2000);

        }

        public static void addBookToWantToReadBookshelf()
        {
            string locator = "//table/tbody/tr[1]/td[2]/div[2]/div/div[1]/form/button/span[1]";
            Common.click(locator);
        }

        public static void goToMyBooks()
        {
            string locator = "//header/div[2]/div//nav/ul/li[2]/a"; 
            Common.click(locator);
        }

        public static string checkAddedBooks()
        {
            string locator = "//table/tbody/tr/td[4]/div/a";
            return Common.getElementText(locator);
        }

        public static void removeBook()
        {
            string locator = "//table/tbody/tr/td[30]/div/div/a"; 
            Common.click(locator);
            Common.okAllert();
            Driver.wait(2000);
        }
    }
}
