# Goodreads_Page_Testing

Asesment of skill for VCS

## Urls

main: <br />
https://www.goodreads.com/  <br />
subpages:  <br />
https://www.goodreads.com/user/sign_in    <br /> 
https://www.goodreads.com/user/sign_up    <br />

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
          - steps <br />
          -(optional) copy 10 min mail  <br />
          -go to sign up page  <br />
          -click sign up with email  <br />
          -enter name  <br />
          -enter email  <br />
          -enter password  <br />
          -repeat password  <br />
          -press create account button <br />  
          -check captcha page  <br />
<br />
2. SignIn
	- Case Signing in		expected result = logged in succesfuly
          - steps <br />
          -go to login page <br />
          -enter email <br />
          -enter pasword <br />
          -click sign in <br />
          -check loged in account <br />
      
3. Logged in user functions
	- Case Search			expected result = correct search result
          - steps <br />
          -log in <br />
          -input to search bar <br />
          -click magnifyingglass(search) <br />
          -check search results <br />

	- Case Add bookshelf	expected result = correct bookshelf added
          - steps
          -click my books <br />
          -click add bookshelf <br />
          -enter bookshelf name <br />
          -click add <br />
          -check added bookshefs <br />
    - case add book         expected result = book added to want to read list
          - steps <br />
          -search for book <br />
          -click add "want to read" <br />
          -click my books <br />
          -check added books <br />


## Quality of life improvements 
test is able to remove added bookshelfs and books so the same account could be reused more easily
