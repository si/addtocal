using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddToCal.Logic.Tests
{
    [TestClass]
    public class HEventTests
    {
        [TestMethod]
        public void HEvent_StringContent_ShouldParseEvent()
        {
            var input = @"<div class=""h-event"">  <h1 class=""p-name"">Microformats Meetup</h1>  <p>From    <time class=""dt-start"" datetime=""2013-06-30 12:00"">30<sup>th</sup> June 2013, 12:00</time>    to<time class=""dt-end"" datetime=""2013-06-30 18:00"">18:00</time>    at<span class=""p-location"">Some bar in SF</span></p>  <p class=""p-summary"">Get together and discuss all things microformats-related.</p></div>";

            var sut = new HEventParser();
            var actual = sut.Parse(input)[0];

            Assert.AreEqual("Some bar in SF", actual.Location);
            Assert.AreEqual("Microformats Meetup", actual.Name);
            Assert.AreEqual("Get together and discuss all things microformats-related.", actual.Summary);
            Assert.AreEqual(new DateTime(2013, 6, 30, 12, 0, 0), actual.Start);
            Assert.AreEqual(new DateTime(2013, 6, 30, 18, 0, 0), actual.End);
        }
    }
}
