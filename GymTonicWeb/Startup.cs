using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymTonicWeb.Startup))]
namespace GymTonicWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
