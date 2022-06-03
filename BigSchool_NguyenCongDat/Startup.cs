using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool_NguyenCongDat.Startup))]
namespace BigSchool_NguyenCongDat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
