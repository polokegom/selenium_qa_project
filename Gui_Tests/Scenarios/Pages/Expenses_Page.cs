using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;


namespace GuiTests
{


    public class Expenses_Page: BaseTab_Page
    {

        private IWebElement linkAddNewExpense;
        private string loggedInUser;
        private static List<IWebElement> listOfExpenses = new List<IWebElement>();
        /*
            Constructor of Expense class
        */        
        public Expenses_Page() {

            linkAddNewExpense = driver.FindElement(By.XPath(("//*[@id=\"add_expense\"]")));
            
            //Initialise list of all expenses
    

            try{

            listOfExpenses = driver.FindElements(By.XPath("//*[@id='expenses']//a")).ToList();;
            loggedInUser = driver.FindElement(By.Id("user")).Text;
            }catch (NoSuchElementException e) {
            
            }

        }
            
        


        /*
            Clicks the "Add new expense" link
        */
        public NewExpense_Page clickAddNewExpense(){


            linkAddNewExpense = driver.FindElement(By.XPath(("//*[@id=\"add_expense\"]")));
            linkAddNewExpense.Click();   
            Thread.Sleep(2000);   

            //Go to Payment Requests Submit Page
            NewExpense_Page newExpensePage = new NewExpense_Page();
            Thread.Sleep(2000);
            return newExpensePage;
        }




        /*
            Click  an "expense" using its index from the list & hyperlink to the "Payment Request Submit Page"
        */
        public PayReqSubmit_Page clickExpense(int index){


            listOfExpenses[index].Click();   
            Thread.Sleep(2000);   

            //Go to Payment Requests Submit Page
            PayReqSubmit_Page payReqSubmit_Page = new PayReqSubmit_Page();
            Thread.Sleep(2000);
            return payReqSubmit_Page;
        }

        public string whoIsLoggedIn(){

            return loggedInUser;
        }

        /*
            Gets the total number of Expenses
        */
        public int getNumOfExpenses(){

            return listOfExpenses.Count;
        }
    }
}
