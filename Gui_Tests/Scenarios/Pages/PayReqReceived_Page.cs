using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace GuiTests {

public struct PaymentRequest
{
    public bool hasPaid { get; set; }
    public IWebElement btnPay;
}

public class PayReqReceived_Page: BaseTab_Page
    {
        
        List<PaymentRequest> listOfPayRequests = new List<PaymentRequest>();
        public  PayReqReceived_Page() {

            //Initialise list of Payment Requests Received
            int unit = 1;
            do {

                try{

                    IWebElement element = driver.FindElement(By.XPath(("//*[@id=\"paymentrequest_" +unit.ToString())));
                //IReadOnlyCollection<IWebElement> submitInputs = driver.FindElements(By.XPath("//*[@id='paymentrequests_received']//tr"));
                    PaymentRequest payRequest = new PaymentRequest();
                    try{
                        element = driver.FindElement(By.XPath(("//*[@id=\"paymentrequest_" +unit.ToString()+"\"]//*[@id=\"submit\"]")));
                        payRequest.hasPaid = false;
                        payRequest.btnPay = element;

                    }catch (NoSuchElementException e) {
                        payRequest.hasPaid = true;
                        payRequest.btnPay = null;
                    }

                    listOfPayRequests.Add(payRequest);
                    unit +=1; 
                }catch (NoSuchElementException e) {
                    unit = -1;
                }
            } while(unit >  1);
        }

        public bool hasPayRequestBeenPaid(int index) {

            return listOfPayRequests[index].hasPaid;
        }



        public void clickPayRequest(int index) {
            PaymentRequest paymentRequest = listOfPayRequests[index];
            paymentRequest.hasPaid = true; 
            listOfPayRequests[index].btnPay.Click();
            listOfPayRequests[index] = paymentRequest;

        }


        public int getMaxPayRequest(){

            return listOfPayRequests.Count;
        }
    }
}