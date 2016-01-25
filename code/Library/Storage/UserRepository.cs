using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Library.Model;

namespace Library.Storage
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly Func<DbContext> _contextFactory;

        public UserRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public User GetUserById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<User>()
                    .FirstOrDefault(u => u.IdUser == id);
            }
        }
        public User TakeUserData(string email, string password)
        {
            using (var context = _contextFactory())
            {
                return context.Set<User>()
                    .FirstOrDefault(u => u.UserEmail == email && u.UserPassword == password);
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            using (var context = _contextFactory())
            {
                return context.Set<User>()
                    .ToList();
            }
        }
    }
}