using System;

namespace AddToCal.Logic
{
    public class CalendarEvent
    {
        public CalendarEvent()
        {
        }

        public string Category { get;  set; }
        public string Description { get;  set; }
        public DateTime End { get;  set; }
        public string Location { get;  set; }
        public string Name { get;  set; }
        public DateTime Start { get;  set; }
        public string Summary { get;  set; }
        public string Url { get;  set; }
    }
}