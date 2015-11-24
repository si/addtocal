using HtmlAgilityPack;
using System;

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
                Url = doc.DocumentNode.SelectSingleNode("[@class='url']").Attributes["href"].Value,
                Summary = doc.DocumentNode.SelectSingleNode("[@class='summary']").InnerText,
                Location = doc.DocumentNode.SelectSingleNode("[@class='location']").InnerText,

            };
        }
    }
}