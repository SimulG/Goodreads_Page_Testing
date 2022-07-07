using NUnit.Framework;
using Framework.Pages;
using Tests.BaseClasses;

namespace Tests
{
    internal class LoggedInUser : BaseLogin
    {
        [Test, Order(1)]
        public static void bookSearch()
        {
            string expectedText = "1984",
                actualText;

            LoggedInUserPage.inputSearchBoxText();
            LoggedInUserPage.clickSearch();
            actualText =
                LoggedInUserPage.checkSearchResult();

            Assert.IsTrue(actualText == expectedText);
        }
        [Test, Order(2)]
        public static void addBookshelf()
        {
            string expectedResult = "ownedbooks",
                actualResult;

            LoggedInUserPage.clickMyBooks();
            LoggedInUserPage.clickAddShelf();
            LoggedInUserPage.inputBookshelfName();
            actualResult =
                LoggedInUserPage.checkShelfs();

            if (actualResult.Contains(expectedResult))
                LoggedInUserPage.removeShelf();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
        [Test, Order(3)]
        public static void addReadBookAndReview()
        {
            string expectedBook = "1984",
                actualBook;
            LoggedInUserPage.inputSearchBoxText();
            LoggedInUserPage.clickSearch();
            LoggedInUserPage.addBookToWantToReadBookshelf();
            LoggedInUserPage.waitTenSec();
            LoggedInUserPage.goToMyBooks();
            actualBook =
                LoggedInUserPage.checkAddedBooks();

            if (actualBook.Contains(expectedBook))
                LoggedInUserPage.removeBook();

            Assert.IsTrue(actualBook.Contains(expectedBook));
        }
        

    }
}
