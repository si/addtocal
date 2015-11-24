namespace AddToCal.Logic
{
    public interface ICalendarParser
    {
        CalendarEvent Parse(string input);
    }
}