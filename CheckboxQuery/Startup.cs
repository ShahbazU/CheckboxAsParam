using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckboxQuery.Startup))]
namespace CheckboxQuery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
