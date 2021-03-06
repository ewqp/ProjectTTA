﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Logics;
using Library.EntityModel;

namespace Library.Logics
{
    public class DBRented
    {
        /// <summary>
        /// Adds an entry to the Rented
        /// </summary>
        public string AddRentEntry(int idAccount, int idBook, int idAuthor, DateTime rentDate)
        {
            var allRentInfo = new List<Models.RentInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    var newRentEntry = new Rented();
                    newRentEntry.IdAccount = idAccount;
                    newRentEntry.IdBook = idBook;
                    newRentEntry.IdAuthor = idAuthor;
                    newRentEntry.RentDate = rentDate;

                    con.Rented.Add(newRentEntry);
                    con.SaveChanges();
                    return "Book rented, an new entry was added.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        /// <summary>
        /// Deletes an entry from table Rented
        /// </summary>
        public string DeleteRentEntry(int idRented)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var rent = con.Rented.FirstOrDefault(r => r.IdRented == idRented);
                    con.Rented.Remove(rent);
                    con.SaveChanges();
                    return "Book is now avaliable in library.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        /// <summary>
        /// List of rented books
        /// </summary>
        public List<Rented> GetAllEntries()
        {
            var allEntries = new List<Rented>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    allEntries = con.Rented.ToList();

                }
            }
            catch (Exception ex)
            {

            }
            return allEntries;
        }
        
        /// <summary>
        /// Lisf of rented books (boosted)
        /// </summary>
        public List<Models.RentInfo> GetAllEntriesInfo()
        {
            var allRentsInfo = new List<Models.RentInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    List<Rented> allEntries = con.Rented.ToList();
                    List<History> allReantedBooks = con.History.ToList();

                    if (allEntries.Count == 0)
                        return allRentsInfo;

                    foreach (var rentedBook in allReantedBooks)
                    {
                        allEntries.Remove(allEntries.FirstOrDefault(e => e.IdBook == rentedBook.IdBook));
                    }

                    for (int i = 0; i < allEntries.Count; i++)
                    {
                        Models.RentInfo rentInfo = new Models.RentInfo();
                        rentInfo.IdRented = allEntries[i].IdRented;
                        rentInfo.IdAccount = allEntries[i].IdAccount;
                        rentInfo.IdBook = allEntries[i].IdBook;
                        rentInfo.IdAuthor = allEntries[i].IdAuthor;
                        rentInfo.RentDate = allEntries[i].RentDate;
                        rentInfo.AccountName = con.Account.FirstOrDefault(a => a.IdAccount == rentInfo.IdAccount).AccountName;
                        rentInfo.AccountSurname = con.Account.FirstOrDefault(s => s.IdAccount == rentInfo.IdAccount).AccountSurname;
                        rentInfo.Title = con.Book.FirstOrDefault(t => t.IdBook == rentInfo.IdBook).Title;
                        rentInfo.AuthorSurname = con.Author.FirstOrDefault(n => n.IdAuthor == rentInfo.IdAuthor).AuthorSurname;                        

                        allRentsInfo.Add(rentInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                allRentsInfo.Add(new Models.RentInfo { Error = ex.Message });
            }
            return allRentsInfo;
        }

        public List<Models.RentInfo> GetReallyAllEntriesInfo()
        {
            var allRentsInfo = new List<Models.RentInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    List<Rented> allEntries = con.Rented.ToList();

                    if (allEntries.Count == 0)
                        return allRentsInfo;

                    for (int i = 0; i < allEntries.Count; i++)
                    {
                        Models.RentInfo rentInfo = new Models.RentInfo();

                        rentInfo.IdRented = allEntries[i].IdRented;
                        rentInfo.IdBook = allEntries[i].IdBook;
                        rentInfo.IdAuthor = allEntries[i].IdAuthor;
                        rentInfo.RentDate = allEntries[i].RentDate;
                        rentInfo.IdAccount = allEntries[i].IdAccount;
                        rentInfo.AccountName = con.Account.FirstOrDefault(w => w.IdAccount == rentInfo.IdAccount).AccountName;
                        rentInfo.AccountSurname = con.Account.FirstOrDefault(z => z.IdAccount == rentInfo.IdAccount).AccountSurname;
                        rentInfo.Title = con.Book.FirstOrDefault(b => b.IdBook == rentInfo.IdBook).Title;
                        rentInfo.AuthorSurname = con.Author.FirstOrDefault(s => s.IdAuthor == rentInfo.IdAuthor).AuthorSurname;
                        

                        allRentsInfo.Add(rentInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                allRentsInfo.Add(new Models.RentInfo { Error = ex.Message });
            }
            return allRentsInfo;
        }
    }
}
