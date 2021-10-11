using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedSocialAdmin.Startup))]
namespace RedSocialAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
