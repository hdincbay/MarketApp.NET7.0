using MarketApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IAboutService _aboutService;

        public ServiceManager(IProductService productService, ICategoryService categoryService, IAboutService aboutService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _aboutService = aboutService;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;

        public IAboutService AboutService => _aboutService;
    }
}
