using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzicatoPizza.Startup))]
namespace PizzicatoPizza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
