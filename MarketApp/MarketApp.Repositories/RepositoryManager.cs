using MarketApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAboutRepository _aboutRepository;
        private readonly RepositoryContext _context;

        public RepositoryManager(IProductRepository productRepository, ICategoryRepository categoryRepository, IAboutRepository aboutRepository, RepositoryContext context)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _aboutRepository = aboutRepository;
            _context = context;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public IAboutRepository About => _aboutRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
