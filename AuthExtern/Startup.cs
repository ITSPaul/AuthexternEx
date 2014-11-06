using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthExtern.Startup))]
namespace AuthExtern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
