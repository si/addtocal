using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddToCal.Web.Controllers;
using AddToCal.Logic;
using System.Web.Mvc;

namespace AddToCal.Web.Tests
{
    [TestClass]
    public class ICalControllerTests
    {
        [TestMethod]
        public void Calling_GetTest_ShouldReturnWithCorrectContentType()
        {
            var sut = new ICalController();
            var result = (FileResult)sut.GetFromEvent(new CalendarEvent {
                Category = "test category",
                Description = "test description",
                Location = "test location",
                Name = "test name",
                Summary = "test summary",
                Url = "test url",
                Start = DateTime.UtcNow,
                End =DateTime.UtcNow.AddMinutes(10)
            });

            Assert.AreEqual("text/calendar", result.ContentType); 
        }
    }
}
