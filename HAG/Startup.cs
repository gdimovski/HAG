using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HAG.Startup))]
namespace HAG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
