using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KatalogFilm.Startup))]
namespace KatalogFilm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
