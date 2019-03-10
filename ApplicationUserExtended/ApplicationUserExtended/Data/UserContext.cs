using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApplicationUserExtended.Models;
namespace ApplicationUserExtended.Data
{
    public class UserContext : IdentityDbContext<ApplicationUser>
    {
        public UserContext() : base("ApplicationUserExtendedDBContext")
        {

        }


        public static UserContext Create()
        {
            return new UserContext();
        }
    }
}