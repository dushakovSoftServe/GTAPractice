using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GTA.Practice.Web.Startup))]
namespace GTA.Practice.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
