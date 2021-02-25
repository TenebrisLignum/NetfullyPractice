using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Repositories.Abstract;

namespace Finances.Domain
{
    public class DataManager
    {
        public IEntityBaseRepository EntityBase { get; set; }
        public ICategoriesRepository Categories { get; set; }
        public IUserRepository User { get; set; }

        public DataManager(IEntityBaseRepository EntityBaseRepository, ICategoriesRepository CategoriesRepository, IUserRepository UserRepository)
        {
            EntityBase = EntityBaseRepository;
            Categories = CategoriesRepository;
            User = UserRepository;
        }
    }
}
