using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Repositories.Abstract;

namespace Finances.Domain
{
    public class DataManager
    {
        // Клас для керування репозиторієм
        public IEntityBaseRepository EntityBase { get; set; }

        public DataManager(IEntityBaseRepository EntityBaseRepository)
        {
            EntityBase = EntityBaseRepository;
        }
    }
}
