﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcDemo.Models;

namespace mvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public static List<Pet> allPets = new List<Pet>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            // If you don't include a name for the view then it will default to finding a cshtml file with the name of the action
            // ie: Index
            ViewBag.allPets = allPets;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost("addPet")]
        public IActionResult addPet(Pet newPet)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("Form submitted!");
                allPets.Add(newPet);
                return RedirectToAction("Index");
            } else {
                ViewBag.allPets = allPets;
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
