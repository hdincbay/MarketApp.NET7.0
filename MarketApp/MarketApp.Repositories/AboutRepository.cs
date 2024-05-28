using MarketApp.Entities.Models;
using MarketApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Repositories
{
    public class AboutRepository : RepositoryBase<About>, IAboutRepository
    {
        public AboutRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneAbout(About about) => Create(about);

        public void DeleteOneAbout(About about) => Delete(about);

        public IQueryable<About> GetAllAbouts(bool trackChanges) => FindAll(trackChanges);

        public About? GetOneAbout(int id, bool trackChanges) => FindByCondition(a => a.AboutId.Equals(id), trackChanges);

        public void UpdateOneAbout(About about) => Update(about);
    }
}
