using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestAPI1.Startup))]
namespace RestAPI1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
