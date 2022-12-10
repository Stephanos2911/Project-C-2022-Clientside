﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserApplication.Models;

namespace UserApplication.Controllers
{
    public class ApplicationController : Controller
    {

        private ApplicationDbContext _context;
        private readonly ILogger<ApplicationController> _logger;

        public ApplicationController(ILogger<ApplicationController> logger, ApplicationDbContext context)
        {
            _context = context;
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
        public IActionResult ProductenOverzicht()
        {
            return View();
        }
        public IActionResult Insideproductmenu()
        {
            return View();
        }
        public ViewResult MainMenu()
        {
            return View();
        }
        public IActionResult ProductInfo(Guid id)
        {
            Product CurrentProduct = _context.Products.Find(id);
            return View(CurrentProduct);
        }

        [HttpGet]
        public IActionResult ContactPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactPage(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("ContactPage");
        }

        public IActionResult ProductOverzicht(string id) 
        {
            //all products with the specified room
            var AllProductsofRoom = _context.Products.Where(x => x.Place == id).ToList();
            
            return View(AllProductsofRoom);
        }

        public IActionResult ProductPagina(Guid id)
        {
            Product CurrentProduct = _context.Products.Find(id);

            return View(_context.Products.SingleOrDefault(x => x.Name == "Kantelbare Waterkoker"));
        }
    }
}