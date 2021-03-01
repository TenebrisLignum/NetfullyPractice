using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Repositories.Abstract;

namespace Finances.Domain
{
    public class DataManager
    {
        public IRecordsRepository EntityBase { get; set; }
        public ICategoriesRepository Categories { get; set; }
        public IUserRepository User { get; set; }
        public IFamilyRepository Family { get; set; }

        public DataManager(IRecordsRepository EntityBaseRepository,
            ICategoriesRepository CategoriesRepository,
            IUserRepository UserRepository,
            IFamilyRepository FamilyRepository)
        {
            EntityBase = EntityBaseRepository;
            Categories = CategoriesRepository;
            User = UserRepository;
            Family = FamilyRepository; 
        }
    }
}
