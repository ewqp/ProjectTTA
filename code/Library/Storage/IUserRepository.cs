using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Storage
{
    public interface IUserRepository : IRepository<UserInfo>
    {
        UserInfo GetUserById(int id);
        UserInfo TakeUserData(string email, string password);
        IEnumerable<UserInfo> GetAllUsers();

    }
}
