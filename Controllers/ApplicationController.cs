using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserApplication.Models;

namespace UserApplication.Controllers
{
    public class ApplicationController : Controller
    {
        // dependency injection of the ApplicationDbContext
        private ApplicationDbContext _context;

        public ApplicationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Action methods for various pages
        public IActionResult FavorietenPagina()
        {
            return View();
        }

        public IActionResult Gratis()
        {
            return View();
        }

        public IActionResult Startpagina()
        {
            return View();
        }

        public IActionResult Productmenu()
        {
            return View();
        }

        public ViewResult MainMenu()
        {
            return View();
        }

        // displays the details of a product with a specific id
        public IActionResult ProductInfo(Guid id)
        {
            Product CurrentProduct = _context.Products.Find(id);
            return View(CurrentProduct);
        }

        // GET method for displaying the contact page
        [HttpGet]
        public IActionResult ContactPage()
        {
            return View();
        }

        // POST method for handling form submission on the contact page
        [HttpPost]
        public IActionResult ContactPage(Message message)
        {
            // sets IsAnswered property of message to false, adds message to the context and saves changes
            message.IsAnswered = false;
            _context.Messages.Add(message);
            _context.SaveChanges();
            // redirects back to the contact page
            return RedirectToAction("ContactPage");
        }

        // displays a list of products based on the id of the room they belong to
        [HttpGet]
        public IActionResult ProductenOverzicht(int id)
        {
            // retrieves all products with the specified room id from the context
            var AllProductsofRoom = _context.Products.Where(x => x.Place == id);
            // passes the list of products to the view for display
            return View(AllProductsofRoom);
        }

        // displays the details of a product with a specific id
        public IActionResult ProductPagina(Guid id)
        {
            Product CurrentProduct = _context.Products.Find(id);
            return View(CurrentProduct);
        }
    }
}
