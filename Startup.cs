using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebCRM.Startup))]
namespace MyWebCRM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
