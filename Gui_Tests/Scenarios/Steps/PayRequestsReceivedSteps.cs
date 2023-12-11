
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Gauge.CSharp.Lib;
using NUnit.Framework;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;

namespace GuiTests {

    public class PayRequestsReceivedSteps
    {


            [BeforeSuite]
            public void Setup()
            {
                
            // loginPage = new Login_Page();
                
            }

            [AfterSuite]
            public void teardown()
            {

                
            }

    }
}