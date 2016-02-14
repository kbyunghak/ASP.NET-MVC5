using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWebPrimer.Startup))]
namespace MvcWebPrimer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
