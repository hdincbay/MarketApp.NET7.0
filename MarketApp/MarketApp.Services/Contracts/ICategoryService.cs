using MarketApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Services.Contracts
{
    public interface ICategoryService
    {
        public IQueryable<Category> GetAll(bool trackChanges);
        public Category? GetOne(int id, bool trackChanges);
        public void CreateOne(Category category);
        public void UpdateOne(int id);
        public void DeleteOne(int id);
    }
}
