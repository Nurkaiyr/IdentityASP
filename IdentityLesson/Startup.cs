using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityLesson.Startup))]
namespace IdentityLesson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
