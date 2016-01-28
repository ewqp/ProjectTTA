using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Storage
{
    public interface IAccountRepository : IRepository<AccountInfo>
    {
        AccountInfo GetAccountById(int id);
        IEnumerable<AccountInfo> GetAllAccounts();
    }
}
