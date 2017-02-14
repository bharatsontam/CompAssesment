using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompAssessment.Startup))]
namespace CompAssessment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
