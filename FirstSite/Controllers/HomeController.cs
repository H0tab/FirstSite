using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstSite.Models;

namespace FirstSite.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(User user)
        {
            if (ModelState.IsValid)
            {
                return Content("Авторизация прошла успешно!");
                //Redirect("");
            }
            else
                return View(user);
        }
        
        public IActionResult LogIn()
        {
            Redirect("");
            return View("Index");
        }
    }
}
