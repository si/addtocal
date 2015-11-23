using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddToCal.Logic.Tests
{
    [TestClass]
    public class HCalendarTests
    {
        [TestMethod]
        public void HCalendar_StringContent_ShouldParseEvent()
        {
            var input = @"<section class=""vevent""><a class=""url"" href=""http://conferences.oreillynet.com/pub/w/40/program.html"">http://conferences.oreillynet.com/pub/w/40/program.html</a><span class=""summary"">Web 2.0 Conference</span>: <time class=""dtstart"" datetime=""2005-10-05"">October 5</time>-<time class=""dtend"" datetime=""2005-10-07"">7</time>, at the <span class=""location"">Argent Hotel, San Francisco, CA</span></section>";

            var sut = new HCalendarParser();
            var actual = sut.Parse(input);

            Assert.AreEqual("Argent Hotel, San Francisco, CA", actual.Location);
            Assert.AreEqual("Web 2.0 Conference", actual.Summary);
            Assert.AreEqual("http://conferences.oreillynet.com/pub/w/40/program.html", actual.Url);
            Assert.AreEqual(new DateTime(2005, 10, 05, 0, 0, 0), actual.Start);
            Assert.AreEqual(new DateTime(2005, 10, 07, 0, 0, 0), actual.End);
        }
    }
}
