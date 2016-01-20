﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Logics;
using Library.EntityModel;

namespace Library.Logics
{
    public class DBHistory
    {
<<<<<<< HEAD
        /// <summary>
        /// Adds a rent/return entry to the History log
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
        public string AddHistoryEntry(int idAccount, int idBook, int idAuthor, DateTime actionDate, short status)
        {
            var allLogsInfo = new List<Models.HistoryInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    var newHistoryEntry = new History();
                    newHistoryEntry.IdAccount = idAccount;
                    newHistoryEntry.IdBook = idBook;
                    newHistoryEntry.IdAuthor = idAuthor;
                    newHistoryEntry.ActionDate = actionDate;
                    newHistoryEntry.Returned = status;
<<<<<<< HEAD
=======
                   // newHistoryEntry.IdUser = idUser;
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87

                    con.History.Add(newHistoryEntry);
                    con.SaveChanges();
                    return "Entry was added.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// List of entries from History log
=======
        /// Logs from History
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
        /// </summary>
        public List<History> GetAllHistoryLogs()
        {
            var allLogs = new List<History>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    allLogs = con.History.ToList();

                }
            }
            catch (Exception ex)
            {

            }
            return allLogs;
        }

        public List<Models.HistoryInfo> GetAllHistoryLogsInfo()
        {
            var allLogsInfo = new List<Models.HistoryInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    List<EntityModel.History> allLogs = con.History.ToList();

                    if (allLogs.Count == 0)
                        return allLogsInfo;

                    for (int i = 0; i < allLogs.Count; i++)
                    {
                        Models.HistoryInfo logInfo = new Models.HistoryInfo();

                        logInfo.IdHistory = allLogs[i].IdHistory;
                        logInfo.Returned = allLogs[i].Returned;
<<<<<<< HEAD
=======
                        //logInfo.IdUser = allLogs[i].IdUser;
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
                        logInfo.IdBook = allLogs[i].IdBook;
                        logInfo.ActionDate = allLogs[i].ActionDate;
                        logInfo.IdAuthor = allLogs[i].IdAuthor;
                        logInfo.IdAccount = allLogs[i].IdAccount;   
                        logInfo.Title = con.Book.FirstOrDefault(b => b.IdBook == logInfo.IdBook).Title;                        
                        logInfo.AuthorSurname = con.Author.FirstOrDefault(s => s.IdAuthor == logInfo.IdAuthor).AuthorSurname;
<<<<<<< HEAD
=======
                        //logInfo.UserName = con.User.FirstOrDefault(u => u.IdUser == logInfo.IdUser).UserName;
                        //logInfo.UserSurname = con.User.FirstOrDefault(t => t.IdUser == logInfo.IdUser).UserSurname;
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
                        logInfo.AccountName = con.Account.FirstOrDefault(w => w.IdAccount == logInfo.IdAccount).AccountName;
                        logInfo.AccountSurname = con.Account.FirstOrDefault(z => z.IdAccount == logInfo.IdAccount).AccountSurname;

                        allLogsInfo.Add(logInfo);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return allLogsInfo;
        }
    }
}