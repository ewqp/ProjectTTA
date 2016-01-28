using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Storage;

namespace Library.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository _accountsRepository;

        public AccountServices(IAccountRepository accountsRepository)
        {
            _accountsRepository = accountsRepository;
        }

        public AccountInfo Add(AccountInfo account)
        {
            if (account.AccountName == null || account.AccountSurname == null || account.AccountEmail == null)
            {
                throw new ArgumentException("You have to fill all Account informations.");
            }

            var accountDb = _accountsRepository.Persist(account);
            if (accountDb != null && accountDb.Id.HasValue)
            {
                return Get(accountDb.Id.Value);
            }

            return null;
        }

        public void Remove(AccountInfo account)
        {
            _accountsRepository.Remove(account);
        }

        public void Update(AccountInfo accountr)
        {
            _accountsRepository.Persist(accountr);
        }

        public AccountInfo Get(int id)
        {
            return _accountsRepository.GetAccountById(id);
        }

        public IEnumerable<AccountInfo> GetAllAccounts()
        {
            return _accountsRepository.GetAll();
        }
    }
}
