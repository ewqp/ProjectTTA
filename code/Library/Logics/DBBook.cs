using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Library.Logics;
using Library.EntityModel;
using System.Data.Entity;

namespace Library.Logics
{
    public class DBBook
    {
        /// <summary>
        /// This method adds a new book to the Database.
        /// </summary>      
        public string AddBook(string title, int idAuthor, int idGenre)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newBook = new Book();
                    newBook.Title = title;
                    newBook.IdAuthor = idAuthor;
                    newBook.IdGenre = idGenre;

                    if (idAuthor == 0)
                        return "Author does not exist!";
                    con.Book.Add(newBook);
                    con.SaveChanges();
                    return "Book added succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        /// <summary>
        /// List of all books.
        /// </summary>
        public List<EntityModel.Book> GetAllBooks()
        {
            var allBooks = new List<EntityModel.Book>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    allBooks = con.Book.ToList();

                }
            }
            catch (Exception ex)
            {

            }
            return allBooks;
        }

        /// <summary>
        /// List of all books (boosted).
        /// </summary>
        public List<Models.BookInfo> GetAllBooksInfo()
        {
            var allBooksInfo = new List<Models.BookInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    List<EntityModel.Book> allBooks = con.Book.ToList();

                    if (allBooks.Count == 0)
                        return allBooksInfo;

                    for (int i = 0; i <= allBooks.Count; i++)
                    {
                        Models.BookInfo bookInfo = new Models.BookInfo();

                        bookInfo.IdBook = allBooks[i].IdBook;
                        bookInfo.IdGenre = allBooks[i].IdGenre;
                        bookInfo.IdAuthor = allBooks[i].IdAuthor;
                        bookInfo.Title = allBooks[i].Title;
                        bookInfo.Name = con.Author.FirstOrDefault(n => n.IdAuthor == bookInfo.IdAuthor).Surname;
                        bookInfo.Surname = con.Author.FirstOrDefault(s => s.IdAuthor == bookInfo.IdAuthor).Name;
                        bookInfo.Genre = con.BookGenre.FirstOrDefault(g => g.IdGenre == bookInfo.IdGenre).Genre;

                        allBooksInfo.Add(bookInfo);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return allBooksInfo;
        }

        /// <summary>
        /// This method updates book's record in DB.
        /// </summary>
        public string UpdateBook(int idBook, string title, int idAuthor, int idGenre)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var book = con.Book.FirstOrDefault(b => b.IdBook == idBook);
                    book.Title = title;
                    book.IdAuthor = idAuthor;
                    book.IdGenre = idGenre;                    
                    con.SaveChanges();
                    return "Book updated succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        /// <summary>
        /// This method deletes book's record in DB.
        /// </summary>
        public string DeleteBook(int idBook)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var book = con.Book.FirstOrDefault(b => b.IdBook == idBook);
                    con.Book.Remove(book);                   
                    con.SaveChanges();
                    return "Book deleted succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
