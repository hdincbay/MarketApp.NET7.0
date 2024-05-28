using MarketApp.Entities.Models;
using MarketApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Services.Contracts
{
    public interface IProductService
    {
        public IQueryable<Product> GetAll(bool trackChanges);
        public Product? GetOne(int id, bool trackChanges);
        public void CreateOne(Product product);
        public void UpdateOne(int id);
        public void DeleteOne(int id);
    }
}
