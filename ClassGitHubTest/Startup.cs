using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassGitHubTest.Startup))]
namespace ClassGitHubTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
