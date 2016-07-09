using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test2Github.Startup))]
namespace Test2Github
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
