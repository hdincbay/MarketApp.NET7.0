using Microsoft.AspNetCore.Mvc;

namespace MarketApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();  
        }
    }
}
