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
        Abstract class that stores all the PageObjects default methods and attributes
    */
    public abstract class Base_Page
    {
        protected static IWebDriver driver=null;
        protected string currentURL = null;
       public string getURL(){

            return driver.Url;
        }

        public string getTitle(){
            
            return driver.Title;
        }

        public void close(){
                
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
        

    }





}