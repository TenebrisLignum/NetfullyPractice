using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Entities;

namespace Finances.Domain.Repositories.Abstract
{
    public interface ICategoriesRepository
    {
        IQueryable<Categories> GetCategories();
        Categories GetCategoriesById(Guid id);
        Categories GetCategoriesByName(string Name);
        void SaveCategories(Categories entity);
        void DeleteCategories(Guid id);
    }
}

