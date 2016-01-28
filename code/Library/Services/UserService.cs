using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Storage;

namespace Library.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _usersRepository;

        public UserService(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public UserInfo Add(UserInfo user)
        {
            if (user.UserName == null || user.UserSurname == null || user.UserEmail == null || user.UserPassword == null)
            {
                throw new ArgumentException("The user has to have all informations.");
            }

            var userDb = _usersRepository.Persist(user);
            if (userDb != null && userDb.Id.HasValue)
            {
                return Get(userDb.Id.Value);
            }

            return null;
        }

        public void Remove(UserInfo user)
        {
            _usersRepository.Remove(user);
        }

        public void Update(UserInfo user)
        {
            _usersRepository.Persist(user);
        }

        public UserInfo Get(int id)
        {
            return _usersRepository.GetUserById(id);
        }

        public IEnumerable<UserInfo> GetAllUsers()
        {
            return _usersRepository.GetAll();
        }
    }
}
