using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteMap_Website.Startup))]
namespace SiteMap_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
