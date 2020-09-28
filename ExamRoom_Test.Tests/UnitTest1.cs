using System;
using System.Net.Http;
using System.Web.Http;
using ExamRoom_Test.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamRoom_Test.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new ApplicationController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            // Act on Test  
            var response = controller.Get(1);
            // Assert the result  
            Assert.IsNotNull(response);
        }
    }
}
