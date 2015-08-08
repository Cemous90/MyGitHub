using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTrunk.Web.Startup))]
namespace MyTrunk.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
