﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Table()
        {
            ViewData["Message"] = "Your time table page.";

            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Your login page.";

            return View();
        }
        public IActionResult SignUp()
        {
            ViewData["Message"] = "Your Signup page.";

            return View();
        }
        public IActionResult ManageTable()
        {
            ViewData["Message"] = "Your managetable page.";

            return View();
        }
        public IActionResult BusBooking()
        {
            ViewData["Message"] = "Your BusBooking page.";

            return View();
        }
        
            public IActionResult Invoices()
        {
            ViewData["Message"] = "Your Invoice page.";

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ListOfVehicle()
        {
            ViewData["Message"] = "Your List of vehicle page.";
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
