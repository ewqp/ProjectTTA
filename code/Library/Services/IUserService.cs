using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    public interface IUserService
    {
        UserInfo Add(UserInfo user);
        void Remove(UserInfo user);
        void Update(UserInfo user);
        UserInfo Get(int id);
        IEnumerable<UserInfo> GetAllUsers();
    }
}
