using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Entities;

namespace Finances.Domain.Repositories.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> GetUser();
        User GetUserById(string id);
        User GetUserByUserName(string UserName);
        User GetUserByEmail(string Email);
        void SaveUser(User entity);
        void DeleteUser(string id);
    }
}
