using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Finances.Domain.Entities;
using Finances.Domain.Repositories.Abstract;

namespace Finances.Domain.Repositories.EntityFramework
{
    public class EFFamilyRepository : IFamilyRepository
    {
        private readonly AppDbContext context;

        public EFFamilyRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Family> GetFamily()
        {
            return context.Family;
        }

        public Family GetFamilyById(string id)
        {
            return context.Family.FirstOrDefault(x => x.Id == id);
        }
        public Family GetFamilyByName(string Name)
        {
            return context.Family.FirstOrDefault(x => x.Name == Name);
        }

        public void SaveFamily(Family entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteFamily(string id)
        {
            context.Family.Remove(new Family() { Id = id });
            context.SaveChanges();
        }
    }
}
