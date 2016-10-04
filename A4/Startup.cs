using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A4.Startup))]
namespace A4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
