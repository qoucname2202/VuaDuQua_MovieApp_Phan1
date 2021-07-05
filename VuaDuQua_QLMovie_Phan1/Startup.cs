using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuaDuQua_QLMovie_Phan1.Startup))]
namespace VuaDuQua_QLMovie_Phan1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
