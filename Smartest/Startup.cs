using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smartest.Startup))]
namespace Smartest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
