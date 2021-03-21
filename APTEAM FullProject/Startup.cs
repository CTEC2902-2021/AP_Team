using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APTEAM_FullProject.Startup))]
namespace APTEAM_FullProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
