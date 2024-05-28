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
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateOne(Category category)
        {
            _manager.Category.CreateOneCategory(category);
            _manager.Save();
        }

        public void DeleteOne(int id)
        {
            var category = _manager.Category.GetOneCategory(id, true);
            if(category is not null)
            {
                _manager.Category.DeleteOneCategory(category);
                _manager.Save();
            }
        }

        public IQueryable<Category> GetAll(bool trackChanges)
        {
            return _manager.Category.GetAllCategories(trackChanges);
        }

        public Category? GetOne(int id, bool trackChanges)
        {
            return _manager.Category.GetOneCategory(id, trackChanges);
        }

        public void UpdateOne(int id)
        {
            var category = _manager.Category.GetOneCategory(id, true);
            if(category is not null )
            {
                _manager.Category.UpdateOneCategory(category);
                _manager.Save();    
            }
        }
    }
}
