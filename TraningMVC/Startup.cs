using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TraningMVC.Startup))]
namespace TraningMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
