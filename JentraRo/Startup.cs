using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JentraRo.Startup))]
namespace JentraRo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
