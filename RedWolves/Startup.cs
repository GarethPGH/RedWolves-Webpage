using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedWolves.Startup))]
namespace RedWolves
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
