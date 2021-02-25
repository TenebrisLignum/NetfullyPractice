using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Entities;

namespace Finances.Domain.Repositories.Abstract
{
    public interface IEntityBaseRepository
    {
        IQueryable<EntityBase> GetEntityBase();
        EntityBase GetEntityBaseById(Guid id);
        EntityBase GetEntityBaseByAmount(float Amount);
        EntityBase GetEntityBaseByDirection(bool Direction);
        EntityBase GetEntityBaseByCategory(string Category);
        void SaveEntityBase(EntityBase entity);
        void DeleteEntityBase(Guid id);
    }
}
