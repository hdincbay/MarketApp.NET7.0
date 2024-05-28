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
    public class AboutManager : IAboutService
    {
        private readonly IRepositoryManager _manager;

        public AboutManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateOne(About about)
        {
            _manager.About.CreateOneAbout(about);
            _manager.Save();
        }

        public void DeleteOne(int id)
        {
            var about = _manager.About.GetOneAbout(id, true);
            if(about is not null)
            {
                _manager.About.DeleteOneAbout(about);
                _manager.Save();
            }
        }

        public IQueryable<About> GetAll(bool trackChanges)
        {
            return _manager.About.GetAllAbouts(trackChanges);
        }

        public About? GetOne(int id, bool trackChanges)
        {
            return _manager.About.GetOneAbout(id, trackChanges);
        }

        public void UpdateOne(int id)
        {
            var about = _manager.About.GetOneAbout(id, true);
            if(about is not null) 
            {
                _manager.About.UpdateOneAbout(about);
                _manager.Save();
            }
        }
    }
}
