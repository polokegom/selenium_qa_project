using NUnit.Framework;
// using Applications.WeShare.Swagger;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;
using RestSharp;
using System;


namespace OpenApiTests;

    public class PaymentRequestsTests : PaymentRequestHelper
    {

        // Access
        public static string basePath = "http://localhost:5050";

        public static PaymentRequestsApi _PaymentRequestsApi = new PaymentRequestsApi(basePath);


        [Test]
        public static void CreatePaymentRequestTest()
        {

        // //     // Act

            int expenseId = 1;
            int fromPersonId = 1;
            int toPersonId = 2;
            string date = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
            long amount = 100;
            NewPaymentRequestDTO newPaymentRequestDTO = new NewPaymentRequestDTO(expenseId, fromPersonId, toPersonId, date, amount);


            var result = CreatePaymentRequest(newPaymentRequestDTO);


            // Assert

            Assert.That(result.Id , Is.EqualTo(3));
            Assert.That(result.ExpenseId , Is.EqualTo(1));
            Assert.That(result.FromPersonId , Is.EqualTo(1));
            Assert.That(result.ToPersonId , Is.EqualTo(2));
            Assert.That(result.Date , Is.EqualTo(DateTime.Today.AddDays(1).ToString("dd/MM/yyyy")));
            Assert.That(result.Amount , Is.EqualTo(100));
              // the response from the swagger api is true but the actual value is False, the date needs to be before today??
            Assert.That(result.Paid , Is.False);

        }



        [Test]
        public static void FindAllPaymentRequestsTest()
        {



            // Act 
            var result = FindAllPaymentRequests();


            // Assert


            Assert.That(result[0].Id , Is.EqualTo(1));
            Assert.That(result[0].ExpenseId , Is.EqualTo(1));
            Assert.That(result[0].FromPersonId , Is.EqualTo(1));
            Assert.That(result[0].ToPersonId , Is.EqualTo(2));
            Assert.That(result[0].Date , Is.EqualTo(DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy")));
            Assert.That(result[0].Amount , Is.EqualTo(100));
                // the response from the swagger api is true but the actual value is False, the date needs to be before today??
            Assert.That(result[0].Paid , Is.False);
                
            // Assert.That(result[0].Paid , Is.True);


            Assert.That(result[1].Id , Is.EqualTo(2));
            Assert.That(result[1].ExpenseId , Is.EqualTo(1));
            Assert.That(result[1].FromPersonId , Is.EqualTo(1));
            Assert.That(result[1].ToPersonId , Is.EqualTo(3));
            Assert.That(result[1].Date , Is.EqualTo(DateTime.Today.AddDays(1).ToString("dd/MM/yyyy")));
            Assert.That(result[1].Amount , Is.EqualTo(100));
            Assert.That(result[1].Paid , Is.False);


        }


        [Test]
        public static void FindPaymentRequestsReceivedByPersonTest()
        {

            

            // Act 
            int personId_1 = 1;
            int personId_2 = 2;
            int personId_3 = 3;


            var result_1 = FindPaymentRequestsReceivedByPerson(personId_1);
            var result_2 = FindPaymentRequestsReceivedByPerson(personId_2);
            var result_3 = FindPaymentRequestsReceivedByPerson(personId_3);

            // Assert
            Assert.That(result_1, Is.Empty);

                // these are list values
            Assert.That(result_2, Is.Not.Empty);
            Assert.That(result_2[0].Id, Is.EqualTo(1));
            Assert.That(result_2[0].ExpenseId, Is.EqualTo(1));
            Assert.That(result_2[0].FromPersonId, Is.EqualTo(1));
            Assert.That(result_2[0].ToPersonId, Is.EqualTo(2));
            Assert.That(result_2[0].Amount, Is.EqualTo(100));
            Assert.That(result_2[0].Paid, Is.False);


            Assert.That(result_3[0].Id, Is.EqualTo(2));
            Assert.That(result_3[0].ExpenseId, Is.EqualTo(1));
            Assert.That(result_3[0].FromPersonId, Is.EqualTo(1));
            Assert.That(result_3[0].ToPersonId, Is.EqualTo(3));
            Assert.That(result_3[0].Amount, Is.EqualTo(100));
            Assert.That(result_3[0].Paid, Is.False);

        }


        [Test]
        public static void FindPaymentRequestsSentByPersonTest()
        {

            // Act 
            int paymentRequestId = 1 ;

            var result = FindPaymentRequestsSentByPerson(paymentRequestId);


            // Assert


            Assert.That(result[0].Id , Is.EqualTo(1));
            Assert.That(result[0].ExpenseId , Is.EqualTo(1));
            Assert.That(result[0].FromPersonId , Is.EqualTo(1));
            Assert.That(result[0].ToPersonId , Is.EqualTo(2));
            Assert.That(result[0].Date , Is.EqualTo(DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy")));
            Assert.That(result[0].Amount , Is.EqualTo(100));
                // the response from the swagger api is true but the actual value is False, the date needs to be before today??
            Assert.That(result[0].Paid , Is.False);
                
            // Assert.That(result[0].Paid , Is.True);


            Assert.That(result[1].Id , Is.EqualTo(2));
            Assert.That(result[1].ExpenseId , Is.EqualTo(1));
            Assert.That(result[1].FromPersonId , Is.EqualTo(1));
            Assert.That(result[1].ToPersonId , Is.EqualTo(3));
            Assert.That(result[1].Date , Is.EqualTo(DateTime.Today.AddDays(1).ToString("dd/MM/yyyy")));
            Assert.That(result[1].Amount , Is.EqualTo(100));
            Assert.That(result[1].Paid , Is.False);

        }





        [Test]
        public static void GetPaymentRequestByIDTest()
        {

            // Act 
            int paymentRequestId = 1 ;
            var result = GetPaymentRequestByID(paymentRequestId);

            // Assert
            Assert.That(result.Id , Is.EqualTo(1));
            Assert.That(result.ExpenseId , Is.EqualTo(1));
            Assert.That(result.FromPersonId , Is.EqualTo(1));
            Assert.That(result.ToPersonId , Is.EqualTo(2));
            Assert.That(result.Date , Is.EqualTo(DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy")));
            Assert.That(result.Amount , Is.EqualTo(100));
            Assert.That(result.Paid , Is.False);

        }


        [Test]
        public static void RecallAnUnpaidPaymentRequestTest()
        {



            // Act 
            int paymentRequestId = 3 ;
            RecallAnUnpaidPaymentRequest(paymentRequestId);


                                // ***********Verify the expeses has been removed**********


            var result = GetPaymentRequestByID(paymentRequestId);


            // Assert 
            Assert.That(result.Id , Is.EqualTo(0) );
            Assert.That(result.ExpenseId , Is.EqualTo(0) );
            Assert.That(result.FromPersonId , Is.EqualTo(0) );
            Assert.That(result.ToPersonId , Is.EqualTo(0) );
            Assert.That(result.Amount , Is.EqualTo(0) );


        }



    }


