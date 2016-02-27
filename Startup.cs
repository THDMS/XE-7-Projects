using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleKnockoutJS.Startup))]
namespace SampleKnockoutJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
