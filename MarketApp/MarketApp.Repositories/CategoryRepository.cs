using MarketApp.Entities.Models;
using MarketApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneCategory(Category category) => Create(category);

        public void DeleteOneCategory(Category category) => Delete(category);

        public IQueryable<Category> GetAllCategories(bool trackChanges) => FindAll(trackChanges);

        public Category? GetOneCategory(int id, bool trackChanges) => FindByCondition(c => c.CategoryId.Equals(id), trackChanges);

        public void UpdateOneCategory(Category category) => Update(category);
    }
}
