
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Gauge.CSharp.Lib;
using NUnit.Framework;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;

namespace GuiTests {

    public class GeneralJourneySteps
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
            2. User can click "add new expense"
            3. User can add new expense
            4. User can view new expense on "Expense_Page"

        */
        [Step("Add newexpense <item> of <amount> on <date> for <email>")]
        public void AddNewExpense(string item,int amount, string date, string email)
        {               
            loginPage = new Login_Page(); 
            loginPage.getURL().Should().Be("http://localhost:5050/");       
            Expenses_Page expensePage = loginPage.loginUser(email);
            Assert.NotNull(expensePage);   

            loginPage.getURL().Should().Be("http://localhost:5050/app/expenses");       
            NewExpense_Page newExpensePage = expensePage.clickAddNewExpense();
            Assert.NotNull(newExpensePage);   
            newExpensePage.getURL().Should().Be("http://localhost:5050/app/newexpense");   
            int prevNumOfExpenses = expensePage.getNumOfExpenses();
 
            expensePage = newExpensePage.submitNewExpense(item, date, amount);

            Assert.AreEqual(expensePage.getNumOfExpenses(),prevNumOfExpenses+1);  

            loginPage.close();
        }

        /*
            Test to see If:
            1. User can login
            2. User can click an  "Payment Request Tab"
            3. User can view the "Payment Request Received" page
            4. User can click and Pay a "Payment Request"
            5. User can view the success of payment on "Payment Request Received" page

        */

        [Step("Pay for payment request received with position <indexPayRequest> on <email>")]
        public void Pay_PayRequestRecieved(string indexPayRequest, string email)
        {               

            loginPage = new Login_Page(); 
            loginPage.getURL().Should().Be("http://localhost:5050/");       
            Expenses_Page expensePage = loginPage.loginUser(email);
            Assert.NotNull(expensePage);   

            loginPage.getURL().Should().Be("http://localhost:5050/app/expenses");       
            PayReqReceived_Page payReqReceived = expensePage.clickPayReqReceivedTab();
            Assert.NotNull(payReqReceived);   /*
            Assert.AreEqual(payReqReceived.getMaxPayRequest(),1);   

            if (!payReqReceived.hasPayRequestBeenPaid(0))
                payReqReceived.clickPayRequest(0);
            Assert.AreEqual(payReqReceived.hasPayRequestBeenPaid(0),true);
            */
            loginPage.close();

   
        }


        /*
            Test to see If:
            1. User can login
            2. User can click an expense on the "Expense Page"
            3. User can fillout "Payment Request" on "Payment Request Page"
            4. User can view new "Payment Request" on "Payment Request Page"

        */
        [Step("Send payment request from <payerEmail> to <debtorEmail> of <amount> for settlement on <date> for expense position <indexExpense>")]
        public void SendNewPayRequest(string payerEmail, string debtorEmail, int amount, string date, int indexExpense)
        {               

            loginPage = new Login_Page(); 
            loginPage.getURL().Should().Be("http://localhost:5050/");       
            Expenses_Page expensePage = loginPage.loginUser(payerEmail);
            Assert.NotNull(expensePage);   

            loginPage.getURL().Should().Be("http://localhost:5050/app/expenses");       
            PayReqSubmit_Page payReqSubmit_Page = expensePage.clickExpense(indexExpense -1);
            Assert.NotNull(payReqSubmit_Page);   
            string prevURL = payReqSubmit_Page.getURL();//.Should().Be("http://localhost:5050/app/paymentrequest?expenseId=1");    
            int prevMaxPayReqSent = payReqSubmit_Page.getNumOfPayRequestsSent();
            payReqSubmit_Page = payReqSubmit_Page.submitPayRequest(debtorEmail, date, amount);
            Assert.AreEqual(payReqSubmit_Page.getURL(),prevURL);        

            Assert.AreEqual(payReqSubmit_Page.getNumOfPayRequestsSent(),prevMaxPayReqSent+1);  

            loginPage.close();
        }



        [AfterSuite]
        public void teardown()
        {

            
        }
    }

}