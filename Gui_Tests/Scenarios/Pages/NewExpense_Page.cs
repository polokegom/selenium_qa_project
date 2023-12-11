using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



namespace GuiTests{

    public class NewExpense_Page: BaseTab_Page
        {

            private IWebElement txtboxDescription;
            private IWebElement txtboxDate;
            private IWebElement txtboxAmount;
            private IWebElement btnSubmit;

            public NewExpense_Page() { 
                
                //Initialise all web elements of "New Expense" page
                txtboxDescription = driver.FindElement(By.XPath(("//*[@id=\"description\"]")));
                txtboxDate = driver.FindElement(By.XPath(("//*[@id=\"date\"]")));
                txtboxAmount = driver.FindElement(By.XPath(("//*[@id=\"amount\"]")));
                btnSubmit = driver.FindElement(By.XPath(("//*[@id=\"submit\"]")));

            }

            public Expenses_Page submitNewExpense(string description, string date, int amount) {

                //Initialise default values
                Expenses_Page expensePage = null; 
                txtboxDescription = driver.FindElement(By.XPath(("//*[@id=\"description\"]")));
                txtboxDate = driver.FindElement(By.XPath(("//*[@id=\"date\"]")));
                txtboxAmount = driver.FindElement(By.XPath(("//*[@id=\"amount\"]")));
                btnSubmit = driver.FindElement(By.XPath(("//*[@id=\"submit\"]")));
        
                txtboxDescription.Clear();
                txtboxDate.Clear();
                txtboxAmount.Clear();
               
                txtboxDescription.SendKeys(description);
                txtboxDate.SendKeys(date);
                txtboxAmount.SendKeys(amount.ToString());

                btnSubmit.Click();   
                Thread.Sleep(3000); 

                try {
                    expensePage = new Expenses_Page();
                    Thread.Sleep(2000);
                } catch(NoSuchElementException e) {
                    expensePage = null;
                }
                
                return expensePage;    
            }
            


        }
}