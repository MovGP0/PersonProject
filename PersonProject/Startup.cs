using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonProject.Startup))]
namespace PersonProject
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
