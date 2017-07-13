using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Routing.Startup))]
namespace Routing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
