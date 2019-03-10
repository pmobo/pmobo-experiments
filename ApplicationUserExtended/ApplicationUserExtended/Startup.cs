using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using ApplicationUserExtended.Models;
using ApplicationUserExtended.Data;


[assembly: OwinStartup(typeof(ApplicationUserExtended.Startup))]

namespace ApplicationUserExtended
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.CreatePerOwinContext<UserContext>(UserContext.Create);
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
        }
    }
}
