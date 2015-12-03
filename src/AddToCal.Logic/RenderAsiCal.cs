using System.Text;

namespace AddToCal.Logic
{
    public class RenderAsiCal
    {
        private CalendarEvent _calendarEvent;

        public RenderAsiCal(CalendarEvent e)
        {
            _calendarEvent = e;
        }

        public string Render()
        {
            var sb = new StringBuilder();
            sb.AppendLine("BEGIN:VEVENT");
            sb.AppendLine("SUMMARY:" + _calendarEvent.Summary);
            //sb.AppendLine("UID:" + _calendarEvent + "@addtoc.al");
            sb.AppendLine("DESCRIPTION;ENCODED=QUOTED-PRINTABLE:" + _calendarEvent.Description);
            sb.AppendLine("LOCATION:" + _calendarEvent.Location);
            sb.AppendLine("DTSTART:" + _calendarEvent.Start.ToString("yyyyMMddTHHmmssZ"));
            sb.AppendLine("DTEND:" + _calendarEvent.End.ToString("yyyyMMddTHHmmssZ"));
            sb.AppendLine("URL:" + _calendarEvent.Url);
            sb.AppendLine("END:VEVENT");

            return sb.ToString();
        }
    }
}