using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(reddit.Startup))]
namespace reddit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
