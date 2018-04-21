using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(helpfox_sf.Startup))]
namespace helpfox_sf
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
