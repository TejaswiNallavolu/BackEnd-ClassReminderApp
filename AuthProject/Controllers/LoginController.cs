using AuthProject.Data;
using AuthProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public LoginController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("allUser")]
        public IActionResult GetAllUser()
        {
            var res = context.Users.ToList();
            return Ok(res);
        }
        [HttpGet("getAllList")]
        public IActionResult GetAllClassList()
        {
            var classList = context.ListOfClasses.ToList();
            return Ok(classList);
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return Ok(user);
        }

    }
}
