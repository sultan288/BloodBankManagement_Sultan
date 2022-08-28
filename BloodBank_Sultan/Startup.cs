using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sultan_FinalBB.Startup))]
namespace Sultan_FinalBB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
