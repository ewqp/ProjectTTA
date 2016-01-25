using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Services
{
    public interface IUserService
    {
        User Add(User user);
        void Remove(User user);
        void Update(User user);
        User Get(int id);
        IEnumerable<User> GetAllUsers();
    }
}
