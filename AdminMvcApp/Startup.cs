using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminMvcApp.Startup))]
namespace AdminMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
