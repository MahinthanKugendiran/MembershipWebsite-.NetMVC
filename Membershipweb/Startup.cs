using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Membershipweb.Startup))]
namespace Membershipweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
