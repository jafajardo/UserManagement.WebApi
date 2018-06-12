using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public ObjectResult GetUsers()
        {
            List<UserGroup> users = new List<UserGroup>
            {
                new UserGroup { Id = "a16dd0a7-c9f9-423b-8bc8-da4808d5dc73", Username = "user01@email.com", Groups = new string[] { "Admin", "BasicUser"} },
                new UserGroup { Id = "52d365a7-8e07-4874-bf03-df5e2aa07294", Username = "user02@email.com", Groups = new string[] { "BasicUser" } }
            };

            return Ok(users);
        }

        // [HttpGet]
        // public User GetUserDetails([FromQuery]string username)
        // {
        //     List<User> users = new List<User>
        //     {
        //         new User { Username = "user01@email.com", Firstname = "User01", Surname = "Surname01", Mobile = "123123123" },
        //         new User { Username = "user02@email.com", Firstname = "User02", Surname = "Surname02", Mobile = "987987987" }
        //     };

        //     var user = users.FirstOrDefault(u => u.Username == username);

        //     if (user != null)
        //     {
        //         return user;
        //     }
        //     else
        //     {
        //         return null;
        //     }
        // }
    }
}