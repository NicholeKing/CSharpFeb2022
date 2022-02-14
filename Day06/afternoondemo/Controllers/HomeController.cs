using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using afternoondemo.Models;

namespace afternoondemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(Character newChar)
        {
            if(ModelState.IsValid)
            {
                if(newChar.race == "Elf")
                {
                    if(newChar.age < 50)
                    {
                        ModelState.AddModelError("race", "You must be over 50 to join this site!");
                        return View("Index");
                    }
                }
                return Redirect($"/Dashboard/{newChar.race}");
            } else {
                return View("Index");
            }
        }

        [HttpGet("Dashboard/{race}")]
        public IActionResult Dashboard(string race)
        {
            ViewBag.welcomeMessage = $"Welcome {race}!";
            return View("Dashboard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
