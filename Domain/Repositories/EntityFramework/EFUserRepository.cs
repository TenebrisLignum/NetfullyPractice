using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Finances.Domain.Entities;
using Finances.Domain.Repositories.Abstract;

namespace Finances.Domain.Repositories.EntityFramework
{
    public class EFUserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public EFUserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<User> GetUser()
        {
            return context.User;
        }

        public User GetUserById(string id)
        {
            return context.User.FirstOrDefault(x => x.Id == id);
        }

        public User GetUserByEmail(string Email)
        {
            return context.User.FirstOrDefault(x => x.Email == Email);
        }


        public User GetUserByUserName(string UserName)
        {
            return context.User.FirstOrDefault(x => x.UserName == UserName);
        }

        public void SaveUser(User entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteUser(string id)
        {
            context.User.Remove(new User() { Id = id });
            context.SaveChanges();
        }
    }
}
