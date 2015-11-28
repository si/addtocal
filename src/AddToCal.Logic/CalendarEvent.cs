using System;

namespace AddToCal.Logic
{
    public class CalendarEvent
    {
        public CalendarEvent()
        {
        }

        public string Category { get; internal set; }
        public string Description { get; internal set; }
        public DateTime End { get; internal set; }
        public string Location { get; internal set; }
        public string Name { get; internal set; }
        public DateTime Start { get; internal set; }
        public string Summary { get; internal set; }
        public string Url { get; internal set; }
    }
}