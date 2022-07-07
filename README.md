# Goodreads_Page_Testing

Asesment of skill for VCS

## Urls

main:
https://www.goodreads.com/  
subpages:
https://www.goodreads.com/user/sign_in      
https://www.goodreads.com/user/sign_up

extra used pages
https://10minemail.com/en/

## NuGet Packages used
-Framework-
"DotNetSeleniumExtras.WaitHelpers" version="3.11.0" targetFramework="net472" 
"Microsoft.CodeCoverage" version="17.2.0" targetFramework="net472" 
"Microsoft.NET.Test.Sdk" version="17.2.0" targetFramework="net472" 
"NUnit" version="3.13.3" targetFramework="net472" 
"Selenium.Support" version="4.3.0" targetFramework="net472" 
"Selenium.WebDriver" version="4.3.0" targetFramework="net472" 
"Selenium.WebDriver.ChromeDriver" version="103.0.5060.5300" targetFramework="net472" 

-Tests-
"Microsoft.CodeCoverage" version="17.2.0" targetFramework="net472"
"Microsoft.NET.Test.Sdk" version="17.2.0" targetFramework="net472"
"NUnit" version="3.13.3" targetFramework="net472"
"Unit3TestAdapter" version="4.2.1" targetFramework="net472"
"Selenium.WebDriver" version="4.3.0" targetFramework="net472"
"Selenium.WebDriver.ChromeDriver" version="103.0.5060.5300" targetFramework="net472"


### Test plan
Make 5 different tests for selected page

- Test scenearios - 
1. SignUp
	- Case Signing up		expected result = Reach capthca check
          - steps
          -(optional) copy 10 min mail
          -go to sign up page
          -click sign up with email
          -enter name
          -enter email
          -enter password
          -repeat password
          -press create account button
          -check captcha page

2. SignIn
	- Case Signing in		expected result = logged in succesfuly
          - steps
          -go to login page
          -enter email
          -enter pasword
          -click sign in
          -check loged in account
      
3. Logged in user functions
	- Case Search			expected result = correct search result
          - steps
          -log in
          -input to search bar
          -click magnifyingglass(search)
          -check search results

	- Case Add bookshelf	expected result = correct bookshelf added
          - steps
          -click my books
          -click add bookshelf
          -enter bookshelf name 
          -click add
          -check added bookshefs
    - case add book         expected result = book added to want to read list
          - steps
          -search for book
          -click add "want to read"
          -click my books
          -check added books


## Quality of life improvements 
test is able to remove added bookshelfs and books so the same account could be reused more easily
