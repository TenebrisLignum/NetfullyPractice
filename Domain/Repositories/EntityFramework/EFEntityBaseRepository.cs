using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Finances.Domain.Entities;
using Finances.Domain.Repositories.Abstract;

namespace Finances.Domain.Repositories.EntityFramework
{
    public class EFEntityBaseRepository : IRecordsRepository
    {
        private readonly AppDbContext context;

        public EFEntityBaseRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<EntityBase> GetEntityBase()
        {
            return context.EntityBase;
        }

        public EntityBase GetEntityBaseById(Guid id)
        {
            return context.EntityBase.FirstOrDefault(x => x.Id == id);
        }

        public EntityBase GetEntityBaseByTheUser(string TheUser)
        {
            return context.EntityBase.FirstOrDefault(x => x.TheUser == TheUser);
        }

        public EntityBase GetEntityBaseByAmount(float Amount)
        {
            return context.EntityBase.FirstOrDefault(x => x.Amount == Amount);
        }

        public EntityBase GetEntityBaseByDirection(bool Direction)
        {
            return context.EntityBase.FirstOrDefault(x => x.Direction == Direction);
        }

        public EntityBase GetEntityBaseByCategory(string Category)
        {
            return context.EntityBase.FirstOrDefault(x => x.Category == Category);
        }

        public void SaveEntityBase(EntityBase entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteEntityBase(Guid id)
        {
            context.EntityBase.Remove(new EntityBase() { Id = id });
            context.SaveChanges();
        }
    }
}
