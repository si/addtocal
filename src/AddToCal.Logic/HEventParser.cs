using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace AddToCal.Logic
{
    // implements microformat2 h-event: http://microformats.org/wiki/h-event
    public class HEventParser : ICalendarParser
    {
        public HEventParser()
        {
        }

        public IList<CalendarEvent> Parse(string input)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(input);
            var result = new List<CalendarEvent>();

            var nodes = doc.DocumentNode.SelectNodes("//*[contains(@class,'h-event')]");
            if (nodes == null) { return result; }

            foreach (var e in nodes)
            {
                result.Add(new CalendarEvent
                {
                    Url = HtmlNodeHelpers.GetAttributeValue(e.SelectSingleNode("//*[contains(@class,'u-url')]"),"href"),
                    Name = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'p-name')]")),
                    Category = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'p-category')]")),
                    Description = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'p-description')]")),
                    Summary = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'p-summary')]")),
                    Location = HtmlNodeHelpers.GetInnerText(e.SelectSingleNode("//*[contains(@class,'p-location')]")),
                    //Start = DateTime.Parse(HtmlNodeHelpers.GetAttributeValue( e.SelectSingleNode("//*[contains(@class,'dt-start')]"), "datetime")),
                    //End = DateTime.Parse(HtmlNodeHelpers.GetAttributeValue(e.SelectSingleNode("//*[contains(@class,'dt-end')]"), "datetime")),
                });
            }

            return result;
        }
    }
}