using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApplicationUserExtended.Models;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ApplicationUserExtended.Data
{
    public class AppUserManager : UserManager<ApplicationUser>
    {
        public AppUserManager(IUserStore<ApplicationUser> store) : base(store)
        {
        }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> option, IOwinContext context)
        {
            UserContext dbApplicationUserContext = context.Get<UserContext>();
            var store = new UserStore<ApplicationUser>(dbApplicationUserContext);
            AppUserManager appUserManager = new AppUserManager(store);
            return appUserManager;
        }
    }
}