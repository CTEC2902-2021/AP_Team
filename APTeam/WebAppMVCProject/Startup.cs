using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMVCProject.Startup))]
namespace WebAppMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
