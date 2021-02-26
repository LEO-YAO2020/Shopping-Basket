using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopBasket.Startup))]
namespace ShopBasket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
