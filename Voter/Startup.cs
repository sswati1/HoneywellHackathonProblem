using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Voter.Startup))]
namespace Voter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
