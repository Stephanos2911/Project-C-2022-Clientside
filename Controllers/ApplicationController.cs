﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserApplication.Models;

namespace UserApplication.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ILogger<ApplicationController> _logger;

        public ApplicationController(ILogger<ApplicationController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult OutsideMenu()
        {
            return View();
        }
        public IActionResult Startpagina()
        {
            return View();
        }
        public IActionResult Insideproductmenu()
        {
            return View();
        }
        public IActionResult MainMenu()
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