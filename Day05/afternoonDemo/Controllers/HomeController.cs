using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using afternoonDemo.Models;

namespace afternoonDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public static string ex = "Hello";

        [HttpGet]
        [Route("")] // when we land on localhost:5000/ that calls the Index function
        public IActionResult Index()
        {
            ViewBag.example = ex;
            // This returns a View, so I can see a webpage
            return View(); // If View is empty it looks to the name of the function, which in this case is Index
        }

        [HttpGet("example")] // localhost:5000/example
        public ViewResult Example()
        {
            // Depending on what is called in the parentheses, that will go look for a cshtml with that name
            // Either I write the name in or I make it assume the name of the function name
            return View("Example");
        }

        [HttpGet("Redirect")] // localhost:5000/redirect
        public RedirectToActionResult RedirectPage()
        {
            Console.WriteLine("You landed on the redirect page");
            return RedirectToAction("Index");
        }

        [HttpGet("examplePost")]
        public IActionResult examplePost()
        {
            Console.WriteLine("I redirected from examplePost");
            return RedirectToAction("Example");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
