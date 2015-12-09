using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddToCal.Web.Controllers;
using System.Linq;

namespace AddToCal.Web.Tests
{
    [TestClass]
    public class ICalControllerTests
    {
        [TestMethod]
        public void Calling_GetTest_ShouldReturnWithCorrectContentType()
        {
            var sut = new ICalController();
            var result = sut.Get().Result;

            Assert.IsTrue(result.Content.Headers.GetValues("Content-Type").First() == "text/calendar"); 
        }
    }
}
