using System.Collections.Generic;

namespace AddToCal.Logic
{
    public interface ICalendarParser
    {
        IList<CalendarEvent> Parse(string input);
    }
}