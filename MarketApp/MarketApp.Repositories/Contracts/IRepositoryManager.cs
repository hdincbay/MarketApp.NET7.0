using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        public IProductRepository Product { get; }
        public ICategoryRepository Category { get; }
        public IAboutRepository About { get; }
        public void Save();
    }
}
