using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OneToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace OneToMany.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("addPerson")]
        public IActionResult addPerson(Person newPerson)
        {
            if(ModelState.IsValid)
            {
                _context.People.Add(newPerson);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.AllPeople = _context.People.Include(s => s.Pets).ToList();
            return View();
        }

        [HttpPost("addCreature")]
        public IActionResult addCreature(Creature newCreature)
        {
            if(ModelState.IsValid)
            {
                _context.Creatures.Add(newCreature);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
                ViewBag.AllPeople = _context.People.Include(s => s.Pets).ToList();
                return View("Dashboard");
            }
        }

        [HttpGet("AllPets")]
        public IActionResult AllPets()
        {
            ViewBag.AllPets = _context.Creatures.Include(a => a.Owner).ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
