using Microsoft.AspNetCore.Mvc;

namespace MarketApp.WebUI.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
