using AddToCal.Logic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AddToCal.Web.Controllers
{
    public class ICalController : ApiController
    {
        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {
            var input = @"<div class=""h-event"">  <h1 class=""p-name"">Microformats Meetup</h1>  <p>From    <time class=""dt-start"" datetime=""2013-06-30 12:00"">30<sup>th</sup> June 2013, 12:00</time>    to<time class=""dt-end"" datetime=""2013-06-30 18:00"">18:00</time>    at<span class=""p-location"">Some bar in SF</span></p>  <p class=""p-summary"">Get together and discuss all things microformats-related.</p></div>";
            var e = new HEventParser().Parse(input)[0];
            var iCal = new RenderAsiCal(e).Render();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            //var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            var byteContent = Encoding.UTF8.GetBytes(iCal);
            response.Content = new StringContent(iCal, Encoding.UTF8, "text/calendar");
            response.Content.Headers.Add("filename", e.Name + ".ics");
            response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment") { FileName = e.Name + ".ics" };
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/calendar");

            return Task.FromResult(response);
        }

        //// GET: ICal
        //public HttpResponseMessage GetFromEvent(CalendarEvent e)
        //{
        //    var iCal = new RenderAsiCal(e).Render();

        //    var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        //    response.Content = new StringContent(iCal);
        //    response.Headers.Add("filename", e.Name + ".ics");
        //    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/calendar");

        //    return response;
        //}
    }
}