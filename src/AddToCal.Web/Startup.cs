using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddToCal.Web.Startup))]
namespace AddToCal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
