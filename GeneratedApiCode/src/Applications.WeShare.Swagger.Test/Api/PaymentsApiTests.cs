/*
 * WeShare API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Api;
// uncomment below to import models
//using Applications.WeShare.Swagger.Model;

namespace Applications.WeShare.Swagger.Test.Api
{
    /// <summary>
    ///  Class for testing PaymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaymentsApiTests : IDisposable
    {
        private PaymentsApi instance;

        public PaymentsApiTests()
        {
            instance = new PaymentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaymentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PaymentsApi
            //Assert.IsType<PaymentsApi>(instance);
        }

        /// <summary>
        /// Test FindPaymentsMadeByPerson
        /// </summary>
        [Fact]
        public void FindPaymentsMadeByPersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int personId = null;
            //var response = instance.FindPaymentsMadeByPerson(personId);
            //Assert.IsType<List<PaymentDTO>>(response);
        }

        /// <summary>
        /// Test PayPaymentRequest
        /// </summary>
        [Fact]
        public void PayPaymentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewPaymentDTO newPaymentDTO = null;
            //var response = instance.PayPaymentRequest(newPaymentDTO);
            //Assert.IsType<PaymentDTO>(response);
        }
    }
}
