using MarketApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Repositories.Contracts
{
    public interface IAboutRepository : IRepositoryBase<About>
    {
        public IQueryable<About> GetAllAbouts(bool trackChanges);
        public About? GetOneAbout(int id, bool trackChanges);
        public void CreateOneAbout(About about);
        public void UpdateOneAbout(About about);
        public void DeleteOneAbout(About about);
    }
}
