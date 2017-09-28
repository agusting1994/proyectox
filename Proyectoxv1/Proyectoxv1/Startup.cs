using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyectoxv1.Startup))]
namespace Proyectoxv1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
