using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hermesweb.Startup))]
namespace hermesweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
