using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AGK.Web.Startup))]
namespace AGK.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
