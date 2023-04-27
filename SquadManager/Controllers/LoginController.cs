using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using SquadManager.Validator;


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

    
            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }

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

