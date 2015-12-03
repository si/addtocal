using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddToCal.Logic.Tests
{
    [TestClass]
    public class ICalOutputTests
    {
        [TestMethod]
        public void ICalRenderer_WithValidEvent_OutputsValidICalFormat()
        {
            var expected = "BEGIN:VEVENT\r\nSUMMARY:Summary of iCal test\r\nDESCRIPTION;ENCODED=QUOTED-PRINTABLE:This is the description for the iCal\r\nLOCATION:iCal test place\r\nDTSTART:20151203T215128Z\r\nDTEND:20151204T215128Z\r\nURL:http://addtoc.al\r\nEND:VEVENT\r\n";

            var e = new CalendarEvent {
                Name = "iCal test name",
                Summary = "Summary of iCal test",
                Category = "iCal category",
                Description = "This is the description for the iCal",
                Location = "iCal test place",
                Url = "http://addtoc.al",
                Start = new DateTime(2015,12,03,21,51,28),
                End = new DateTime(2015, 12, 04, 21, 51, 28)
            };

            var sut = new RenderAsiCal(e);
            var actual = sut.Render();

            Assert.AreEqual(expected,actual);
        }
    }
}
