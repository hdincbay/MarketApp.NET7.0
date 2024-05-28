using MarketApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        public IQueryable<Product> GetAllProducts(bool trackChanges);
        public Product? GetOneProduct(int id, bool trackChanges);
        public void CreateOneProduct(Product product);
        public void UpdateOneProduct(Product product);
        public void DeleteOneProduct(Product product);
    }
}
