using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AddToCal.Logic
{
    // implements hcalendar: http://microformats.org/wiki/hcalendar
    // iCalendar RFC: http://www.ietf.org/rfc/rfc2445.txt

    public class HCalendarParser : ICalendarParser
    {
        public HCalendarParser()
        {
        }

        public IList<CalendarEvent> Parse(string input)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(input);
            var result = new List<CalendarEvent>();

            var nodes = doc.DocumentNode.SelectNodes("//*[contains(@class,'vevent')]");
            if (nodes == null) { return result; }

            foreach (var e in nodes)
            {
                result.Add(new CalendarEvent
                {
                    Url = HtmlNodeHelpers.GetAttributeValue(e.SelectSingleNode("//*[contains(@class,'url')]"), "href"),
                    Summary = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'summary')]")),
                    Category = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'category')]")),
                    Description = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'description')]")),
                    Location = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'location')]")),
                    Start = DateTime.Parse(HtmlNodeHelpers.GetAttributeValue(e.SelectSingleNode("//*[contains(@class,'dtstart')]"),"datetime")),
                    End = DateTime.Parse(HtmlNodeHelpers.GetAttributeValue(e.SelectSingleNode("//*[contains(@class,'dtend')]"),"datetime"))
                });
            }

            return result;
        }
    }
}