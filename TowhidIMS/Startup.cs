using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TowhidIMS.Startup))]
namespace TowhidIMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
