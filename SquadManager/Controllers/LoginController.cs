using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;


// TODO: make the interface
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SquadManager.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            user.Email = "email enviado";
            return View("Index", user);

        }

        [HttpPost]

        public IActionResult Test(UserViewModel user)
        {
           user.Email = "email enviado";
           return View("Index", user);
        }

    }
}

