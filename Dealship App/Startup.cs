using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dealship_App.Startup))]
namespace Dealship_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
