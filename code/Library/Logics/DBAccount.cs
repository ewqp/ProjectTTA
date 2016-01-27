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
        public string AddAccount(string name, string surname, string email)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newAccount = new Account();
                    newAccount.AccountName = name;
                    newAccount.AccountSurname = surname;
                    newAccount.AccountEmail = email;

                    con.Account.Add(newAccount);
                    con.SaveChanges();
                    return "Account created.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public string UpdateAccount(int idAccount, string name, string surname, string email)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var account = con.Account.FirstOrDefault(b => b.IdAccount == idAccount);
                    account.AccountName = name;
                    account.AccountSurname = surname;
                    account.AccountEmail = email;
                    con.SaveChanges();
                    return "Account updated succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public string DeleteAccount(int idAccount)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var account = con.Account.FirstOrDefault(a => a.IdAccount == idAccount);
                    con.Account.Remove(account);
                    con.SaveChanges();
                    return "Account deleted succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

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
        /// <summary>
        /// Add a new account for a client
        /// </summary>
        public string AddAccount(string name, string surname, string email)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newAccount = new Account();
                    newAccount.AccountName = name;
                    newAccount.AccountSurname = surname;
                    newAccount.AccountEmail = email;
                    
                    con.Account.Add(newAccount);
                    con.SaveChanges();
                    return "Account added succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
        public string UpdateAccount(int idAccount, string name, string surname, string email)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var account = con.Account.FirstOrDefault(a => a.IdAccount == idAccount);
                    account.AccountName = name;
                    account.AccountSurname = surname;
                    account.AccountEmail = email;
                    con.SaveChanges();
                    return "Account updated succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public string DeleteAccount(int idAccount)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var account = con.Account.FirstOrDefault(a => a.IdAccount == idAccount);
                    con.Account.Remove(account);
                    con.SaveChanges();
                    return "Account deleted succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
