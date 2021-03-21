using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APTeamFootball.Startup))]
namespace APTeamFootball
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
