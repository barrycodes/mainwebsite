using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarryCodes.Startup))]
namespace BarryCodes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
