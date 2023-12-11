using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Gauge.CSharp.Lib;
using NUnit.Framework;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;

namespace GuiTests
{
    public class LoginLogoutSteps
    {   
        private Login_Page loginPage;

        [BeforeSuite]
        public void Setup()
        {
            
            loginPage = new Login_Page();
            
        }

        /*
            Test to see If:
            1. User can login
            2. Click Logout tab
            3. view Login Page verifying users logged out

        */
        [Step("Use <email> for valid emails")]
        public void StudentLoginLogout(string email)
        {              
            loginPage = new Login_Page(); 
            loginPage.getURL().Should().Be("http://localhost:5050/");       
            Expenses_Page expensePage = loginPage.loginUser(email);
            loginPage.getURL().Should().Be("http://localhost:5050/app/expenses");       
            Assert.NotNull(expensePage);   
            Login_Page returnedLoginPage = expensePage.clickLogoutTab();
            returnedLoginPage.getURL().Should().Be("http://localhost:5050/index.html");       

            Assert.NotNull(returnedLoginPage);
            loginPage.close();


        }

        /*
            Negative Test to see If:
            1. Invalid User cannot login


        */

        [Step("Use <email> for invalid emails")]
        public void LoginLogoutValidEmails(string email)
        {               
            /*
            loginPage = new Login_Page();
            loginPage.getURL().Should().Be("http://localhost:5050/");       
            Expenses_Page expensePage = loginPage.loginUser(email);
            loginPage.getURL().Should().Be("http://localhost:5050/app/expenses");       
            Assert.NotNull(expensePage);   
            Login_Page returnedLoginPage = expensePage.clickLogoutTab();
            returnedLoginPage.getURL().Should().Be("http://localhost:5050/index.html");       

             Assert.NotNull(returnedLoginPage);
             */
        }



        [AfterSuite]
        public void teardown()
        {

            if (loginPage != null)
                loginPage.close();
            
        }

    }
}
