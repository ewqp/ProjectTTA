using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    public interface IAccountServices
    {
        AccountInfo Add(AccountInfo account);
        void Remove(AccountInfo account);
        void Update(AccountInfo account);
        AccountInfo Get(int id);
        IEnumerable<AccountInfo> GetAllAccounts();
    }
}
