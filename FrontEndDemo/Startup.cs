using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontEndDemo.Startup))]
namespace FrontEndDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
