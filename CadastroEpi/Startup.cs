using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CadastroEpi.Startup))]
namespace CadastroEpi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
