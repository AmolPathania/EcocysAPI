using Microsoft.AspNetCore.Mvc;

namespace EcocysAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
