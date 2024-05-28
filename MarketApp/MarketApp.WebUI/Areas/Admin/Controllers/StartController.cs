using Microsoft.AspNetCore.Mvc;

namespace MarketApp.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
