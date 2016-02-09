using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlimpseMvcWebApp.Startup))]
namespace GlimpseMvcWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
