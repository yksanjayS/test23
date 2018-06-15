using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemoteAnalaysis.Startup))]
namespace RemoteAnalaysis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
