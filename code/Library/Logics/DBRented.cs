using System;
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
<<<<<<< HEAD
        /// <summary>
        /// Adds an entry to the Rented
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
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
<<<<<<< HEAD
=======
                    //newRentEntry.IdUser = idUser;
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87

                    con.Rented.Add(newRentEntry);
                    con.SaveChanges();
                    return "Entry was added.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

<<<<<<< HEAD
        /// <summary>
        /// Deletes an entry from table Rented
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
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

<<<<<<< HEAD
        /// <summary>
        /// List of rented books
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
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

<<<<<<< HEAD
        /// <summary>
        /// Lisf of rented books (boosted)
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
        public List<Models.RentInfo> GetAllEntriesInfo()
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
                        rentInfo.Title = con.Book.FirstOrDefault(b => b.IdBook == rentInfo.IdBook).Title;
                        rentInfo.AuthorSurname = con.Author.FirstOrDefault(s => s.IdAuthor == rentInfo.IdAuthor).AuthorSurname;
<<<<<<< HEAD
=======
                        //logInfo.UserName = con.User.FirstOrDefault(u => u.IdUser == logInfo.IdUser).UserName;
                        //logInfo.UserSurname = con.User.FirstOrDefault(t => t.IdUser == logInfo.IdUser).UserSurname;
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
                        rentInfo.AccountName = con.Account.FirstOrDefault(w => w.IdAccount == rentInfo.IdAccount).AccountName;
                        rentInfo.AccountSurname = con.Account.FirstOrDefault(z => z.IdAccount == rentInfo.IdAccount).AccountSurname;

                        allRentsInfo.Add(rentInfo);
                    }
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                allRentsInfo.Add(new Models.RentInfo { Error = ex.Message });
=======

>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
            }
            return allRentsInfo;
        }
    }
}
