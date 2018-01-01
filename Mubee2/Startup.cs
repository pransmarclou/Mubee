using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mubee2.Startup))]
namespace Mubee2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
