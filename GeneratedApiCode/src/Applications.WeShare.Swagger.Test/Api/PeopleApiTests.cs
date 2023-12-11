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
    ///  Class for testing PeopleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PeopleApiTests : IDisposable
    {
        private PeopleApi instance;

        public PeopleApiTests()
        {
            instance = new PeopleApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeopleApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeopleApi
            //Assert.IsType<PeopleApi>(instance);
        }

        /// <summary>
        /// Test FindAllPeople
        /// </summary>
        [Fact]
        public void FindAllPeopleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.FindAllPeople();
            //Assert.IsType<List<Person>>(response);
        }

        /// <summary>
        /// Test FindPersonById
        /// </summary>
        [Fact]
        public void FindPersonByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int personId = null;
            //var response = instance.FindPersonById(personId);
            //Assert.IsType<Person>(response);
        }

        /// <summary>
        /// Test Login
        /// </summary>
        [Fact]
        public void LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LoginDTO loginDTO = null;
            //var response = instance.Login(loginDTO);
            //Assert.IsType<Person>(response);
        }
    }
}
