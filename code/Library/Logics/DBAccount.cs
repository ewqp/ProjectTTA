using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.EntityModel;
using Library.Models;

namespace Library.Logics
{
    public class DBAccount
    {

        /// <summary>
        /// List of all client's accounts
        /// </summary>
        public List<Account> GetAllAccounts()
        {
            var allAccounts = new List<Account>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    allAccounts = con.Account.ToList();

                }
            }
            catch (Exception ex)
            {

            }
            return allAccounts;
        }
        /// <summary>
        /// Account list (boosted)
        /// </summary>
        public List<AccountInfo> GetAllAccountsInfo()
        {
            var allAccountsInfo = new List<AccountInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    List<Account> allAccounts = con.Account.ToList();

                    if (allAccounts.Count == 0)
                        return allAccountsInfo;

                    for (int i = 0; i < allAccounts.Count; i++)
                    {
                        AccountInfo accountInfo = new AccountInfo();

                        accountInfo.IdAccount = allAccounts[i].IdAccount;
                        accountInfo.AccountName = allAccounts[i].AccountName;
                        accountInfo.AccountSurname = allAccounts[i].AccountSurname;
                        accountInfo.AccountEmail = allAccounts[i].AccountEmail;

                        allAccountsInfo.Add(accountInfo);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return allAccountsInfo;
        }
    }
}
