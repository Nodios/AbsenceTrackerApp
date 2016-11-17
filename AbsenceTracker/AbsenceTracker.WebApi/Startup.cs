using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbsenceTracker.WebApi.Startup))]
namespace AbsenceTracker.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
