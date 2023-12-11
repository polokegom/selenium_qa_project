using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System.Threading;

namespace GuiTests
{


    /*
        Base class that stores all the Tab functions of the site
    */
    public abstract class BaseTab_Page:Base_Page
    {


        protected static IWebElement btnTabExpense;
        protected static IWebElement btnTabPayReqReceived;
        protected static IWebElement btnTabPayReqSent;
        protected static IWebElement btnTabLogout;

        /*
            Constructor of the class
        */
        public BaseTab_Page() {

            
            //Initialise the tab buttons on the top menu
            btnTabExpense = driver.FindElement(By.XPath(("//*[@id='expenses']")));
            btnTabPayReqSent = driver.FindElement(By.XPath(("//*[@id='paymentrequests_sent']")));
            btnTabPayReqReceived = driver.FindElement(By.XPath(("//*[@id=\"paymentrequests_received\"]")));
            btnTabLogout = driver.FindElement(By.XPath(("//*[@id=\"logout\"]")));
             
        
        }

         /*
            Clicks the Expense Tab
        */
        public Expenses_Page clickExpenseTab(){

            btnTabExpense = driver.FindElement(By.XPath(("//*[@id='expenses']")));
            btnTabExpense.Click();   
            Thread.Sleep(2000);   

            //Go to Expense Page
            Expenses_Page expensePage = new Expenses_Page();
            Thread.Sleep(2000);
            return expensePage;

        }


        /*
            Clicks the Payment Request Received Tab
        */
        public PayReqReceived_Page clickPayReqReceivedTab(){


            btnTabPayReqReceived = driver.FindElement(By.XPath(("//*[@id=\"paymentrequests_received\"]")));
            btnTabPayReqReceived.Click();   
            Thread.Sleep(1000);   

            //Go to Payment Request received Page
            PayReqReceived_Page payReqReceivedPage = new PayReqReceived_Page();
            Thread.Sleep(1000);
            return payReqReceivedPage;
        }


        /*
            Clicks the Payment Request Sent Tab
        */
        public PayReqSent_Page clickPayReqSentTab(){


            btnTabPayReqSent = driver.FindElement(By.XPath(("//*[@id=\"paymentrequests_sent\"]")));
            btnTabPayReqSent.Click();   
            Thread.Sleep(2000);   
 
            //Go to Payment Requests Sent Page
            PayReqSent_Page payReqSentPage = new PayReqSent_Page();
            Thread.Sleep(2000);
            return payReqSentPage;

        }


        /*
            Clicks the Logout Tab
        */
        public Login_Page clickLogoutTab(){


            btnTabLogout = driver.FindElement(By.XPath(("//*[@id=\"logout\"]")));
            btnTabLogout.Click();   
            Thread.Sleep(2000);   


            //Go to Login Page
            Login_Page loginPage = new Login_Page();
            Thread.Sleep(2000);
            return loginPage;

        }



    }
}