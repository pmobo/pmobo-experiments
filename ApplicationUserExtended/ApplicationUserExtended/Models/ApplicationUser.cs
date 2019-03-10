using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationUserExtended.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool? HasProjectOnline { get; set; }
    }
}