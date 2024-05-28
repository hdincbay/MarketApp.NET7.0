using MarketApp.Entities.Models;
using MarketApp.Repositories.Contracts;
using MarketApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;

        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateOne(Product product)
        {
            _manager.Product.CreateOneProduct(product);
            _manager.Save();
        }

        public void DeleteOne(int id)
        {
            var product = _manager.Product.GetOneProduct(id, true);
            if(product is not null)
            {
                _manager.Product.DeleteOneProduct(product);
                _manager.Save();
            }
        }

        public IQueryable<Product> GetAll(bool trackChanges)
        {
            return _manager.Product.GetAllProducts(trackChanges);
        }

        public Product? GetOne(int id, bool trackChanges)
        {
            return _manager.Product.GetOneProduct(id, trackChanges);
        }

        public void UpdateOne(int id)
        {
            var product = _manager.Product.GetOneProduct(id, true);
            if(product is not null)
            {
                _manager.Product.UpdateOneProduct(product);
                _manager.Save();
            }
        }
    }
}
