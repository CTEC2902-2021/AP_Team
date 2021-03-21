using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppTeamFootball.Startup))]
namespace AppTeamFootball
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
