using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAlev_Devises.Startup))]
namespace CAlev_Devises
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
