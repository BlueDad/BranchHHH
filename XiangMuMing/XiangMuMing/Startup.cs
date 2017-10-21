using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XiangMuMing.Startup))]
namespace XiangMuMing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
