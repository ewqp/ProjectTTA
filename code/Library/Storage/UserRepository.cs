using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Library.Models;

namespace Library.Storage
{
    public class UserRepository : Repository<UserInfo>, IUserRepository
    {
        private readonly Func<DbContext> _contextFactory;

        public UserRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public UserInfo GetUserById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<UserInfo>()
                    .FirstOrDefault(u => u.IdUser == id);
            }
        }
        public UserInfo TakeUserData(string email, string password)
        {
            using (var context = _contextFactory())
            {
                return context.Set<UserInfo>()
                    .FirstOrDefault(u => u.UserEmail == email && u.UserPassword == password);
            }
        }

        public IEnumerable<UserInfo> GetAllUsers()
        {
            using (var context = _contextFactory())
            {
                return context.Set<UserInfo>()
                    .ToList();
            }
        }
    }
}