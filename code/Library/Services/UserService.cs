using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
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

        public User Add(User user)
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

        public void Remove(User user)
        {
            _usersRepository.Remove(user);
        }

        public void Update(User user)
        {
            _usersRepository.Persist(user);
        }

        public User Get(int id)
        {
            return _usersRepository.GetUserById(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _usersRepository.GetAll();
        }




    }
}
