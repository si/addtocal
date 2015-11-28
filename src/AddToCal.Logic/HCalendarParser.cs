using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AddToCal.Logic
{
    public class HCalendarParser: ICalendarParser
    {
        public HCalendarParser()
        {
        }

        public IList<CalendarEvent> Parse(string input)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(input);
            var result = new List<CalendarEvent>();

            foreach (var e in doc.DocumentNode.SelectNodes("//*[contains(@class,'vevent')]"))
            {
                result.Add(new CalendarEvent
                {
                    Url = e.SelectSingleNode("//*[contains(@class,'url')]").Attributes["href"].Value,
                    Summary = e.SelectSingleNode("//*[contains(@class,'summary')]").InnerText,
                    Location = e.SelectSingleNode("//*[contains(@class,'location')]").InnerText,
                    Start = DateTime.Parse(e.SelectSingleNode("//*[contains(@class,'dtstart')]").Attributes["datetime"].Value),
                    End = DateTime.Parse(e.SelectSingleNode("//*[contains(@class,'dtend')]").Attributes["datetime"].Value),
                });
            }

            return result;
        }
    }
}