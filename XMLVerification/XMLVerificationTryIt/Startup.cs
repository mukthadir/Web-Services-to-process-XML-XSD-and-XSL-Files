using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XMLVerificationTryIt.Startup))]
namespace XMLVerificationTryIt
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
