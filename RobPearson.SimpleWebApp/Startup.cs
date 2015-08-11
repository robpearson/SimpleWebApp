using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RobPearson.SimpleWebApp.Startup))]
namespace RobPearson.SimpleWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
