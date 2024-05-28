using MarketApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Services.Contracts
{
    public interface IAboutService
    {
        public IQueryable<About> GetAll(bool trackChanges);
        public About? GetOne(int id, bool trackChanges);
        public void CreateOne(About about);
        public void UpdateOne(int id);
        public void DeleteOne(int id);
    }
}
