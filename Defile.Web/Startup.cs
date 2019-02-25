using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Defile.Web.Startup))]
namespace Defile.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
