using Microsoft.AspNetCore.Mvc;

namespace MarketApp.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
