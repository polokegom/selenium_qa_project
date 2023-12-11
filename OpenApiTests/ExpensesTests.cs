using NUnit.Framework;
using Applications.WeShare.Swagger;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;
using RestSharp;
using System;


namespace OpenApiTests;

    public class ExpensesTests
    {

        // Access
        public static string basePath = "http://localhost:5050";

        public static ExpensesApi _expensesApi = new ExpensesApi(basePath);

        [Test]
        public static void CreateNewExpenseTest()
        {
        //     // Act
            NewExpenseDTO newExpenseDTO = new NewExpenseDTO(1, DateTime.Today.ToString("dd/MM/yyyy"), "blue", 600);
            ExpenseDTO result = _expensesApi.CreateExpense(newExpenseDTO);

        //     // Assert
            Assert.That(result.Amount , Is.EqualTo(600));
            Assert.That(result.Description , Is.EqualTo("blue"));
            Assert.That(result.PersonId , Is.EqualTo(1));
            Assert.That(result.Date , Is.EqualTo(DateTime.Today.ToString("dd/MM/yyyy")));

        }


        [Test]
        public void FindAllExpenses()
        {
            //Act
            System.Collections.Generic.List<ExpenseDTO> result = _expensesApi.FindAllExpenses();        

            // Assert
                //this will fail if tests are ran with the same instance of teh docker image running
            Assert.That(result.Count, Is.EqualTo(6));

            Assert.That(result[0].Amount , Is.EqualTo(300));
            Assert.That(result[0].TotalPaymentsRequested , Is.EqualTo(200));
            Assert.That(result[0].TotalPaymentsReceived , Is.EqualTo(100));
            Assert.That(result[0].NettAmount , Is.EqualTo(200));
            Assert.That(result[0].ExpenseId , Is.EqualTo(1));
            Assert.That(result[0].PersonId , Is.EqualTo(1));
            Assert.That(result[0].Date , Is.EqualTo(DateTime.Today.AddDays(-5).ToString("dd/MM/yyyy")));
            Assert.That(result[0].Description , Is.EqualTo("Lunch"));



                    //Last expense entriy
            Assert.That(result[5].Amount , Is.EqualTo(600));
            Assert.That(result[5].TotalPaymentsRequested , Is.EqualTo(0));
            Assert.That(result[5].TotalPaymentsReceived , Is.EqualTo(0));
            Assert.That(result[5].NettAmount , Is.EqualTo(600));
            Assert.That(result[5].ExpenseId , Is.EqualTo(6));
            Assert.That(result[5].PersonId , Is.EqualTo(1));
            Assert.That(result[5].Date , Is.EqualTo(DateTime.Today.ToString("dd/MM/yyyy")));
            Assert.That(result[5].Description , Is.EqualTo("blue"));



        }


       [Test]
        public void FindExpenseByPersonId()
        {
            //Act.
            int PersonId = 1;
            System.Collections.Generic.List<ExpenseDTO> result = _expensesApi.FindExpensesByPerson(PersonId);


                        // Assert
            Assert.That(result[0].Amount , Is.EqualTo(300));
            Assert.That(result[0].TotalPaymentsRequested , Is.EqualTo(200));
            Assert.That(result[0].TotalPaymentsReceived , Is.EqualTo(100));
            Assert.That(result[0].NettAmount , Is.EqualTo(200));
            Assert.That(result[0].ExpenseId , Is.EqualTo(1));
            Assert.That(result[0].PersonId , Is.EqualTo(1));
            Assert.That(result[0].Date , Is.EqualTo(DateTime.Today.AddDays(-5).ToString("dd/MM/yyyy")));
            Assert.That(result[0].Description , Is.EqualTo("Lunch"));



            Assert.That(result[1].Amount , Is.EqualTo(100));
            Assert.That(result[1].TotalPaymentsRequested , Is.EqualTo(0));
            Assert.That(result[1].TotalPaymentsReceived , Is.EqualTo(0));
            Assert.That(result[1].NettAmount , Is.EqualTo(100));
            Assert.That(result[1].ExpenseId , Is.EqualTo(2));
            Assert.That(result[1].PersonId , Is.EqualTo(1));
            Assert.That(result[1].Date , Is.EqualTo(DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy")));
            Assert.That(result[1].Description , Is.EqualTo("Airtime"));

        }

       [Test]
        public void FindExpensesByExpenseId()
        {
            //Act
            int ExpenseId = 1;
            ExpenseDTO result = _expensesApi.FindExpenseById(ExpenseId);

                        // Assert
            Assert.That(result.Amount , Is.EqualTo(300));
            Assert.That(result.TotalPaymentsRequested , Is.EqualTo(200));
            Assert.That(result.TotalPaymentsReceived , Is.EqualTo(100));
            Assert.That(result.NettAmount , Is.EqualTo(200));
            Assert.That(result.ExpenseId , Is.EqualTo(1));
            Assert.That(result.PersonId , Is.EqualTo(1));
            Assert.That(result.Date , Is.EqualTo(DateTime.Today.AddDays(-5).ToString("dd/MM/yyyy")));
            Assert.That(result.Description , Is.EqualTo("Lunch"));


        }


    }

