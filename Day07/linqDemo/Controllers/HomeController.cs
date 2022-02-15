using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using linqDemo.Models;

namespace linqDemo.Controllers
{
    public class HomeController : Controller
    {

        public static Game[] AllGames = new Game[] {
            new Game {Title = "Boggle", Genre = "Tabletop", Price = 8.00, Rating = "E"},
            new Game {Title = "Ghost of Tsushima", Genre = "action, adventure", Price = 37.99, Rating = "M"},
            new Game {Title = "Elden Ring", Genre = "RPG", Price = 60.00, Rating = "M"},
            new Game {Title = "Hades", Genre = "Roguelike", Price = 19.99, Rating = "PG13"},
            new Game {Title = "Bubsy 3D", Genre = "Platform", Price = 19.96, Rating = "E"},
            new Game{Title = "League of Legends", Genre="RPG", Price=0.00, Rating= "PG13"},
            new Game {Title = "UnrealTournament 1999 GOTY Edition", Genre = "FPS", Price = 29.99, Rating = "M"},
            new Game{Title = "Stardew Valley", Genre="RPG", Price=14.99, Rating= "E"},
            new Game {Title = "Savage Worlds", Genre = "Tabletop", Price = 29.99, Rating = "E"}
        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Give me all the games where genre is RPG
            IEnumerable<Game> LinqListOfGames = AllGames.Where(game => game.Rating == "E").OrderBy(h => h.Title);
            ViewBag.RatedE = LinqListOfGames;
            // Do it this way for lowest -> highest
            // IEnumerable<Game> SortByPrice = AllGames.OrderBy(g => g.Price);
            // Do it this way for highest -> lowest
            IEnumerable<Game> SortByPrice = AllGames.OrderByDescending(g => g.Price);
            ViewBag.OrderByPrice = SortByPrice;
            // FirstorDefault grabs the FIRST instance that meets a certain qualification
            Game SDV = AllGames.FirstOrDefault(f => f.Title == "Stardew Valley");
            ViewBag.SDV = SDV;
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
