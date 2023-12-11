using NUnit.Framework;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;
using RestSharp;
using System;


namespace OpenApiTests;

    public class NegativeExpensesTests
    {

        // Access
        public static string basePath = "http://localhost:5050";

        public static ExpensesApi _expensesApi = new ExpensesApi(basePath);

        [Test]
        public static void NonExistantPersonCreateNewExpenseTest()
        {
            // Act 
            NewExpenseDTO newExpenseDTO = 
                new NewExpenseDTO(16, DateTime.Today.ToString("dd/MM/yyyy"), "blue", 600);


            var exception = Assert.Throws<ApiException> ( 
                () => _expensesApi.CreateExpense(newExpenseDTO) ) ;

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(404));
            Assert.That(exception.Message.Contains("Person not found: ") , Is.True);

        }




       [Test]
        public void NonExistantPersonFindExpenseByPersonIdTest()
        {
            //Act.
            int PersonId = 16;

            var exception = Assert.Throws<ApiException> ( 
                () => _expensesApi.FindExpensesByPerson(PersonId) ) ;

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(404));
            Assert.That(exception.Message.Contains("Person not found: ") , Is.True);

        }


        [Test]
        public void NegativeIdFindExpenseByPersonIdTest()
        {
            //Act.
            int PersonId = -1;
            var exception = Assert.Throws<ApiException> ( 
                ()=> _expensesApi.FindExpensesByPerson(PersonId) ) ;

 
            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.ErrorCode , Is.EqualTo(400));
            Assert.That(exception.Message.Contains("ID must be greater than 0") , Is.True);
        }



       [Test]
        public void FindExpensesByNegativeExpenseIdTest()
        {
            //Act
            int ExpenseId = -1;
            var exception = Assert.Throws<ApiException>(
                () => _expensesApi.FindExpenseById(ExpenseId) );


            // Assert

            Assert.That(exception ,Is.Not.Null);
            Assert.That(exception.ErrorCode, Is.EqualTo(400) );
            Assert.That(exception.Message.Contains("ID must be greater than 0") , Is.True);

        }


        [Test]
        public void FindExpensesByExpenseIdForNonExistantPersonTest()
        {
            //Act
            int ExpenseId = 91;

            var exception = Assert.Throws<ApiException>(
                () => _expensesApi.FindExpenseById(ExpenseId) );


            // Assert

            Assert.That(exception ,Is.Not.Null);
            Assert.That(exception.ErrorCode, Is.EqualTo(404) );
            Assert.That(exception.Message.Contains("Expense not found: "), Is.True) ;

        }


    }

