using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Entities;

namespace Finances.Domain.Repositories.Abstract
{
    public interface IFamilyRepository
    {
        IQueryable<Family> GetFamily();
        Family GetFamilyById(string id);
        Family GetFamilyByName(string FamilyName);
        //Family GetFamilyByMates(string Mate);
        void SaveFamily(Family entity);
        void DeleteFamily(string id);
    }
}
