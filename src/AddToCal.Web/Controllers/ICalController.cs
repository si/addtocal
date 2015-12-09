using AddToCal.Logic;
using System.Text;
using System.Web.Mvc;

namespace AddToCal.Web.Controllers
{
    public class ICalController : Controller
    {
        //[HttpGet]
        [HttpPost]
        public ActionResult GetFromEvent(CalendarEvent e)
        {
            var iCal = new RenderAsiCal(e).Render();
            var byteResult = Encoding.UTF8.GetBytes(iCal);
            return File(byteResult, "text/calendar");
        }
    }
}