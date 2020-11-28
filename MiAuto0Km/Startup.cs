using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiAuto0Km.Startup))]
namespace MiAuto0Km
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
