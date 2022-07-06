using Framework;
using NUnit.Framework;
using Framework.Pages;
using Tests.BaseClasses;
using System;

namespace Tests
{
    internal class LoggedInUser : BaseLogin
    {
        [Test]
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
        [Test]
        public static void addBookshelf()
        {
            string expectedResult = "ownedbooks",
                actualResult;

            LoggedInUserPage.clickMyBooks();
            LoggedInUserPage.clickAddShelf();
            LoggedInUserPage.inputBookshelfName();
            actualResult =
                LoggedInUserPage.checkShelfs();

            if (actualResult == expectedResult)
                LoggedInUserPage.removeShelf();

            Assert.IsTrue(actualResult == expectedResult);
        }
        [Test]
        public static void addReadBookAndReview()
        {
            string expectedBook = "1984",
                actualBook;
            LoggedInUserPage.inputSearchBoxText();
            LoggedInUserPage.clickSearch();
            LoggedInUserPage.addBookToWantToReadBookshelf();
            LoggedInUserPage.goToMyBooks();
            actualBook =
                LoggedInUserPage.checkAddedBooks();

            if (actualBook == expectedBook)
                LoggedInUserPage.removeBook();

            Assert.IsTrue(actualBook == expectedBook);
        }
        

    }
}
