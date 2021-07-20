using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductWeb.Startup))]
namespace ProductWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
