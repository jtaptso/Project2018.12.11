using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProject.UI.Startup))]
namespace MyProject.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
