using HtmlAgilityPack;
using System;
using System.Linq;

namespace AddToCal.Logic
{
    public class HCalendarParser: ICalendarParser
    {
        public HCalendarParser()
        {
        }

        public CalendarEvent Parse(string input)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(input);

            return new CalendarEvent
            {
                Url = doc.DocumentNode.SelectSingleNode("//*[contains(@class,'url')]").Attributes["href"].Value,
                Summary = doc.DocumentNode.SelectSingleNode("//*[contains(@class,'summary')]").InnerText,
                Location = doc.DocumentNode.SelectSingleNode("//*[contains(@class,'location')]").InnerText,
                Start = DateTime.Parse(doc.DocumentNode.SelectSingleNode("//*[contains(@class,'dtstart')]").Attributes["datetime"].Value),
                End = DateTime.Parse(doc.DocumentNode.SelectSingleNode("//*[contains(@class,'dtend')]").Attributes["datetime"].Value),
            };
        }
    }
}