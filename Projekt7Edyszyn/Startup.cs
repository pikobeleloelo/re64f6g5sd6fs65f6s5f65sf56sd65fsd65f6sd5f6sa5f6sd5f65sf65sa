using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekt7Edyszyn.Startup))]
namespace Projekt7Edyszyn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
