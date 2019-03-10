using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApplicationUserExtended.Models;
using ApplicationUserExtended.Data;
using System.Web;
using Microsoft.Owin.Host.SystemWeb;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace ApplicationUserExtended.Controllers
{
    [RoutePrefix("api/Tasks")]
    public class TasksController : ApiController
    {


        [HttpGet]
        public IHttpActionResult GetTaskAsync()
        {
            var list = new List<Task>
            {
                new Task{ID = "41asdasd", CreatedOn = DateTime.Now, Name = "1"},
                new Task{ID = "43asdasd", CreatedOn = DateTime.Now, Name = "2"},
                new Task{ID = "43asdasd", CreatedOn = DateTime.Now, Name = "3"},
                new Task{ID = "44asdasd", CreatedOn = DateTime.Now, Name = "4"},
            };
            return Ok(list);
        }


        [HttpGet]
        [Route("Create")]
        public async System.Threading.Tasks.Task<IHttpActionResult> CreateUserAsync()
        {
            var user = new ApplicationUser()
            {
                UserName = "Guilherme",
                Email = "contato@gsoster.com",
                HasProjectOnline = false
            };
            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<AppUserManager>();
            IdentityResult resut = await userManager.CreateAsync(user, "123456");
            if (resut.Succeeded)
                return Ok("User created!");
            else
                return BadRequest(string.Join(",",resut.Errors));
        }


    }
}
