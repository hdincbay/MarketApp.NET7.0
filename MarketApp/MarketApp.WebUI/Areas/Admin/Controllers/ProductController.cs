using MarketApp.Entities.Models;
using MarketApp.Services.Contracts;
using MarketApp.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarketApp.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var result = from p in _manager.ProductService.GetAll(false)
                          join c in _manager.CategoryService.GetAll(false)
                          on p.CategoryId equals c.CategoryId
                          select new ResultModel
                          {
                              ProductId = p.ProductId,
                              ProductName = p.ProductName,
                              ImageUrl = p.ImageUrl,
                              CategoryName = c.CategoryName,
                              Price = p.Price
                          };
            return View(result.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_manager.CategoryService.GetAll(false), "CategoryId", "CategoryName", 1);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm]Product product, IFormFile file)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);
            using(var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            product.ImageUrl = String.Concat("/images/", file.FileName);
            _manager.ProductService.CreateOne(product);
            return RedirectToAction("Index");
        }
        [HttpGet("{id:int}")]
        public IActionResult Delete([FromRoute]int id) 
        {
            var product = _manager.ProductService.GetOne(id, true);
            if(product is not null)
            {
                _manager.ProductService.DeleteOne(product.ProductId);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Categories = new SelectList(_manager.CategoryService.GetAll(false), "CategoryId", "CategoryName", 1);
            var product = _manager.ProductService.GetOne(id, false);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromRoute]int id, IFormFile file)
        {
            var product = _manager.ProductService.GetOne(id, true);
            if(product is not null)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                product.ImageUrl = String.Concat("/images/", file.FileName);
                _manager.ProductService.UpdateOne(product.ProductId);
            }
            return RedirectToAction("Index");
        }
        
    }
}
