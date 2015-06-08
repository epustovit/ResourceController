using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResourceController.Backend.Startup))]
namespace ResourceController.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
