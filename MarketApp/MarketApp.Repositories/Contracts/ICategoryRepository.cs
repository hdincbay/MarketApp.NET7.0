using MarketApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Repositories.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        public IQueryable<Category> GetAllCategories(bool trackChanges);
        public Category? GetOneCategory(int id, bool trackChanges);
        public void CreateOneCategory(Category category);
        public void UpdateOneCategory(Category category);
        public void DeleteOneCategory(Category category);
    }
}
