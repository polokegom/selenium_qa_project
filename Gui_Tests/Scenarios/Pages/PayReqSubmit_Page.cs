using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;

namespace GuiTests{

    public class PayReqSubmit_Page: BaseTab_Page
    {

        private IWebElement txtboxEmail;
        private IWebElement txtboxDate;
        private IWebElement txtboxAmount;
        private int maxPayRequestSent;
        private IWebElement btnSubmit;

        public PayReqSubmit_Page() {

            txtboxEmail = driver.FindElement(By.XPath(("//*[@id=\"email\"]")));
            txtboxDate = driver.FindElement(By.XPath(("//*[@id=\"due_date\"]")));
            txtboxAmount = driver.FindElement(By.XPath(("//*[@id=\"amount\"]")));
            btnSubmit = driver.FindElement(By.XPath(("//*[@id=\"submit\"]")));

            try{

                maxPayRequestSent = driver.FindElements(By.XPath(("//*[@id=\"paymentrequests\"]//tbody//tr"))).ToList().Count;
            }catch (NoSuchElementException e) {
                maxPayRequestSent = 0;
            }

            
        }

        
            public PayReqSubmit_Page submitPayRequest(string email, string date, int amount) {

                //Initialise default values
                PayReqSubmit_Page payReqSubmit_Page = null; 

                txtboxEmail = driver.FindElement(By.XPath(("//*[@id=\"email\"]")));
                txtboxDate = driver.FindElement(By.XPath(("//*[@id=\"due_date\"]")));
                txtboxAmount = driver.FindElement(By.XPath(("//*[@id=\"amount\"]")));

                btnSubmit = driver.FindElement(By.XPath(("//*[@id=\"submit\"]")));
        //*[@id="paymentrequests"]
                txtboxEmail.Clear();
                txtboxDate.Clear();
                txtboxAmount.Clear();
               
                txtboxEmail.SendKeys(email);
                txtboxDate.SendKeys(date);
                txtboxAmount.SendKeys(amount.ToString());

                btnSubmit.Click();   
                Thread.Sleep(3000); 
           

                try {                                
                  //  Assert.NotNull(expenses);

                    payReqSubmit_Page = new PayReqSubmit_Page();
                    Thread.Sleep(2000);
                } catch(NoSuchElementException e) {
                    payReqSubmit_Page = null;

                }
                
                return payReqSubmit_Page;    
            }


            /*
                Gets the total number of PayRequests
            */
            public int getNumOfPayRequestsSent(){

                return maxPayRequestSent;
            }
            
    }
}