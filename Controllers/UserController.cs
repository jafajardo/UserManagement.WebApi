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
            List<User> users = new List<User>
            {
                new User {  Firstname = "User01", Surname = "Surname01", Mobile = "123123123" },
                new User { Firstname = "User02", Surname = "Surname02", Mobile = "987987987" }
            };

            return Ok(users);
        }
    }
}