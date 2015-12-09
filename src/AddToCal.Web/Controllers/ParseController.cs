using AddToCal.Logic;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace AddToCal.Web.Controllers
{
    public class ParseController : Controller
    {
        [HttpGet]
        public ActionResult GetAsJsonFromUrl(string url)
        {
            var output = new List<CalendarEvent>();

            var parsers = new List<ICalendarParser> {
                new HCalendarParser(),
                new HEventParser()
            };

            using (var wc = new WebClient())
            {
                var pageSource = wc.DownloadString(url);
                foreach (var parser in parsers)
                    output.AddRange(parser.Parse(pageSource));
            }

            return new JsonResult() { Data = output, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}