using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlbumsLibrary.Startup))]
namespace AlbumsLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
