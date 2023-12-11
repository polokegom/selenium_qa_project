using NUnit.Framework;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;
using RestSharp;
using System;


namespace OpenApiTests;

    public class NegativePaymentRequestsTests : PaymentRequestHelper
    {

        // Access
        public static string basePath = "http://localhost:5050";

        public static PaymentRequestsApi _PaymentRequestsApi = new PaymentRequestsApi(basePath);


        [Test]
        public static void CreatePaymentRequestForExpenseThatDoesNotExistTest()
        {


            // Act

            int expenseId = -1;
            int fromPersonId = 1;
            int toPersonId = 3;
            string date = DateTime.Today.ToString("dd/MM/yyyy");
            long amount = 50;


            NewPaymentRequestDTO newPaymentRequestDTO = 
                new NewPaymentRequestDTO(expenseId, fromPersonId, toPersonId, date);


            var exception = Assert.Throws<ApiException>(
                () => _PaymentRequestsApi.CreatePaymentRequest(newPaymentRequestDTO) );


            // Assert
            Assert.That(exception ,Is.Not.Null);
            Assert.That(exception.ErrorCode, Is.EqualTo(404) );
            Assert.That(exception.Message.Contains("Expense not found: "), Is.True) ;

        }






        [Test]
        public static void BrokenFindAllPaymentRequestsTest()
        {
            // The method does not return correct data and does not throw an exception 


            // Act 
            var result =  _PaymentRequestsApi.FindAllPaymentRequests();


            // Assert

            Assert.That(result ,Is.Null);


        }


        [Test]
        public static void BrokenFindPaymentRequestsReceivedByPersonTest()
        {
            // Method does not retun expected data 
            

            // Act 
            int personId_1 = 1;
            int personId_2 = 2;
            int personId_3 = 3;


            var result_1 = _PaymentRequestsApi.FindPaymentRequestsReceived(personId_1);
            var result_2 = _PaymentRequestsApi.FindPaymentRequestsReceived(personId_2);
            var result_3 = _PaymentRequestsApi.FindPaymentRequestsReceived(personId_3);


            // Assert
            Assert.That(result_1, Is.Empty);


            Assert.That(result_2, Is.Null);


            Assert.That(result_3, Is.Null);
       
        }


        [Test]
        public static void FindPaymentRequestsReceivedByNonExistantPersonTest()
        {
            // Method does not retun expected data 
            
            // Act 
            int personId_1 = 16;


            var exception = Assert.Throws<ApiException> ( 
                () =>_PaymentRequestsApi.FindPaymentRequestsReceived(personId_1) ) ;

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(400));
            Assert.That(exception.Message.Contains("Person not found: ") , Is.True);


       
        }


        [Test]
        public static void FindPaymentRequestsReceivedByNegativePersonIdTest()
        {
            
            // Act 
            int personId_1 = -2;


            var exception = Assert.Throws<ApiException> ( 
                ()=>_PaymentRequestsApi.FindPaymentRequestsReceived(personId_1) ) ;


 
            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(400));
            Assert.That(exception.Message.Contains("ID must be greater than 0") , Is.True);

       
        }

        [Test]
        public static void BrokenFindPaymentRequestsSentByPersonTest()
        {
            // Method does not return the correct data

            // Act 
            int paymentRequestId = 1 ;

            var result = _PaymentRequestsApi.FindPaymentRequestsSent(paymentRequestId);

            // Assert


            Assert.That(result , Is.Null);

        }


        [Test]
        public static void NegativeIdFindPaymentRequestsSentByPersonTest()
        {

            // Act 
            int paymentRequestId = -16 ;

            var exception = Assert.Throws<ApiException> ( 
                () => _PaymentRequestsApi.FindPaymentRequestsSent(paymentRequestId) );

            // Assert

            Assert.That(exception , Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(400));
            Assert.That(exception.Message.Contains("ID must be greater than 0") , Is.True);

        }

        [Test]
        public static void NonExistantFindPaymentRequestsSentByPersonTest()
        {

            // Act 
            int paymentRequestId = 16 ;

            var exception = Assert.Throws<ApiException> ( 
                () => _PaymentRequestsApi.FindPaymentRequestsSent(paymentRequestId) );

            // Assert

            Assert.That(exception , Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(404));
            Assert.That(exception.Message.Contains("Person not found: ") , Is.True);

        }



        [Test]
        public static void BrokenGetPaymentRequestByIDTest()
        {
            //Method does not return correct data

            // Act 
            int paymentRequestId = 1 ;
            var result = _PaymentRequestsApi.GetPaymentRequestById(paymentRequestId);

            // Assert
            Assert.That(result , Is.Null);

        }


        [Test]
        public static void GetPaymentRequestByNegativeIDTest()
        {

            // Act 
            int paymentRequestId = -1 ;
            var exception = Assert.Throws<ApiException> ( 
                ()=>_PaymentRequestsApi.GetPaymentRequestById(paymentRequestId) ) ;
            // Assert
            Assert.That(exception , Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(400));
            Assert.That(exception.Message.Contains("ID must be greater than 0") , Is.True);


        }


        [Test]
        public static void GetNonExistantPaymentRequestByTest()
        {

            // Act 
            int paymentRequestId = 39 ;
            var exception = Assert.Throws<ApiException> ( 
                ()=>_PaymentRequestsApi.GetPaymentRequestById(paymentRequestId) ) ;
            // Assert
            Assert.That(exception , Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(404));
            Assert.That(exception.Message.Contains("Payment Request not found: ") , Is.True);

        }


        [Test]
        public static void RecallAnUnpaidPaymentRequestNegativeIdTest()
        {

            // Act 
            int paymentRequestId = -2;


            var exception = Assert.Throws<ApiException> ( 
                ()=>_PaymentRequestsApi.RecallUnpaidPaymentRequest(paymentRequestId) ) ;


            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(400));
            Assert.That(exception.Message.Contains("ID must be greater than 0") , Is.True);

        }


        [Test]
        public static void RecallAnUnpaidPaymentNonExistantExpenseTest()
        {

            // Act 
            int paymentRequestId = 29;


            var exception = Assert.Throws<ApiException> ( 
                ()=>_PaymentRequestsApi.RecallUnpaidPaymentRequest(paymentRequestId) ) ;


            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(404));
            Assert.That(exception.Message.Contains("Payment Request not found: ") , Is.True);

        }



    }


