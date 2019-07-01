using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(w57448_Arkadiusz_Kalita_projekt.Startup))]
namespace w57448_Arkadiusz_Kalita_projekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
