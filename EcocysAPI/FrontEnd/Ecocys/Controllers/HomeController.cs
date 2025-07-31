using Ecocys.Data;
using Ecocys.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ecocys.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult OurServices()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact_Us()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact_Us(ContactUs model)
        {
            if (ModelState.IsValid)
            {
                _context.ContactForms.Add(model);
                await _context.SaveChangesAsync();
                ViewBag.Message = "Your form has been submitted successfully!";
                return View(); // same Contact_Us.cshtml
            }

            ViewBag.Message = " Something went wrong. Please check your input.";
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
