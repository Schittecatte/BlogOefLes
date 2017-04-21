using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogOefLes.Startup))]
namespace BlogOefLes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
