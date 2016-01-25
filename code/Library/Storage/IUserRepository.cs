using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Storage
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserById(int id);
        User TakeUserData(string email, string password);
        IEnumerable<User> GetAllUsers();

    }
}
