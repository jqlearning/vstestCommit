using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pOne1.Startup))]
namespace pOne1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
