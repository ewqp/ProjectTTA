using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library.Models;


namespace Library.Storage
{
    public class AccountRepository : Repository<AccountInfo>, IAccountRepository
    {
        private readonly Func<DbContext> _contextFactory;
        public AccountRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public AccountInfo GetAccountById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<AccountInfo>().FirstOrDefault(u => u.IdAccount == id);
            }
        }
        public IEnumerable<AccountInfo> GetAllAccounts()
        {
            using (var context = _contextFactory())
            {
                return context.Set<AccountInfo>().ToList();
            }
        }

    }
}
