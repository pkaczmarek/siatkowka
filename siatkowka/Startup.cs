using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(siatkowka.Startup))]
namespace siatkowka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
