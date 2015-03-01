using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCApp2.Startup))]
namespace TestMVCApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
