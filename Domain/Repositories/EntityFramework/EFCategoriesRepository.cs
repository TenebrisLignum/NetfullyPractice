using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Finances.Domain.Entities;
using Finances.Domain.Repositories.Abstract;

namespace Finances.Domain.Repositories.EntityFramework
{
    public class EFCategoriesRepository : ICategoriesRepository
    {
        private readonly AppDbContext context;

        public EFCategoriesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteCategories(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Categories> GetCategories()
        {
            return context.Categories;
        }

        public Categories GetCategoriesById(Guid id)
        {
            return context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public Categories GetCategoriesByName(string Name)
        {
            return context.Categories.FirstOrDefault(x => x.Name == Name);
        }

        public void SaveCategories(Categories entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
