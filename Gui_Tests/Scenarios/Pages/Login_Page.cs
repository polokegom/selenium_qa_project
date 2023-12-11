using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

namespace GuiTests {


    /*
        This program is designed to run sequentially and not parralel
    */
    public class Login_Page : Base_Page
    {

        private static IWebElement txtboxLogin;
        private static IWebElement btnLogin;
        string homeURL = "http://localhost:5050";

        public Login_Page() {

            if (driver == null)  {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");
                driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl(homeURL);
                Thread.Sleep(1000);

            } 
            txtboxLogin = driver.FindElement(By.XPath(("//*[@id='email']")));
            btnLogin = driver.FindElement(By.XPath(("//*[@id='submit']")));            
        }

        public Expenses_Page loginUser(string email){
                //Initialise default values
                Expenses_Page expensePage = null; 
                txtboxLogin = driver.FindElement(By.XPath(("//*[@id='email']")));
                btnLogin = driver.FindElement(By.XPath(("//*[@id='submit']")));
        
                txtboxLogin.Clear();
                txtboxLogin.SendKeys(email);
                btnLogin.Click();   
                Thread.Sleep(500);   
                try {
                    expensePage = new Expenses_Page();            
                    Thread.Sleep(500);
                    
                } catch(NoSuchElementException e) {
                    expensePage = null;
                }
               
                return expensePage;


        }





 
    }

} 