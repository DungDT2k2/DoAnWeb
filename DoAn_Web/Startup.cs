using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAn_Web.Startup))]
namespace DoAn_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
