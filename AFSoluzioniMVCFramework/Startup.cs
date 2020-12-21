using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AFSoluzioniMVCFramework.Startup))]
namespace AFSoluzioniMVCFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
