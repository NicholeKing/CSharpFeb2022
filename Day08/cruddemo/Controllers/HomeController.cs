﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cruddemo.Models;
using Microsoft.EntityFrameworkCore;

namespace cruddemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // This gets me all icecreams in the database
            List<Icecream> allIceCreams = _context.Icecream.ToList();
            ViewBag.allIceCreams = allIceCreams;
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(Icecream newIcecream)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("It worked!");
                _context.Add(newIcecream);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("Index");
            }
        }

        [HttpGet("delete/{icid}")]
        public IActionResult deleteOne(int icid)
        {
            // Step one: find the thing we're trying to delete
            Icecream icToDelete = _context.Icecream.SingleOrDefault(a => a.IcecreamId == icid);
            _context.Icecream.Remove(icToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{icid}")]
        public IActionResult EditOne(int icid)
        {
            Icecream icToEdit = _context.Icecream.FirstOrDefault(a => a.IcecreamId == icid);
            return View(icToEdit);
        }

        [HttpPost("update/{icid}")]
        public IActionResult updateOne(int icid, Icecream editedIcecream)
        {
            Icecream orignal = _context.Icecream.FirstOrDefault(a => a.IcecreamId == icid);
            orignal.Flavor = editedIcecream.Flavor;
            orignal.Topping = editedIcecream.Topping;
            orignal.hasCherry = editedIcecream.hasCherry;
            orignal.Container = editedIcecream.Container;
            orignal.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
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
